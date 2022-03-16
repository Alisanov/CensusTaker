using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using CensusTakerWinFrom.Properties;
using LiteDB;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;
using System.Windows;

namespace CensusTakerWinFrom
{
    public partial class Main : FormStyle
    {
        //для хранения списка лицевых счетов
        List<Class.PersonalAccount> personalAccounts;
        //для хранения индекса адресов
        private List<Guid> idAddress = new List<Guid>();

        public Main()//инициализация компонентов формы
        {
            InitializeComponent();
        }

        private void PersonalAccountToolStripClick(object sender, EventArgs e)//открытие формы лицевых счетов
        {
            //сохранение текущих размеров формы
            SaveSizeForm();
            //открытие формы "Лицевые счета"
            PersonalAccount personalAccount = new PersonalAccount();
            try
            {
                Visible = false;
                personalAccount.ShowDialog();
                Visible = true;
            }
            catch (Exception err)
            {
                Visible = true;
                personalAccount.Close();
                Sos(err);
            }
            //перезагрузка информации о лицевых счетах
            LoadingInfo(sender, e);
        }
        private void OperationToolStripClick(object sender, EventArgs e)//открытие формы операции
        {
            //сохранение текущих размеров формы
            SaveSizeForm();
            //открытие формы "Операции"
            Operation operation = new Operation();
            try
            {
                Visible = false;
                operation.ShowDialog();
                Visible = true;
            }
            catch (Exception err)
            {
                Visible = true;
                operation.Close();
                Sos(err);
            }
            //перезагрузка информации о лицевых счетах
            LoadingInfo(sender, e);
        }
        private void AddressToolStripMenuItem_Click(object sender, EventArgs e)//открытие адресной книги
        {
            //сохранение текущих размеров формы
            SaveSizeForm();
            //открытие формы "Адресная книга"
            AddressBook addressBook = new AddressBook();

            try
            {
                //скрываем текущию форму
                Visible = false;
                //запоминаем текущий выбранный индекс, выпадающего списка адресов
                int index = comboBoxAddress.SelectedIndex;
                //открываем форму
                addressBook.ShowDialog();
                //после закрытия обновляем информацию об адресах
                LoadingAddress();
                //если индекс превышает размер списка, то уменшаем его
                if (index < comboBoxAddress.Items.Count)
                    comboBoxAddress.SelectedIndex = index;
                else
                    comboBoxAddress.SelectedIndex = comboBoxAddress.Items.Count - 1;
                //перезагружаем информацию на главной форму
                Main_Load(sender, e);
                //показываем текущую форму
                Visible = true;
            }
            //в случае обнаружения ошибки закрываем форму "Адресная книга" и показываем текущую
            catch (Exception err)
            {
                Visible = true;
                addressBook.Close();
                //показываем ошибку
                Sos(err);
            }
        }

