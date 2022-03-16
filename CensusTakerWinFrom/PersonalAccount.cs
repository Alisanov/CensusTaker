using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;
using CensusTakerWinFrom.Properties;
namespace CensusTakerWinFrom
{
    public partial class PersonalAccount : FormStyle
    {
        private List<Guid> idResourse;
        private List<Guid> idCompany;
        private List<Guid> idAddress;
        private readonly string personalAccount;
        private readonly string company;
        private readonly string resourse;
        private readonly double tariffOperation;
        public PersonalAccount()
        {
            InitializeComponent();
            personalAccount = company = resourse = string.Empty;
            tariffOperation = -1;
        }
        public PersonalAccount(string personalAccount, string company, string resourse, double tariff)
        {
            InitializeComponent();
            this.personalAccount = personalAccount;
            this.company = company;
            this.resourse = resourse;
            tariffOperation = tariff;
        }
        private void PersonalAccount_Load(object sender, EventArgs e)
        {
            Bounds = new Main().LoadSizeForn(Settings.Default.PersonalAccountProperties, Bounds);

            idResourse = new List<Guid>();
            idCompany = new List<Guid>();
            idAddress = new List<Guid>();
            using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
            {
                LiteCollection<Class.Address> tableAddress = database.GetCollection<Class.Address>(Class.AddressText);
                IEnumerable<Class.Address> addresses = tableAddress.FindAll();
                comboBoxAddress.Items.Clear();
                idAddress.Clear();
                foreach (var address in addresses)
                {
                    idAddress.Add(address.ID);
                    comboBoxAddress.Items.Add(address.City + "  ул. " + address.Street + " д. " + address.NumberHome + address.ApartmentNumber);
                }
            }
            comboBoxAddress.SelectedIndexChanged += new EventHandler(this.LoadingPersonalAccounts);
            //comboBoxAddress.Click += new EventHandler(this.LoadingPersonalAccounts);
            LoadingResourse();
            LoadingCompany();
            if (comboBoxAddress.Items.Count > 0)
                comboBoxAddress.SelectedIndex = 0;
            else
                LoadingPersonalAccounts(sender, e);
            PaymetMethodCheckedChanged(sender, e);
            if(!personalAccount.Equals(string.Empty))
            {
                textResourse.Text = resourse;
                InsertResourse(sender, e);
                comboBoxResourse.Text = resourse;
                textCompany.Text = company;
                InsertCompany(sender, e);
                comboBoxCompany.Text = company;
                personalAccountText.Text = personalAccount;
                if (tariffOperation != -1)
                    tariff.Text = tariffOperation.ToString();
            }
        }
        private void LoadingPersonalAccounts(object sender, EventArgs e)
        {
            using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
            {
                LiteCollection<Class.PersonalAccount> tablePersonalAccount = database.GetCollection<Class.PersonalAccount>(Class.PersonalAccountText);
                IEnumerable<Class.PersonalAccount> dataPersonalAccount;
                if (comboBoxAddress.SelectedIndex != -1)
                    dataPersonalAccount = tablePersonalAccount.Find(x => x.AddressID.Equals(idAddress[comboBoxAddress.SelectedIndex]) || x.AddressID == Guid.Empty);
                else
                    dataPersonalAccount = tablePersonalAccount.FindAll();
                int i = 0;
                dataGridPersonalAccount.Rows.Clear();
                foreach (var personalAccount in dataPersonalAccount)
                {
                    dataGridPersonalAccount.Rows.Add();
                    dataGridPersonalAccount.Rows[i].Cells[0].Value = personalAccount.ID;
                    dataGridPersonalAccount.Rows[i].Cells[1].Value = personalAccount.PaymetMethod;
                    dataGridPersonalAccount.Rows[i].Cells[2].Value = string.Format("{0:#,###0.#}", personalAccount.PersonalAcc);
                    dataGridPersonalAccount.Rows[i].Cells[3].Value = string.Empty;
                    if (dataGridCompany.Rows != null)
                        for (int j = 0; j < dataGridCompany.Rows.Count; j++)
                        {
                            Guid id = (Guid)dataGridCompany.Rows[j].Cells[0].Value;
                            if (id == personalAccount.CompanyID)
                            {
                                dataGridPersonalAccount.Rows[i].Cells[3].Value = dataGridCompany.Rows[j].Cells[1].Value;
                                break;
                            }
                        }
                    dataGridPersonalAccount.Rows[i].Cells[4].Value = string.Empty;
                    if (dataGridResourse.Rows != null)
                        for (int j = 0; j < dataGridResourse.Rows.Count; j++)
                        {
                            Guid id = (Guid)dataGridResourse.Rows[j].Cells[0].Value;
                            if (id == personalAccount.ResourceID)
                            {
                                dataGridPersonalAccount.Rows[i].Cells[4].Value = dataGridResourse.Rows[j].Cells[1].Value;
                                break;
                            }
                        }
                    dataGridPersonalAccount.Rows[i].Cells[5].Value = personalAccount.Tariff;
                    dataGridPersonalAccount.Rows[i].Cells[6].Value = personalAccount.People;

                    LiteCollection<Class.Address> tableAddress = database.GetCollection<Class.Address>(Class.AddressText);
                    Class.Address address = tableAddress.FindById(personalAccount.AddressID);
                    if (address != null)
                    {
                        dataGridPersonalAccount.Rows[i].Cells[7].Value = address.City + "  ул. " + address.Street + " д. " + address.NumberHome + address.ApartmentNumber;
                        if (personalAccount.PaymetMethod)
                            dataGridPersonalAccount.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                        else
                            dataGridPersonalAccount.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                    }
                    else
                        dataGridPersonalAccount.Rows[i].Cells[7].Value = string.Empty;
                    i++;
                }
            }
            DataGridPersonalAccountSelectionsChanged(sender, e);
        }
        private bool CheckInput(ref double tar, ref int people)
        {
            errorProvider.Clear();
            //if (string.IsNullOrWhiteSpace(comboBoxAddress.Text))
            //{
            //    errorProvider.SetError(comboBoxAddress, "Пустое поле!");
            //    return false;
            //}
            //else if (comboBoxAddress.SelectedIndex == -1)
            //{
            //    errorProvider.SetError(comboBoxAddress, "Выберите из списка адрес!");
            //    return false;
            //}
             if (string.IsNullOrWhiteSpace(personalAccountText.Text))
            {
                errorProvider.SetError(personalAccountText, "Пустое поле!");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(comboBoxCompany.Text))
            {
                errorProvider.SetError(comboBoxCompany, "Пустое поле!");
                return false;
            }
            else if (comboBoxCompany.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBoxCompany, "Выберите из списка организацию!");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(comboBoxResourse.Text))
            {
                errorProvider.SetError(comboBoxResourse, "Пустое поле!");
                return false;
            }
            else if (comboBoxResourse.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBoxResourse, "Выберите из списка ресурс!");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(tariff.Text))
            {
                errorProvider.SetError(tariff, "Пустое поле!");
                return false;
            }
            else if (!double.TryParse(tariff.Text.Replace(" ", ""), out tar))
            {
                errorProvider.SetError(tariff, "Введите числовое значение!");
                return false;
            }
            else if (paymetMethod.Checked)
            {
                if (string.IsNullOrWhiteSpace(numberPeople.Text))
                {
                    errorProvider.SetError(numberPeople, "Пустое поле!");
                    return false;
                }
                else if (!int.TryParse(numberPeople.Text.Trim(), out people))
                {
                    errorProvider.SetError(numberPeople, "Введите числовое значение!");
                    return false;
                }
                else
                    return true;
            }
            else
                return true;

        }
        private void InsertPersonalAccount(object sender, EventArgs e)
        {
            double tar = 0;
            int people = 0;
            if (CheckInput(ref tar, ref people))
            {
                using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
                {
                    LiteCollection<Class.PersonalAccount> tablePersonalAccount = database.GetCollection<Class.PersonalAccount>(Class.PersonalAccountText);
                    Class.PersonalAccount personalAccount = new Class.PersonalAccount
                    {
                        PersonalAcc = personalAccountText.Text,
                        CompanyID = idCompany[comboBoxCompany.SelectedIndex],
                        ResourceID = idResourse[comboBoxResourse.SelectedIndex],
                        Tariff = tar,
                        PaymetMethod = paymetMethod.Checked,
                        People = people,
                        Date = DateTime.Now
                    };
                    if (idAddress.Count > 0)
                        personalAccount.AddressID = idAddress[comboBoxAddress.SelectedIndex];
                    else
                        personalAccount.AddressID = Guid.Empty;
                    tablePersonalAccount.Insert(personalAccount);
                    ClearData(sender, e);
                    errorProvider.Clear();
                }
                LoadingPersonalAccounts(sender, e);
            }
        }
        private void ClearData(object sender, EventArgs e)
        {
            personalAccountText.Text = string.Empty;
            comboBoxCompany.Text = string.Empty;
            comboBoxResourse.Text = string.Empty;
            tariff.Text = string.Empty;
            paymetMethod.Checked = false;
            numberPeople.Text = string.Empty;
        }
        private void DeletePersonalAccount(object sender, EventArgs e)
        {
            if (dataGridPersonalAccount.CurrentRow != null)
            {
                if (DialogResult.OK == System.Windows.Forms.MessageBox.Show("Удалить лицевой счет?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                {
                    Guid id = (Guid)dataGridPersonalAccount.Rows[dataGridPersonalAccount.CurrentRow.Index].Cells[0].Value;
                    using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
                    {

                        LiteCollection<Class.PersonalAccount> tablePersonalAccount = database.GetCollection<Class.PersonalAccount>(Class.PersonalAccountText);
                        Class.PersonalAccount personalAccount = tablePersonalAccount.FindById(id);

                        LiteCollection<Class.Operation> tableOperation = database.GetCollection<Class.Operation>(Class.OperationText);
                        IEnumerable<Class.Operation> dataOperation = tableOperation.Find(x => x.PersonalAccountID.Equals(id));

                        if (dataOperation.Count() > 0)
                        {
                                tableOperation.EnsureIndex(x => x.PersonalAccountID);
                                tableOperation.Delete(x => x.PersonalAccountID.Equals(id));
                        }
                        tablePersonalAccount.EnsureIndex(x => x.ID);
                        tablePersonalAccount.Delete(x => x.ID.Equals(id));
                    }
                    
                    LoadingPersonalAccounts(sender, e);
                    errorProvider.Clear();
                }
            }
            else
                errorProvider.SetError(dataGridPersonalAccount, "Выберите строку на удаление!");
        }
        private void EditPersonalAccount(object sender, EventArgs e)
        {
            if (dataGridPersonalAccount.CurrentRow != null)
            {
                double tar = 0;
                int people = 0;
                if (CheckInput(ref tar, ref people))
                {
                    using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
                    {
                        LiteCollection<Class.PersonalAccount> tablePersonalAccount = database.GetCollection<Class.PersonalAccount>(Class.PersonalAccountText);
                        Class.PersonalAccount personalAccount = tablePersonalAccount.FindById((Guid)dataGridPersonalAccount.Rows[dataGridPersonalAccount.CurrentRow.Index].Cells[0].Value);
                        personalAccount.PersonalAcc = personalAccountText.Text;
                        personalAccount.CompanyID = idCompany[comboBoxCompany.SelectedIndex];
                        personalAccount.ResourceID = idResourse[comboBoxResourse.SelectedIndex];
                        personalAccount.Tariff = tar;
                        personalAccount.PaymetMethod = paymetMethod.Checked;
                        personalAccount.People = people;
                        personalAccount.Date = DateTime.Now;
                        if (comboBoxAddress.SelectedIndex != -1)
                            personalAccount.AddressID = idAddress[comboBoxAddress.SelectedIndex];
                        else
                            personalAccount.AddressID = Guid.Empty;
                        tablePersonalAccount.Update(personalAccount);
                        ClearData(sender, e);
                    }
                    errorProvider.Clear();
                    int index = 0;
                    if (dataGridPersonalAccount.CurrentRow != null)
                        index = dataGridPersonalAccount.CurrentRow.Index;
                    LoadingPersonalAccounts(sender, e);
                    dataGridPersonalAccount.CurrentCell = dataGridPersonalAccount.Rows[index].Cells[1];
                    DataGridPersonalAccountSelectionsChanged(sender, e);
                }
            }
            else
                errorProvider.SetError(dataGridPersonalAccount, "Выберите из списка лицевой счет !");
        }
        private void DataGridPersonalAccountSelectionsChanged(object sender, EventArgs e)
        {
            if (dataGridPersonalAccount.CurrentRow != null && dataGridPersonalAccount.Rows[dataGridPersonalAccount.CurrentRow.Index].Cells[0].Value != null)
            {
                comboBoxAddress.Text = dataGridPersonalAccount.Rows[dataGridPersonalAccount.CurrentRow.Index].Cells[7].Value.ToString();
                personalAccountText.Text = dataGridPersonalAccount.Rows[dataGridPersonalAccount.CurrentRow.Index].Cells[2].Value.ToString().Replace(" ", "");
                comboBoxCompany.Text = dataGridPersonalAccount.Rows[dataGridPersonalAccount.CurrentRow.Index].Cells[3].Value.ToString();
                comboBoxResourse.Text = dataGridPersonalAccount.Rows[dataGridPersonalAccount.CurrentRow.Index].Cells[4].Value.ToString();
                tariff.Text = dataGridPersonalAccount.Rows[dataGridPersonalAccount.CurrentRow.Index].Cells[5].Value.ToString();
                paymetMethod.Checked = (bool)dataGridPersonalAccount.Rows[dataGridPersonalAccount.CurrentRow.Index].Cells[1].Value;
                numberPeople.Text = dataGridPersonalAccount.Rows[dataGridPersonalAccount.CurrentRow.Index].Cells[6].Value.ToString();
                PaymetMethodCheckedChanged(sender, e);
            }
        }
        private void LoadingResourse()
        {
            using (LiteDatabase database = new LiteDatabase(Properties.Settings.Default.Database))
            {
                LiteCollection<Class.Resource> tableResourse = database.GetCollection<Class.Resource>(Class.ResourseText); ;
                IEnumerable<Class.Resource> dataResourse = tableResourse.FindAll();

                int i = 0;
                dataGridResourse.Rows.Clear();
                comboBoxResourse.Items.Clear();
                idResourse.Clear();
                foreach (var resourse in dataResourse)
                {
                    dataGridResourse.Rows.Add();
                    dataGridResourse.Rows[i].Cells[0].Value = resourse.ID;
                    idResourse.Add(resourse.ID);
                    dataGridResourse.Rows[i].Cells[1].Value = resourse.Name;
                    comboBoxResourse.Items.Add(resourse.Name);
                    i++;
                }
            }
            if (comboBoxResourse.Items.Count > 0)
                comboBoxResourse.SelectedIndex = 0;
        }
        private void LoadingCompany()
        {
            using (LiteDatabase database = new LiteDatabase(Properties.Settings.Default.Database))
            {
                LiteCollection<Class.Company> tableCompany = database.GetCollection<Class.Company>(Class.CompanyText); ;
                IEnumerable<Class.Company> dataCompany = tableCompany.FindAll();

                int i = 0;
                dataGridCompany.Rows.Clear();
                comboBoxCompany.Items.Clear();
                idCompany.Clear();
                foreach (var company in dataCompany)
                {
                    dataGridCompany.Rows.Add();
                    dataGridCompany.Rows[i].Cells[0].Value = company.ID;
                    idCompany.Add(company.ID);
                    dataGridCompany.Rows[i].Cells[1].Value = company.Name;
                    comboBoxCompany.Items.Add(company.Name);
                    i++;
                }
            }
            if (comboBoxCompany.Items.Count > 0)
                comboBoxCompany.SelectedIndex = 0;
        }
        private void InsertResourse(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(textResourse.Text))
            {
                using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
                {
                    errorProvider.Clear();
                    LiteCollection<Class.Resource> tableResourse = database.GetCollection<Class.Resource>(Class.ResourseText);
                    Class.Resource resource = tableResourse.FindOne(x => x.Name.ToUpper().Equals(textResourse.Text));
                    if (resource == null)
                    {
                        Class.Resource insertResource = new Class.Resource { Name = textResourse.Text };
                        tableResourse.Insert(insertResource);
                    }
                    else
                        errorProvider.SetError(textResourse, "Такой ресурс сущеcтвует!");
                    textResourse.Text = string.Empty;
                    
                }
                LoadingResourse();
            }
            else
                errorProvider.SetError(textResourse, "Ошибка ввода! Введите корректные данные");
        }
        private void InsertCompany(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textCompany.Text))
            {
                using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
                {
                    errorProvider.Clear();
                    LiteCollection<Class.Company> tableCompany = database.GetCollection<Class.Company>(Class.CompanyText);
                    Class.Company company = tableCompany.FindOne(x => x.Name.ToUpper().Equals(textCompany.Text));
                    if (company == null)
                    {
                        Class.Company insertCompany = new Class.Company { Name = textCompany.Text };
                        tableCompany.Insert(insertCompany);
                    }
                    else
                        errorProvider.SetError(textCompany, "Такая компания существует!");
                    textCompany.Text = string.Empty;
                }
                LoadingCompany();
            }
            else
                errorProvider.SetError(textCompany, "Ошибка ввода! Введите корректные данные. ");
        }
        private void DeleteResourse(object sender, EventArgs e)
        {
            if(dataGridResourse.CurrentRow != null)
            {
                using (LiteDatabase database = new LiteDatabase(Properties.Settings.Default.Database))
                {
                    LiteCollection<Class.Resource> tableResourse = database.GetCollection<Class.Resource>(Class.ResourseText);
                    Class.Resource resource = tableResourse.FindById(idResourse[dataGridResourse.CurrentRow.Index]); 

                    LiteCollection<Class.PersonalAccount> tablePersonalAccount = database.GetCollection<Class.PersonalAccount>(Class.PersonalAccountText);
                    IEnumerable<Class.PersonalAccount> personalAccounts = tablePersonalAccount.FindAll();
                    
                    foreach(Class.PersonalAccount personalAccount in personalAccounts)
                    {
                        if (personalAccount.ResourceID == resource.ID)
                        {
                            personalAccount.ResourceID = Guid.Empty;
                            tablePersonalAccount.Update(personalAccount);
                            break;
                        }
                    }
                    tableResourse.EnsureIndex(x => x.ID);
                    tableResourse.Delete(x => x.ID.Equals(idResourse[dataGridResourse.CurrentRow.Index]));
                }
                LoadingResourse();
                LoadingPersonalAccounts(sender, e);
                errorProvider.Clear();
            }
            else
                errorProvider.SetError(dataGridResourse, "Выберите строку на удаление!");
        }
        private void DeleteCompany(object sender, EventArgs e)
        {
            if (dataGridCompany.CurrentRow != null)
            {
                using (LiteDatabase database = new LiteDatabase(Properties.Settings.Default.Database))
                {
                    LiteCollection<Class.Company> tableCompany = database.GetCollection<Class.Company>(Class.CompanyText);
                    Class.Company company = tableCompany.FindById(idCompany[dataGridCompany.CurrentRow.Index]);

                    LiteCollection<Class.PersonalAccount> tablePersonalAccount = database.GetCollection<Class.PersonalAccount>(Class.PersonalAccountText);
                    IEnumerable<Class.PersonalAccount> personalAccounts = tablePersonalAccount.FindAll();

                    foreach (Class.PersonalAccount personalAccount in personalAccounts)
                    {
                        if(personalAccount.CompanyID == company.ID)
                        {
                            personalAccount.CompanyID = Guid.Empty;
                            tablePersonalAccount.Update(personalAccount);
                            break;
                        }
                    }
                    tableCompany.EnsureIndex(x => x.ID);
                    tableCompany.Delete(x => x.ID.Equals(idCompany[dataGridCompany.CurrentRow.Index]));
                }
                LoadingCompany();
                LoadingPersonalAccounts(sender, e);
                errorProvider.Clear();
            }
            else
                errorProvider.SetError(dataGridCompany, "Выберите строку на удаление!");
        }
        private void DataGridResourseSelection()
        {
            if (dataGridResourse.CurrentRow != null && dataGridResourse.Rows[dataGridResourse.CurrentRow.Index].Cells[1].Value != null)
            {
                string currentText = dataGridResourse.Rows[dataGridResourse.CurrentRow.Index].Cells[1].Value.ToString();
                comboBoxResourse.Text = currentText;
                textResourse.Text = currentText;
            }
        }
        private void DataGridResourseSelectionChanged(object sender, EventArgs e)
        {
            DataGridResourseSelection();
        }
        private void DataGridCompanySelection()
        {
            if (dataGridCompany.CurrentRow != null && dataGridCompany.Rows[dataGridCompany.CurrentRow.Index].Cells[1].Value != null)
            {
                string currentText = dataGridCompany.Rows[dataGridCompany.CurrentRow.Index].Cells[1].Value.ToString();
                comboBoxCompany.Text = currentText;
                textCompany.Text = currentText;
            }
        }
        private void DataGridCompanySelectionChanged(object sender, EventArgs e)
        {
            DataGridCompanySelection();
        }
        private void EditResourseClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textResourse.Text))
            {
                if (dataGridResourse.CurrentRow != null)
                {
                    using (LiteDatabase database = new LiteDatabase(Properties.Settings.Default.Database))
                    {
                        LiteCollection<Class.Resource> tableResourse = database.GetCollection<Class.Resource>(Class.ResourseText);
                        Class.Resource resource = tableResourse.FindById(idResourse[dataGridResourse.CurrentRow.Index]);
                        resource.Name = textResourse.Text;
                        tableResourse.Update(resource);
                        textResourse.Text = string.Empty;
                        errorProvider.Clear();
                    }
                    LoadingResourse();
                    LoadingPersonalAccounts(sender, e);
                }
                else
                    errorProvider.SetError(dataGridResourse, "Выберите строку на редактирование!");
            }
            else
                errorProvider.SetError(textResourse, "Ошибка ввода! Введите корректные данные");
        }
        private void EditCompanyClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textCompany.Text))
            {
                if (dataGridCompany.CurrentRow != null)
                {
                    using (LiteDatabase database = new LiteDatabase(Properties.Settings.Default.Database))
                    {
                        LiteCollection<Class.Company> tableCompany = database.GetCollection<Class.Company>(Class.CompanyText);
                        Class.Company company = tableCompany.FindById(idCompany[dataGridCompany.CurrentRow.Index]);
                        company.Name = textCompany.Text;
                        tableCompany.Update(company);
                        textCompany.Text = string.Empty;
                        errorProvider.Clear();
                    }
                    LoadingCompany();
                    LoadingPersonalAccounts(sender, e);
                }
                else
                    errorProvider.SetError(dataGridCompany, "Выберите строку на редактирование!");
            }
            else
                errorProvider.SetError(textCompany, "Ошибка ввода! Введите корректные данные. ");
        }
        private void PaymetMethodCheckedChanged(object sender, EventArgs e)
        {
            if (paymetMethod.Checked)
                numberPeople.Enabled = true;
            else 
                numberPeople.Enabled = false;
        }
        private void CloseClick(object sender, EventArgs e)
        {
            Close();
        }
        private void PersonalAccountFormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.PersonalAccountProperties = Bounds;
            Settings.Default.Save();
        }
        private void СlearAddressClick(object sender, EventArgs e)
        {
            comboBoxAddress.SelectedIndex = -1;
        }
    }
}
