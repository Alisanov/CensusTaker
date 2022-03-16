using LiteDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using CensusTakerWinFrom.Properties;
using Emgu;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;
using PdfiumViewer;

namespace CensusTakerWinFrom
{
    public partial class Operation : FormStyle
    {
        //для данных с локальной базы
        private List<Guid> idPersonalAccount;
        private IEnumerable<Class.PersonalAccount> dataPersonalAccount;
        private Class.PersonalAccount personalAccount;
        private List<Guid> idAddress;

        //для панели
        int widthZoom;
        bool flagmousebutton = false, checkClearAddress = true;
        
        //для координат положения мышки
        int mouseX, mouseY;
        
        public Operation()//открытие формы с нуля 
        {
            InitializeComponent();
            personalAccount = null;
        }
        public Operation(Class.PersonalAccount personalAccount)//открытие с лицевого счета
        {
            InitializeComponent();
            this.personalAccount = personalAccount;
        }
        private void Operation_Load(object sender, EventArgs e)//загрузка формы при первом запуске
        {
            //привыязываем обработчик к панели для просмотра изображения
            panel.MouseWheel += new MouseEventHandler(this.PanelMouseWheel);
            panel.AutoScroll = true;
            //восстаналиваем размеры формы 
            Bounds = new Main().LoadSizeForn(Settings.Default.OperationProperties, Bounds);
            //привязываем обработчик с выпадающему списку
            comboBoxAddress.SelectedIndexChanged += new EventHandler(LoadingPersonalAccount);
            comboBoxPersonalAccount.SelectedIndexChanged += new EventHandler(LoadingOperation);

            //выделяем память для хранения идентификаторов 
            idPersonalAccount = new List<Guid>();
            idAddress = new List<Guid>();
            
            //загружаем форму дальше
            OperationLoading(sender, e);
        }
        private void OperationLoading(object sender, EventArgs e)
        {
            //очищаем списки 
            idAddress.Clear();
            comboBoxAddress.Items.Clear();
            //подключаемся к локальной базе 
            using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
            {
                //вытаскиваем данные адресной книги 
                LiteCollection<Class.Address> tableAddress = database.GetCollection<Class.Address>(Class.AddressText);
                IEnumerable<Class.Address> dataAddress = tableAddress.FindAll();
                //перебираем списки адресов
                foreach (var address in dataAddress)
                {
                    idAddress.Add(address.ID);
                    comboBoxAddress.Items.Add(address.FullAddress());
                    //если лицевой счет есть, то выбираем его адрес 
                    if (personalAccount != null &&  personalAccount.AddressID == address.ID)
                        comboBoxAddress.SelectedIndex = comboBoxAddress.Items.Count - 1;
                }
            }
            //на случай если нет лицевого счета
            if (comboBoxAddress.Items.Count > 0 && comboBoxAddress.SelectedIndex == -1)
                comboBoxAddress.SelectedIndex = 0;
            else
                LoadingPersonalAccount(sender, e);
            
        }
        private void LoadingPersonalAccount(object sender, EventArgs e)
        {
            
            infoPersonalAccount.Text = "Информация по лицевому счету";
            //очищаем список лицевых счетов
            comboBoxPersonalAccount.Items.Clear();
            idPersonalAccount.Clear();
            //подключаемся к локальной базе 
            LiteDatabase database = new LiteDatabase(Settings.Default.Database);
            //вытаскиваем данные лицевых счетов 
            LiteCollection<Class.PersonalAccount> tablePersonalAccount = database.GetCollection<Class.PersonalAccount>(Class.PersonalAccountText);
            if (comboBoxAddress.SelectedIndex != -1)
                dataPersonalAccount = tablePersonalAccount.Find(x => x.AddressID.Equals(idAddress[comboBoxAddress.SelectedIndex]));
            else
                dataPersonalAccount = tablePersonalAccount.FindAll();
            //перебираем список лицевых счетов
            foreach (var personalAccount in dataPersonalAccount)
            {
                comboBoxPersonalAccount.Items.Add(personalAccount.NamePersonalAcc);
                if (this.personalAccount != null && personalAccount.ID == this.personalAccount.ID)
                    comboBoxPersonalAccount.SelectedIndex = comboBoxPersonalAccount.Items.Count - 1;
                
            }
            if (comboBoxPersonalAccount.Items.Count > 0 && comboBoxPersonalAccount.SelectedIndex == -1)
                comboBoxPersonalAccount.SelectedIndex = 0;
        }
        private void LoadingOperation(object sender, EventArgs e)//загрузка операции
        {
            //для итогов
            double total = 0, totalYear = 0;
            //смотрим какой лицевой счет выбрали
            if(comboBoxPersonalAccount.SelectedIndex != -1)
                personalAccount = dataPersonalAccount.ElementAt(comboBoxPersonalAccount.SelectedIndex);

            if (personalAccount != null)
            {
                //загружаем информацию  по лицевому счету
                string resourse = string.Empty, company = string.Empty;
                using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
                {
                    LiteCollection<Class.Resource> tableResourse = database.GetCollection<Class.Resource>(Class.ResourseText);
                    Class.Resource resourseResult = tableResourse.FindById(personalAccount.ResourceID);
                    resourse = resourseResult.Name;

                    LiteCollection<Class.Company> tableCompany = database.GetCollection<Class.Company>(Class.CompanyText);
                    Class.Company companyResult = tableCompany.FindById(personalAccount.CompanyID);
                    company = companyResult.Name;
                }
                infoPersonalAccount.Text = "Лицевой счет: " + string.Format("{0:#,###0.#}", personalAccount.PersonalAcc) + "\n" +
                    "Организация: " + company + "\n" +
                    "Ресурс: " + resourse + "\n" +
                    "Установленный тариф: " + personalAccount.Tariff;
                tariff.Text = personalAccount.Tariff.ToString();

                //смотрим привязан ли лицевой счет какому-либо адресу
                if (checkClearAddress && comboBoxAddress.SelectedIndex == -1)
                {
                    int count = 0;
                    foreach (Guid id in idAddress)
                    {
                        if (personalAccount.AddressID.Equals(id))
                        {
                            comboBoxAddress.SelectedIndex = count;
                            break;
                        }
                        count++;
                    }
                }
                else
                    checkClearAddress = true;

                //подключаемся к локальной базе и загружаем данные по операциям 
                using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
                {
                    //вытаскиваем данные по операциям
                    LiteCollection<Class.Operation> tableOperation = database.GetCollection<Class.Operation>(Class.OperationText);
                    IEnumerable<Class.Operation> dataOperation;

                    //ищем те, которые привязанны к лицевому счету и с пустыми сслыками
                    dataOperation = tableOperation.Find(x => x.PersonalAccountID.Equals(personalAccount.ID) || x.PersonalAccountID == Guid.Empty);

                    //объявляем счетчик и очищаем таблицу 
                    int i = 0;
                    dataGridOperation.Rows.Clear();
                    bool thisOperation = false;

                    //сортируем по дате
                    dataOperation = dataOperation.OrderBy(x => x.Date);
                    //убираем вниз с пустыми ссылками
                    dataOperation = dataOperation.OrderByDescending(x => x.PersonalAccountID);
                    foreach (var operation in dataOperation)
                    {
                        //добавляем строку
                        dataGridOperation.Rows.Add();
                        //заполняем данными 
                        dataGridOperation.Rows[i].Cells[0].Value = operation.ID;
                        dataGridOperation.Rows[i].Cells[1].Value = operation.Status;
                        dataGridOperation.Rows[i].Cells[2].Value = operation.Date;

                        //заполняем данными 
                        dataGridOperation.Rows[i].Cells[4].Value = operation.OldIndicators;
                        dataGridOperation.Rows[i].Cells[5].Value = operation.NewIndicators;
                        dataGridOperation.Rows[i].Cells[6].Value = operation.Tariff;
                        dataGridOperation.Rows[i].Cells[7].Value = operation.People;

                        //загружаем картинку, если она есть 
                        if (operation.MemoryImage != null)
                        {
                            MemoryStream memoryStream = new MemoryStream(operation.MemoryImage);
                            if (memoryStream.Length != 0)
                                dataGridOperation.Rows[i].Cells[9].Value = Image.FromStream(memoryStream);
                            dataGridOperation.Rows[i].Height = 100;
                        }
                        dataGridOperation.Rows[i].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                        string _personalAcc = string.Empty;
                        //если  у операции нет лицевого счета, то сумму не учитываем
                        if (operation.NamePersonalAccount(ref _personalAcc))
                        {

                            thisOperation = true;
                            //цветовая гамма
                            switch (operation.Date.Month)
                            {
                                case 1:
                                    dataGridOperation.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(91, 0, 157);//январь
                                    dataGridOperation.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                                    break;
                                case 2:
                                    dataGridOperation.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(0, 0, 254);//февраль
                                    dataGridOperation.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                                    break;
                                case 3:
                                    dataGridOperation.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(37, 159, 160);//март
                                    break;
                                case 4:
                                    dataGridOperation.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(26, 105, 0);//апрель
                                    dataGridOperation.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                                    break;
                                case 5:
                                    dataGridOperation.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(61, 255, 0);//май
                                    break;
                                case 6:
                                    dataGridOperation.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 0);//июнь
                                    break;
                                case 7:
                                    dataGridOperation.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(249, 166, 0);//июль
                                    break;
                                case 8:
                                    dataGridOperation.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(246, 108, 1);//август
                                    break;
                                case 9:
                                    dataGridOperation.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(246, 50, 0);//сентябрь
                                    break;
                                case 10:
                                    dataGridOperation.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(244, 0, 0);//октябрь
                                    break;
                                case 11:
                                    dataGridOperation.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(183, 0, 166);//ноябрь
                                    dataGridOperation.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                                    break;
                                case 12:
                                    dataGridOperation.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(164, 0, 255);//декабрь
                                    dataGridOperation.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                                    break;
                            }
                            //заполняем сумму операции
                            if (operation.Status)
                            {
                                double sum = 0;
                                //вычисляем сумму оплаты по методу
                                if (operation.PaymetMethod)
                                    sum = operation.People * operation.Tariff;
                                else
                                    sum = (operation.NewIndicators - operation.OldIndicators) * operation.Tariff;
                                if (operation.Date.Year == DateTime.Now.Year)
                                    totalYear += sum;
                                total += sum;
                                dataGridOperation.Rows[i].Cells[8].Value = string.Format("{0:N}", sum) + " ₽";
                            }
                        }
                        else
                            dataGridOperation.Rows[i].Cells[8].Value = " - ₽";
                        //присваиваем лицевой счет
                        dataGridOperation.Rows[i].Cells[3].Value = _personalAcc;
                        i++;
                    }

                    //делаем активную последнюю строчку 
                    if (dataGridOperation.Rows.Count > 0)
                    {
                        dataGridOperation.FirstDisplayedScrollingRowIndex = dataGridOperation.RowCount - 1;
                        dataGridOperation.CurrentCell = dataGridOperation.Rows[dataGridOperation.Rows.Count - 1].Cells[1];
                    }
                    //в зависимости от типа лицевого счета определяем, какая информация будет отображаться 
                    if (personalAccount != null)
                        if (personalAccount.PaymetMethod)
                        {
                            oldIndicators.Enabled = false;
                            newIndicators.Enabled = false;
                            dataGridOperation.Columns[4].Visible = false;
                            dataGridOperation.Columns[5].Visible = false;
                            dataGridOperation.Columns[7].Visible = true;
                            peopleOperation.Enabled = true;
                            peopleOperation.Text = personalAccount.People.ToString();
                        }
                        else
                        {
                            oldIndicators.Enabled = true;
                            newIndicators.Enabled = true;
                            dataGridOperation.Columns[4].Visible = true;
                            dataGridOperation.Columns[5].Visible = true;
                            dataGridOperation.Columns[7].Visible = false;
                            peopleOperation.Enabled = false;
                            if (i == 0 || !thisOperation)
                                oldIndicators.Text = "0";
                            else
                                oldIndicators.Text = dataOperation.Last(x => x.PersonalAccountID == personalAccount.ID).NewIndicators.ToString();
                        }
                }
                this.totalYear.Text = "Итог по лицевому счету за год: " + string.Format("{0:N}", totalYear) + " ₽";
                this.total.Text = "Общий итог по лицевому счету: " + string.Format("{0:N}", total) + " ₽";
            }
            else
            {
                //если нет лицевого счета, то все убираем
                oldIndicators.Text = string.Empty;
                newIndicators.Text = string.Empty;
                tariff.Text = string.Empty;
                infoPersonalAccount.Text = "Информация по лицевому счету";
            }
            //отображаем выбранные данные
            SelectGridDataOperation(sender, e);

        }
        private bool CheckInput(ref int oldIn,ref int newIn,ref int people, ref double tar)//проверка ввода
        {
            if (string.IsNullOrWhiteSpace(comboBoxPersonalAccount.Text))
            {
                errorProvider.SetError(comboBoxPersonalAccount, "Пустое поле!");
                return false;
            }
            else if (comboBoxPersonalAccount.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBoxPersonalAccount, "Выберите из списка!");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(tariff.Text))
            {
                errorProvider.SetError(tariff, "Пустое поле!");
                return false;
            }
            else if (!double.TryParse(tariff.Text, out tar))
            {
                errorProvider.SetError(tariff, "Введите числовое значение!");
                return false;
            }
            else if (!personalAccount.PaymetMethod)
            {
                if (string.IsNullOrWhiteSpace(oldIndicators.Text))
                {
                    errorProvider.SetError(oldIndicators, "Пустое поле!");
                    return false;
                }
                else if (!int.TryParse(oldIndicators.Text.Trim(), out oldIn))
                {
                    errorProvider.SetError(oldIndicators, "Введите числовое значение!");
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(newIndicators.Text))
                {
                    errorProvider.SetError(newIndicators, "Пустое поле!");
                    return false;
                }
                else if (!int.TryParse(newIndicators.Text.Trim(), out newIn))
                {
                    errorProvider.SetError(newIndicators, "Введите числовое значение!");
                    return false;
                }
                else if (oldIn > newIn)
                {
                    errorProvider.SetError(newIndicators, "Новые показания должны быть больше!");
                    return false;
                }
                else
                    return true;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(peopleOperation.Text))
                {
                    errorProvider.SetError(peopleOperation, "Пустое поле!");
                    return false;
                }
                else if (!int.TryParse(peopleOperation.Text.Trim(), out people))
                {
                    errorProvider.SetError(peopleOperation, "Введите числовое значение!");
                    return false;
                }
                else
                    return true;
            }
        }
        private void InsertOperation(object sender, EventArgs e)//ввод информацию в локальную базу
        {
            int oldIn = 0, newIn = 0, people = 0;
            double tar = 0;
            if (CheckInput(ref oldIn, ref newIn, ref people, ref tar))
            {
                using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
                {
                    MemoryStream memoryStream = new MemoryStream();
                    if (pictureCheck.Image != null)
                        pictureCheck.Image.Save(memoryStream, ImageFormat.Png);
                    
                    else
                    {
                        if (!root.Checked)
                            dateOperation.Value += (DateTime.Now - dateOperation.Value);
                    }
                    LiteCollection<Class.Operation> tableOperation = database.GetCollection<Class.Operation>(Class.OperationText);
                    Class.Operation operation = new Class.Operation
                    {
                        PersonalAccountID = personalAccount.ID,
                        Date = dateOperation.Value,
                        NewIndicators = newIn,
                        OldIndicators = oldIn,
                        Tariff = tar,
                        People = people,
                        Status = status.Checked
                    };
                    if (memoryStream.Length != 0)
                        operation.MemoryImage = memoryStream.ToArray();
                    tableOperation.Insert(operation);
                    ClearBox(sender, e);
                    LoadingOperation(sender, e);
                }
            }
        }
        private void DeleteOperation(object sender, EventArgs e)//удаление инфомации с локальной базы
        {
            if (dataGridOperation.CurrentRow != null)
            {
                using (LiteDatabase database = new LiteDatabase(Properties.Settings.Default.Database))
                {
                    LiteCollection<Class.Operation> tableOperation = database.GetCollection<Class.Operation>(Class.OperationText);
                    tableOperation.EnsureIndex(x => x.ID);
                    tableOperation.Delete(x => x.ID.Equals(dataGridOperation.Rows[dataGridOperation.CurrentRow.Index].Cells[0].Value));
                }
                LoadingOperation(sender, e);
            }
            else
                errorProvider.SetError(dataGridOperation, "Выберите строку на удаление!");
        }
        private void EditOperation(object sender, EventArgs e)//редактирование инфомации с локальной базы 
        {
            if (dataGridOperation.CurrentRow != null && personalAccount != null)
            {
                int oldIn = 0, newIn = 0, people = 0;
                double tar = 0;
                if (CheckInput(ref oldIn, ref newIn, ref people, ref tar))
                {
                    MemoryStream memoryStream = new MemoryStream();
                    if (pictureCheck.Image != null)
                    {
                        pictureCheck.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    if (!root.Checked)
                        dateOperation.Value += (DateTime.Now - dateOperation.Value);
                    using (LiteDatabase database = new LiteDatabase(Properties.Settings.Default.Database))
                    {
                        LiteCollection<Class.Operation> tableOperation = database.GetCollection<Class.Operation>(Class.OperationText);
                        Class.Operation operation = tableOperation.FindById((Guid)dataGridOperation.Rows[dataGridOperation.CurrentRow.Index].Cells[0].Value);

                        operation.PersonalAccountID = personalAccount.ID;
                        operation.Date = dateOperation.Value;
                        operation.NewIndicators = newIn;
                        operation.OldIndicators = oldIn;
                        operation.Tariff = tar;
                        operation.People = people;
                        operation.Status = status.Checked;
                        if (memoryStream.Length != 0)
                            operation.MemoryImage = memoryStream.ToArray();
                        else
                            operation.MemoryImage = null;
                        tableOperation.Update(operation);

                    }
                    int index = 0;
                    if (dataGridOperation.CurrentRow != null)
                        index = dataGridOperation.CurrentRow.Index;
                    LoadingOperation(sender, e);
                    //dataGridAddress.Rows[index].Selected = true;
                    dataGridOperation.CurrentCell = dataGridOperation.Rows[index].Cells[1];
                    ClearBox(sender, e);
                }
            }
            else
                errorProvider.SetError(comboBoxPersonalAccount, "Выберите из списка!");
        }
        private void TextChangedSumm(object sender, EventArgs e)//подсчет суммы здесь и сейчас
        {
            if (personalAccount != null && personalAccount.PaymetMethod)
            {
                if (int.TryParse(peopleOperation.Text.Trim(), out int i) && double.TryParse(tariff.Text, out double t))
                    summ.Text = "Сумма: " + string.Format("{0:N}", i * t) + " ₽";
                else
                    summ.Text = "Введите числовое значение!";
            }
            else
            {
                if (int.TryParse(oldIndicators.Text, out int o) && int.TryParse(newIndicators.Text, out int n) && double.TryParse(tariff.Text, out double t1))
                {
                    if (n > o)
                        summ.Text = "Сумма: " + string.Format("{0:N}", (n - o) * t1) + " ₽";
                    else
                        summ.Text = "Новый показатель меньше старого!";
                }
                else
                    summ.Text = "Введите числовое значение!";
            }
        }
        private void CloseClick(object sender, EventArgs e)//закрытие формы
        {
            Close();
        }
        private void RootCheckedChanged(object sender, EventArgs e)//активация и деактивация раширенной функции
        {
            if (root.Checked)
            {
                //edit.Enabled = true;
                //delete.Enabled = true;
                //if (personalAccount != null)
                //{
                //    if (!personalAccount.PaymetMethod)
                //        oldIndicators.Enabled = true;
                //}
                //else
                //    oldIndicators.Enabled = true;
                //dateOperation.Enabled = true;
                status.Enabled = true;
                SelectGridDataOperation(sender, e);
            }
            else
            {
                //edit.Enabled = false;
                //delete.Enabled = false;
                //oldIndicators.Enabled = false;
                //dateOperation.Enabled = false;
                status.Enabled = false;
                status.Checked = true;
            }
        }
        private void SelectGridDataOperation(object sender, EventArgs e)//дублирование информации, которую выбрали 
        {
            if (root.Checked)
            {
                if(personalAccount != null && dataGridOperation.CurrentRow != null && dataGridOperation.Rows[dataGridOperation.CurrentRow.Index].Cells[0].Value != null)
                {
                    dateOperation.Value = (DateTime)dataGridOperation.Rows[dataGridOperation.CurrentRow.Index].Cells[2].Value;
                    tariff.Text = dataGridOperation.Rows[dataGridOperation.CurrentRow.Index].Cells[6].Value.ToString();
                    if (!personalAccount.PaymetMethod)
                    {
                        oldIndicators.Text = dataGridOperation.Rows[dataGridOperation.CurrentRow.Index].Cells[4].Value.ToString();
                        newIndicators.Text = dataGridOperation.Rows[dataGridOperation.CurrentRow.Index].Cells[5].Value.ToString();
                    }
                    else
                    {
                        peopleOperation.Text = dataGridOperation.Rows[dataGridOperation.CurrentRow.Index].Cells[7].Value.ToString();
                    }
                    if (dataGridOperation.Rows[dataGridOperation.CurrentRow.Index].Cells[9].Value != null)
                        pictureCheck.Image = (Image)dataGridOperation.Rows[dataGridOperation.CurrentRow.Index].Cells[9].Value;
                    else
                        pictureCheck.Image = null;
                    fileСheck.Text = string.Empty;
                }
            }
        }
        private void SelectCheck(object sender, EventArgs e)//открываем чек в новом окне для лучшего отображения
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                Filter = "Файлы изображений(*.bmp, *.jpg, *.png, *jpeg, *pdf)| *.bmp; *.jpg; *.png; *.jpeg; *.pdf"
            };
            if (openFile.ShowDialog() == DialogResult.OK)
                TextRecognition(sender, e, openFile.FileName);
        }
        private void TextRecognition(object sender, EventArgs e, string openFile)//метод распознавания чека
        {
            if (DialogResult.OK == MessageBox.Show("На данный момент распознавание возможно с чека Сбербанк Онлайн\nПродолжить?", "Загрузка чека", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
            {
                if (!string.IsNullOrWhiteSpace(openFile))
                {
                    try
                    {
                        string text = string.Empty;
                        if (openFile.Contains("pdf"))
                        {
                            using (PdfDocument document = PdfDocument.Load(openFile))
                            {
                                Image image = document.Render(0, 300, 300, true);
                                openFile = openFile.Replace("pdf", "jpeg");
                                image.Save(openFile, ImageFormat.Jpeg);
                            }
                        }
                        pictureCheck.Image = Image.FromFile(openFile);
                        fileСheck.Text = openFile;
                        pictureCheck.Width = panel.Width;
                        pictureCheck.Height = panel.Height;
                        pictureCheck.Location = new Point(0, 0);
                        widthZoom = pictureCheck.Width;
                        //if (File.Exists("tessdata"))
                        //    throw new Exception("Необходимо скачать пакет tessdata");
                        using (Tesseract tessract = new Tesseract(@"tessdata", "rus", OcrEngineMode.TesseractLstmCombined))
                        {
                            tessract.SetImage(new Image<Bgr, byte>(fileСheck.Text));
                            tessract.Recognize();
                            text = tessract.GetUTF8Text();
                        }

                        if (!text.ToUpper().Contains(Settings.Default.KeyString.ToUpper()))
                            throw new Exception("Это другой чек\nОтмена операции");

                        char terminator = '|';

                        text = Regex.Replace(text, "(\r\n\r\n\r\n|\r\n\r\n|\r\n)", terminator.ToString());

                        List<string> texts = StringTerminator(terminator, text);

                        string personalAccount = string.Empty;
                        string company = string.Empty;
                        string resourse = string.Empty;
                        double tariff = -1;
                        string summStr = string.Empty;

                        DateTime date = dateOperation.Value;
                        int old = -1, newN = -1;

                        errorProvider.Clear();
                        for (int i = 0; i < texts.Count; i++)
                        {
                            //Поиск лицевого счета
                            if (personalAccount.Equals(string.Empty) && Regex.IsMatch(texts[i], "(" + Settings.Default.KeyPersonalAcc + ")", RegexOptions.IgnoreCase))
                                personalAccount = Regex.Replace(texts[i + 1], "[^0-9]", string.Empty);

                            //Поиск даты
                            if (date.Equals(dateOperation.Value) && Regex.IsMatch(texts[i], "(" + Settings.Default.KeyDate + ")", RegexOptions.IgnoreCase))
                            {
                                string data = Regex.Replace(texts[i + 1], "(м|мс|мк|мск|с|ск|к)$", string.Empty, RegexOptions.IgnoreCase);
                                if (DateTime.TryParse(data, out date))
                                {
                                    DateTime time = new DateTime();
                                    if (DateTime.TryParse(texts[i + 3], out time))
                                        date += time.TimeOfDay;
                                }
                                else
                                    date = dateOperation.Value;

                            }

                            //поиск старых показаний
                            if (old == -1 && Regex.IsMatch(texts[i], "(" + Settings.Default.KeyOld + ")", RegexOptions.IgnoreCase))
                            {
                                string strOld = Regex.Replace(texts[i + 1], "[^0-9.,]", string.Empty);
                                strOld = strOld.Replace('.', ',');
                                double oldDoble = 0;
                                if (double.TryParse(strOld, out oldDoble))
                                    old = (int)oldDoble;
                                else
                                    errorProvider.SetError(oldIndicators, "Неудалось разпознать старые показания!");

                                //if (!string.IsNullOrWhiteSpace(oldIndicators.Text))
                                //{
                                //    int oldThis = int.Parse(oldIndicators.Text);
                                //    if (old != oldThis)
                                //        if (DialogResult.OK == MessageBox.Show("Значения старых показании отличаются\nЗаменить?", old.ToString(), MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                                //            oldIndicators.Text = old.ToString();
                                //}
                                //else
                                //    oldIndicators.Text = old.ToString();
                            }

                            //поиск новых показаний
                            if (newN == -1 && Regex.IsMatch(texts[i], "(" + Settings.Default.KeyNew + ")", RegexOptions.IgnoreCase))
                            {
                                string strNew = Regex.Replace(texts[i + 1], "[^0-9.,]", string.Empty);
                                strNew = strNew.Replace('.', ',');
                                double newDouble = 0;
                                if (double.TryParse(strNew, out newDouble))
                                    newN = (int)newDouble;
                                else
                                    errorProvider.SetError(newIndicators, "Неудалось разпознать новые показания!");
                            }

                            //поиск компании
                            if (company.Equals(String.Empty) && Regex.IsMatch(texts[i], "(" + Settings.Default.KeyCompany + ")", RegexOptions.IgnoreCase))
                            {
                                for (int k = i + 1; k < texts.Count; k++)
                                    if (Regex.IsMatch(texts[k], "(" + Settings.Default.KeyCompanyEnd + ")", RegexOptions.IgnoreCase))
                                        break;
                                    else
                                        company += " " + texts[k];
                            }
                            //поиск суммы
                            if (summStr.Equals(string.Empty) && Regex.IsMatch(texts[i], "(" + Settings.Default.KeyTariff + ")", RegexOptions.IgnoreCase))
                            {
                                summStr = Regex.Replace(texts[i + 1], "(РУБ.|РУБ|Р.|Р)", string.Empty);
                                summStr = summStr.Replace('.', ',');
                            }
                        }

                        using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
                        {
                            LiteCollection<Class.PersonalAccount> tablePersonalAccount = database.GetCollection<Class.PersonalAccount>(Class.PersonalAccountText);
                            this.personalAccount = tablePersonalAccount.FindOne(x => x.PersonalAcc.Equals(personalAccount));
                        }

                        if (this.personalAccount == null && personalAccount != string.Empty)
                        {
                            if (DialogResult.OK == MessageBox.Show("Лицевой счет отсутствует в базе\nДобавить?", personalAccount, MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                            {
                                if (company.ToUpper().Contains("ГАЗ"))
                                    resourse = "ГАЗ";
                                else if (company.ToUpper().Contains("ЭНЕРГО"))
                                    resourse = "СВЕТ";
                                else if (company.ToUpper().Contains("ЭКО"))
                                    resourse = "МУСОР";
                                else if (company.ToUpper().Contains("РОСТЕЛЕКОМ"))
                                    resourse = "ИНТЕРНЕТ";
                                else if (company.ToUpper().Contains("ТРИКОЛОР"))
                                    resourse = "ТЕЛЕВИДЕНИЕ";
                                else if (company.ToUpper().Contains("МЕГАФОН") && company.ToUpper().Contains("БИЛАЙН"))
                                    resourse = "СВЯЗЬ";

                                double summ = 0;
                                if (double.TryParse(summStr, out summ) && old != -1 && newN != -1)
                                    tariff = summ / (newN - old);
                                else if (double.TryParse(summStr, out summ))
                                    tariff = summ / 5;

                                new PersonalAccount(personalAccount, company, resourse, tariff).ShowDialog();

                                //OperationLoading(sender, e);
                            }
                        }

                        using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
                        {
                            LiteCollection<Class.PersonalAccount> tablePersonalAccount = database.GetCollection<Class.PersonalAccount>(Class.PersonalAccountText);
                            this.personalAccount = tablePersonalAccount.FindOne(x => x.PersonalAcc.Equals(personalAccount));
                        }

                        if (this.personalAccount != null)
                        {
                            //расчет тарифа
                            OperationLoading(sender, e);
                            double summ = 0;
                            if (double.TryParse(summStr, out summ) && this.personalAccount.PaymetMethod)
                                tariff = summ / this.personalAccount.People;
                            else if (double.TryParse(summStr, out summ) && old != -1 && newN != -1)
                                tariff = summ / (newN - old);
                            else
                                errorProvider.SetError(this.tariff, "Неудалось распознать!");
                        }

                        comboBoxPersonalAccount.Text = personalAccount + " " + resourse;

                        if (date.Equals(dateOperation.Value))
                            errorProvider.SetError(dateOperation, "Неудалось разпознать дату!");
                        else
                            dateOperation.Value = date;
                        if (old != -1)
                            oldIndicators.Text = old.ToString();
                        else
                            oldIndicators.Text = string.Empty;
                        if (newN != -1)
                            newIndicators.Text = newN.ToString();
                        else
                            newIndicators.Text = string.Empty;
                        if (tariff != -1)
                            this.tariff.Text = tariff.ToString();
                        else if (personalAccount == null)
                            this.tariff.Text = string.Empty;
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, err.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private List<string> StringTerminator(char terminator, string text)//метода для разбиения строки
        {
            int index = 0;
            List<string> result = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == terminator)
                {
                    string addstr;
                    if (index == 0)
                        addstr = text.Substring(index, i);
                    else
                        addstr = text.Substring(index + 1, i - index - 1);
                    if (!addstr.Equals(string.Empty))
                        result.Add(addstr);
                    index = i;
                }
            }
            return result;
        }
        private void ClearBox(object sendr, EventArgs e)//очитска полей 
        {
            if(root.Checked)
                oldIndicators.Text = string.Empty;
            newIndicators.Text = string.Empty;
            pictureCheck.Image = null;
            fileСheck.Text = string.Empty;
            errorProvider.Clear();
        }
        private void ClearImage(object sender, EventArgs e)//очистка изображения
        {
            pictureCheck.Image = null;
            fileСheck.Text = string.Empty;
        }
        private void DataGridOperationCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)//открывает чек в новом окне
        {
            if(dataGridOperation.CurrentCell != null && dataGridOperation.CurrentCell == dataGridOperation.Rows[dataGridOperation.CurrentCell.RowIndex].Cells[9] && dataGridOperation.Rows[dataGridOperation.CurrentCell.RowIndex].Cells[9].Value != null)
                new ZoomCheck((Image)dataGridOperation.Rows[dataGridOperation.CurrentCell.RowIndex].Cells[9].Value).ShowDialog();
            
        }
        private void PictureCheckDoubleClick(object sender, EventArgs e)//открывает чек в новом окне
        {
            if (pictureCheck.Image != null)
                new ZoomCheck(pictureCheck.Image).ShowDialog();
        }
        private void OperationFormClosing(object sender, FormClosingEventArgs e) //при закрытия окна сохраняем настройки
        {
            Settings.Default.OperationProperties = Bounds;
            Settings.Default.Save();
        }
        private void ClearAddressClick(object sender, EventArgs e) //очистка поля адреса
        {
            checkClearAddress = false;
            personalAccount = null;
            comboBoxAddress.SelectedIndex = -1;
        }
        
        //загрузка файла переносом
        private void DragEnterFile(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move))
                e.Effect = DragDropEffects.Move;
        }
        private void DragDropFile(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Move)
            {
                string[] objects = (string[])e.Data.GetData(DataFormats.FileDrop);
                // В objects хранятся пути к папкам и файлам
                fileСheck.Text = string.Empty;
                if (objects.Length > 0)
                { 
                    TextRecognition(sender, e, objects[0]);
                }
            }
        }

        //работа с изображением
        private void PanelMouseWheel(object sender, MouseEventArgs e)
        {
            if (pictureCheck.Image != null)
                if (e.Delta > 0)
                {
                    pictureCheck.Width += 80; ;
                    pictureCheck.Height += 160;
                    pictureCheck.Location = new Point(pictureCheck.Location.X - 40, pictureCheck.Location.Y - 80);
                }
                else
                {
                    if (pictureCheck.Width > widthZoom)
                    {
                        pictureCheck.Width -= 80;
                        pictureCheck.Height -= 160;
                        pictureCheck.Location = new Point(pictureCheck.Location.X + 40, pictureCheck.Location.Y + 80);
                    }
                }
        }
        private void PictureCheckMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                flagmousebutton = true;
                mouseX = e.X;
                mouseY = e.Y;
                Cursor = Cursors.Hand;
            }
        }
        private void PictureCheckMouseUp(object sender, MouseEventArgs e)
        {
            if (flagmousebutton == true)
            {
                flagmousebutton = false;
                this.Cursor = Cursors.Default;
            }
        }
        private void PictureCheckMouseMove(object sender, MouseEventArgs e)
        {
            if (flagmousebutton == true)
            {
                int dx = e.X - mouseX;
                int dy = e.Y - mouseY;
                pictureCheck.Location = new Point(pictureCheck.Location.X + dx, pictureCheck.Location.Y + dy);
            }
        }

    }
}