        private void Main_Load(object sender, EventArgs e)//загрузка формы
        {
            //проверяем сущетсвует ли база
            if (CheckDB())
            {
                try
                {
                    //привязываем обработчик к выпадающему списку (загрузка диаграммы)
                    comboBoxAddress.SelectedIndexChanged += new EventHandler(this.LoadingChart);
                    comboBoxAddress.SelectedIndexChanged += new EventHandler(this.LoadingInfo);
                    personalAccounts = new List<Class.PersonalAccount>();
                    monthCalendar.SelectionStart = new DateTime(DateTime.Now.Year, 1, 1);
                    monthCalendar.SelectionEnd = new DateTime(DateTime.Now.Year, 12, 31);
                }
                //отлавливаем ошибки и показываем
                catch (Exception err)
                {
                    Sos(err);
                }
                //загрузка информации
                LoadingInfo(sender, e);
            }
        }
        private void LoadingAddress() //загрузка информации об адресах
        {
            //очищаем список адресов
            comboBoxAddress.Items.Clear();
            idAddress.Clear();
            //подключаемся к локальной базе
            using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
            {
                //вытаскиваем таблицу с адресами
                LiteCollection<Class.Address> tableAddress = database.GetCollection<Class.Address>(Class.AddressText);
                //загружаем весь список
                IEnumerable<Class.Address> addresses = tableAddress.FindAll();
                //загружаем в адреса в список
                foreach (var address in addresses)
                {
                    idAddress.Add(address.ID);
                    comboBoxAddress.Items.Add(address.FullAddress());
                }
            }
        }
        private void LoadingInfo(object sender, EventArgs e)//загружаем информацию на текущей форме
        {
            try
            {
                //загружаем размер формы с настроек
                Bounds = LoadSizeForn(Settings.Default.MainProperties, Bounds);
                //подключаемся к локальной базе
                using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
                {
                    //объявляем индекс
                    int index = -1;
                    //запоминаем индекс, если есть данные 
                    if (listView.SelectedIndices.Count > 0)
                        index = listView.SelectedIndices[0];
                    //очищаем данные
                    listView.Items.Clear();
                    personalAccounts.Clear();
                    //создаем заголовок уведомлений за текущий месяц
                    info.Text = "Оплата за " + DateTime.Now.ToString("MMMM");
                    //вытаскиваем данные о лицевых счетах
                    LiteCollection<Class.PersonalAccount> tablePersonaAccount = database.GetCollection<Class.PersonalAccount>(Class.PersonalAccountText);
                    IEnumerable<Class.PersonalAccount> dataPersonalAccount;
                    //если адрес не выбран, то загружаем все, иначе только за выбранный адрес 
                    if (comboBoxAddress.SelectedIndex == -1)
                        dataPersonalAccount = tablePersonaAccount.FindAll();
                    else
                        dataPersonalAccount = tablePersonaAccount.Find(x => x.AddressID.Equals(idAddress[comboBoxAddress.SelectedIndex]));
                    //сортируем по дате создания
                    dataPersonalAccount = dataPersonalAccount.OrderBy(x => x.Date);
                    //проходимся по лицевым счетам
                    foreach (Class.PersonalAccount personalAccount in dataPersonalAccount)
                    {
                        //загружаем в список лицевых счетов
                        personalAccounts.Add(personalAccount);
                        //проверяем оплату за текущий месяц
                        if (personalAccount.PaidСurrentMonth(database))
                        {
                            listView.Items.Add(personalAccount.NamePersonalAcc + " оплачен");
                            listView.Items[listView.Items.Count - 1].ForeColor = Color.DarkGreen;
                        }
                        else
                        {
                            listView.Items.Add(personalAccount.NamePersonalAcc + " не оплачен");
                            listView.Items[listView.Items.Count - 1].ForeColor = Color.DarkRed;
                        }
                    }
                    //если до этого был выделен элемент списка, выделяем его 
                    if (index != -1 && index < listView.Items.Count)
                        listView.Items[index].Selected = true;
                }
            }
            //отлавливаем ошибки и показываем 
            catch (Exception err)
            {
                Sos(err);
            }
        }

        private void ListViewDoubleClick(object sender, EventArgs e)//обработчик двойного клика по списку лицевых счетов
        {
            //сохранение текущих размеров формы
            SaveSizeForm();
            //инициализация формы "Операции"
            Operation operation = new Operation();
            try
            {
                //если в списке есть лицевые счета, то продолжаем выполнение
                if (listView.SelectedIndices.Count > 0)
                {
                    //скрываем текущую форму
                    Visible = false;
                    //на форму отправляем лицевой счет, который выбрали
                    operation = new Operation(personalAccounts[listView.SelectedIndices[0]]);
                    //показываем форму
                    operation.ShowDialog();
                    //после закрытия формы "Операции" показываем текущую 
                    Visible = true;
                }
                else
                    return;
            }
            //отлавливаем ошибки, в случае обнаружения показываем текущую форму и закрываем форму "Операции"
            catch (Exception err)
            {
                Visible = true;
                operation.Close();
                Sos(err);
            }
            //обновляем информацию на форме
            LoadingInfo(sender, e);
            LoadingChart(sender, e);
        }
        private void SaveSizeForm()//для сохранения размеров формы в параметрах
        {
            Settings.Default.MainProperties = Bounds;
            Settings.Default.Save();
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)//при закрытии формы сохраняем размеры формы
        {
            SaveSizeForm();
        }

        private void LoadingChart(object sender, EventArgs e)//загрузка диаграммы
        {
            try
            {
                //покдлючение к локальной базе
                using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
                {
                    //для итоговой суммы
                    double totalSumm = 0;

                    //оччитска диаграммы
                    cartesianChart.Series.Clear();
                    cartesianChart.AxisY.Clear();
                    cartesianChart.AxisX.Clear();
                    pieChart1.Series.Clear();
                    pieChart1.AxisX.Clear();
                    pieChart1.AxisY.Clear();

                    //обявление рядов на диаграмме 
                    SeriesCollection series = new SeriesCollection();
                    //даты по которым будут проводится измерения
                    List<string> dates = new List<string>();

                    //вытаскиваем данные о лицевых счетах
                    LiteCollection<Class.PersonalAccount> tablePersonaAccount = database.GetCollection<Class.PersonalAccount>(Class.PersonalAccountText);
                    IEnumerable<Class.PersonalAccount> dataPersonalAccount;
                    //если выбран лицевой счет, то загружаем информацию по ней
                    if (comboBoxAddress.SelectedIndex == -1)
                        dataPersonalAccount = tablePersonaAccount.FindAll();
                    else
                        dataPersonalAccount = tablePersonaAccount.Find(x => x.AddressID.Equals(idAddress[comboBoxAddress.SelectedIndex]));

                    //формируем список по датам 
                    for (DateTime dataStart = monthCalendar.SelectionStart; dataStart < monthCalendar.SelectionEnd; dataStart = dataStart.AddMonths(1))
                        dates.Add(dataStart.ToString("MMMM yy"));

                    //проходися по списку лицевых счетов
                    foreach (Class.PersonalAccount personalAccount in dataPersonalAccount)
                    {

                        LineSeries lineSeries = new LineSeries();
                        PieSeries pieSeries = new PieSeries();
                        ChartValues<double> chartsValue = new ChartValues<double>();

                        //загружаем операции за указанную дату
                        LiteCollection<Class.Operation> tableOperation = database.GetCollection<Class.Operation>(Class.OperationText);
                        IEnumerable<Class.Operation> dataOperation = tableOperation.Find(x => x.PersonalAccountID.Equals(personalAccount.ID) && (x.Date >= monthCalendar.SelectionStart && x.Date <= monthCalendar.SelectionEnd));
                        //сортируем по дате
                        dataOperation.OrderBy(x => x.Date);

                        //для итога по лицевому счету
                        double summPersonalAccount = 0;

                        //перебираем по месяцам
                        foreach (string month in dates)
                        {
                            //сумма за месяц
                            double summ = 0;
                            //для проверки, есть ли операции за данный месяц 
                            bool flag = true;
                            //проходимся по операциям 
                            foreach (Class.Operation operation in dataOperation)
                            {
                                //проверям есть ли операции за данный месяц
                                if (month.Equals(operation.Date.ToString("MMMM yy")))
                                {
                                    //отмечаем флаг
                                    flag = false;
                                    //проверяем способ расчета суммы
                                    if (personalAccount.PaymetMethod)
                                        //по кол-во людей
                                        summ += operation.People * operation.Tariff;
                                    else
                                        //по счетчику
                                        summ += (operation.NewIndicators - operation.OldIndicators) * operation.Tariff;
                                }
                            }
                            //если нет данных, то заполняем нулем, иначе полученной суммой 
                            if (flag)
                                chartsValue.Add(0);
                            else
                            {
                                chartsValue.Add(summ);
                                summPersonalAccount += summ;
                                totalSumm += summ;
                            }
                        }
                        //если выбран один месяц, то заполняем данные для круговой диаграммы (пирог), иначе линейнной
                        if (dates.Count == 1)
                        {
                            pieSeries.Values = chartsValue;
                            pieSeries.Title = personalAccount.NamePersonalAcc;

                            series.Add(pieSeries);
                        }
                        else
                        {
                            lineSeries.Values = chartsValue;
                            lineSeries.Title = personalAccount.NamePersonalAcc + " " + string.Format("{0:N}", summPersonalAccount) + " ₽";

                            series.Add(lineSeries);
                        }
                    }
                    //если выбран один месяц, то показываем круговую диаграмму (пирог), иначе линейнную
                    if (dates.Count == 1)
                    {
                        pieChart1.Visible = true;
                        cartesianChart.Visible = false;
                        pieChart1.LegendLocation = LegendLocation.Right;
                        pieChart1.Series = series;
                        infoSumm.Text = "Сумма за месяц: " + string.Format("{0:N}", totalSumm) + " ₽";
                    }
                    else
                    {
                        pieChart1.Visible = false;
                        cartesianChart.Visible = true;
                        cartesianChart.AxisY.Add(new Axis
                        {
                            Title = "Сумма",
                            FontSize = 12,
                            MinValue = 0,
                            Foreground = System.Windows.Media.Brushes.Black

                        });
                        cartesianChart.AxisX.Add(new Axis
                        {
                            Title = "Дата",
                            FontSize = 12,
                            Labels = dates,
                            Foreground = System.Windows.Media.Brushes.Black
                        });
                        cartesianChart.LegendLocation = LegendLocation.Right;
                        cartesianChart.Series = series;
                        infoSumm.Text = "Сумма за период: " + string.Format("{0:N}", totalSumm) + " ₽";
                    }
                }
            }
            //отлавливаем ошибки
            catch (Exception err)
            {
                Sos(err);
            }
        }
        private void MonthCalendarDateChanged(object sender, DateRangeEventArgs e)//в случае изменения даты, обновляем отчет
        {
            if (monthCalendar.SelectionStart != null && monthCalendar.SelectionEnd != null)
            {
                dateRange.Text = monthCalendar.SelectionStart.ToString("dd.MM.yyyy") + " - " + monthCalendar.SelectionEnd.ToString("dd.MM.yyyy");
                LoadingChart(sender, e);
            }
        }
        private void ClearAddressClick(object sender, EventArgs e)// для очистки выбранного адреса 
        {
            comboBoxAddress.SelectedIndex = -1;
        }
        private void ConnectionCheckToolStripMenuItemClick(object sender, EventArgs e)//проверка подключения к локальной базе
        {
            if (CheckDB())
                System.Windows.Forms.MessageBox.Show("Можете продолжать работу.", "Работает", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Sos(Exception err)//в случае обнаружения блокируем весь функционал и показываем ошибку
        {
            dataToolStripMenuItem.Enabled = false;
            payToolStripMenuItem.Enabled = false;
            comboBoxAddress.Enabled = false;
            listView.Enabled = false;
            monthCalendar.Enabled = false;
            System.Windows.MessageBox.Show(err.Message, err.Source, MessageBoxButton.OK, MessageBoxImage.Error);
        }
        private void ClearLinkGuid()//для обнаружения пустых ссылок и их обнуление (в таблицах лицевые счета и операции) 
        {
            //для хранения идентификатора лицевых счетов
            List<Guid> _idPersonalAccount = new List<Guid>();
            //подключение к локальной базе
            using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
            {
                //вытаскиваем данные таблицы лицевых счетов 
                LiteCollection<Class.PersonalAccount> tablePersonalAccount = database.GetCollection<Class.PersonalAccount>(Class.PersonalAccountText);
                IEnumerable<Class.PersonalAccount> dataPersonalAccount = tablePersonalAccount.FindAll();
                //перебираем список лицевых счетов
                foreach (var personalAccount in dataPersonalAccount)
                {
                    bool empty = true;
                    //перебираем адреса
                    foreach (Guid id in idAddress)
                        //ищем пустой адрес
                        if (personalAccount.AddressID.Equals(id))
                        {
                            empty = false;
                            break;
                        }
                    if(empty)
                    {
                        //обнуляем ссылку
                        personalAccount.AddressID = Guid.Empty;
                        tablePersonalAccount.Update(personalAccount);
                    }
                    //запоминаем все, что перебирали
                    _idPersonalAccount.Add(personalAccount.ID);
                }

                //вытаскиваем данные об операциях 
                LiteCollection<Class.Operation> tableOperation = database.GetCollection<Class.Operation>(Class.OperationText);
                IEnumerable<Class.Operation> dataOperaton = tableOperation.FindAll();
                //перебираем список операции
                foreach (Class.Operation operation in dataOperaton)
                {
                    bool empty = true;
                    //перебираем список лицевых счетов
                    foreach (Guid id in _idPersonalAccount)
                        //ищем пустую ссылку
                        if (operation.PersonalAccountID.Equals(id))
                        {
                            empty = false;
                            break;
                        }
                   if(empty)
                    {
                        //обнуляем сслыку
                        operation.PersonalAccountID = Guid.Empty;
                        tableOperation.Update(operation);
                    }

                }
            }
        }
        
        private void SettingToolStripMenuItem_Click(object sender, EventArgs e)//открытие настроек
        {
            //запоминаем размеры формы
            SaveSizeForm();
            //скрываем текущую форму
            Visible = false;
            //открываем форму настроек
            new SettingForm(this).ShowDialog();
            //восстанавливаем размеры формы
            Bounds = LoadSizeForn(Settings.Default.MainProperties, Bounds);
            //показываем текущую форму
            Visible = true;
        }
        public bool CheckDB()//проверка подключение базы
        {
            try
            {
                //проверяем и за одно обнавляем данные
                LoadingAddress();
                ClearLinkGuid();
                dataToolStripMenuItem.Enabled = true;
                payToolStripMenuItem.Enabled = true;
                comboBoxAddress.Enabled = true;
                listView.Enabled = true;
                monthCalendar.Enabled = true;
                return true;
            }
            //отлавливаем ошибки
            catch (Exception err)
            {
                Sos(err);
                return false;
            }
        }
        public Rectangle LoadSizeForn(Rectangle rectangle, Rectangle thisFrom)//для сохранения размеров формы
        {
            if (rectangle.Width > 0 && rectangle.Width < SystemParameters.FullPrimaryScreenWidth)
                thisFrom.Width = rectangle.Width;
            if (rectangle.Height > 0 && rectangle.Height < SystemParameters.FullPrimaryScreenHeight)
                thisFrom.Height = rectangle.Height;
            if (rectangle.Top > 20 && rectangle.Bottom < SystemParameters.FullPrimaryScreenHeight)
                thisFrom.Location = new System.Drawing.Point(thisFrom.X, rectangle.Y);
            if (rectangle.Left > 20 && rectangle.Right < SystemParameters.FullPrimaryScreenWidth)
                thisFrom.Location = new System.Drawing.Point(rectangle.X, thisFrom.Y);
            return thisFrom;
        }

        private void ReportToolStripMenuItem_Click(object sender, EventArgs e)//для открытия формы для отчета
        {
            //сохраняем размеры формы
            SaveSizeForm();
            //инициализируем форму для отчета
            ReportForm reportForm = new ReportForm();
            try
            {
                Visible = false;
                reportForm.ShowDialog();
                LoadingInfo(sender, e);
                Visible = true;
            }
            //отлавливаем ошибки
            catch (Exception err)
            {
                Visible = true;
                reportForm.Close();
                Sos(err);
            }
            
        }
    }
}
