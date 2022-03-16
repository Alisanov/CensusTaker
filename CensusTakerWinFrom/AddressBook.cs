using CensusTakerWinFrom.Properties;
using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace CensusTakerWinFrom
{
    public partial class AddressBook : FormStyle
    {
        public AddressBook()
        {
            InitializeComponent();
        }
        private void LoadingAddress()
        {
            using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
            {
                LiteCollection<Class.Address> tableAddress = database.GetCollection<Class.Address>(Class.AddressText);
                IEnumerable<Class.Address> dataAddress = tableAddress.FindAll();

                int i = 0;

                comboBoxRegion.Items.Clear();
                comboBoxArea.Items.Clear();
                comboBoxCity.Items.Clear();
                comboBoxStreet.Items.Clear();

                dataGridAddress.Rows.Clear();
                foreach (var address in dataAddress)
                {
                    dataGridAddress.Rows.Add();
                    dataGridAddress.Rows[i].Cells[0].Value = address.ID;
                    dataGridAddress.Rows[i].Cells[1].Value = address.Region;
                    comboBoxRegion.Items.Add(address.Region);
                    dataGridAddress.Rows[i].Cells[2].Value = address.Area;
                    comboBoxArea.Items.Add(address.Area);
                    dataGridAddress.Rows[i].Cells[3].Value = address.City;
                    comboBoxCity.Items.Add(address.City);
                    dataGridAddress.Rows[i].Cells[4].Value = address.Street;
                    comboBoxStreet.Items.Add(address.Street);
                    dataGridAddress.Rows[i].Cells[5].Value = address.NumberHome;
                    dataGridAddress.Rows[i].Cells[6].Value = address.ApartmentNumber;
                    i++;
                }
                ClearRepetitionsComboBox(comboBoxRegion);
                ClearRepetitionsComboBox(comboBoxArea);
                ClearRepetitionsComboBox(comboBoxCity);
                ClearRepetitionsComboBox(comboBoxStreet);
            }
        }
        private void ClearRepetitionsComboBox(ComboBox comboBox)
        {
            for (int j = 0; j < comboBox.Items.Count; j++)
            {
                for (int k = j + 1; k < comboBox.Items.Count; k++)
                    if (comboBox.Items[j].ToString().Equals(comboBox.Items[k].ToString()))
                        comboBox.Items.RemoveAt(j);
            }
        }
        private void AddressBookLoad(object sender, EventArgs e)
        {
            //назначаем размеры окна
            Bounds = new Main().LoadSizeForn(Settings.Default.AddressBookProperties, Bounds);

            LoadingAddress();
            comboBoxRegion.Sorted = true;
            comboBoxArea.Sorted = true;
            comboBoxCity.Sorted = true;
            comboBoxStreet.Sorted = true;
            SelectionDataGrid(sender, e);
        }
        private bool CheckInput()
        {
            errorProvider.Clear();
            if (string.IsNullOrWhiteSpace(comboBoxRegion.Text))
            {
                errorProvider.SetError(comboBoxRegion, "Пустое поле!");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(comboBoxArea.Text))
            {
                errorProvider.SetError(comboBoxArea, "Пустое поле!");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(comboBoxCity.Text))
            {
                errorProvider.SetError(comboBoxCity, "Пустое поле!");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(comboBoxStreet.Text))
            {
                errorProvider.SetError(comboBoxStreet, "Пустое поле!");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(numberHome.Text))
            {
                errorProvider.SetError(numberHome, "Пустое поле!");
                return false;
            }
            else
                return true;

        }
        private void InsertAddress(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
                {
                    LiteCollection<Class.Address> tableAddress = database.GetCollection<Class.Address>(Class.AddressText);
                    Class.Address address = new Class.Address
                    {
                        Region = comboBoxRegion.Text,
                        Area = comboBoxArea.Text,
                        City = comboBoxCity.Text,
                        Street = comboBoxStreet.Text,
                        NumberHome = numberHome.Text,
                        ApartmentNumber = numberApatament.Text
                    };
                    tableAddress.Insert(address);
                }
                ClearData(sender, e);
                LoadingAddress();
                errorProvider.Clear();
            }
        }
        private void EditAddress(object sender, EventArgs e)
        {
            if (dataGridAddress.CurrentRow != null)
            {
                if (CheckInput())
                {
                    using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
                    {
                        LiteCollection<Class.Address> tableAddress = database.GetCollection<Class.Address>(Class.AddressText);
                        Class.Address address = tableAddress.FindById((Guid)dataGridAddress.Rows[dataGridAddress.CurrentRow.Index].Cells[0].Value);

                        address.Region = comboBoxRegion.Text;
                        address.Area = comboBoxArea.Text;
                        address.City = comboBoxCity.Text;
                        address.Street = comboBoxStreet.Text;
                        address.NumberHome = numberHome.Text;
                        address.ApartmentNumber = numberApatament.Text;

                        tableAddress.Update(address);
                    }
                    ClearData(sender, e);
                    errorProvider.Clear();
                    int index = 0;
                    if (dataGridAddress.CurrentRow != null)
                        index = dataGridAddress.CurrentRow.Index;
                    LoadingAddress();
                    dataGridAddress.CurrentCell = dataGridAddress.Rows[index].Cells[1];
                    SelectionDataGrid(sender, e);
                }
            }
            else
                errorProvider.SetError(dataGridAddress, "Выберите адрес для редактирования!");
        }
        private void ClearData(object sender, EventArgs e)
        {
            comboBoxRegion.Text = string.Empty;
            comboBoxArea.Text = string.Empty;
            comboBoxCity.Text = string.Empty;
            comboBoxStreet.Text = string.Empty;
            numberHome.Text = string.Empty;
            numberApatament.Text = string.Empty;
        }
        private void SelectionDataGrid(object sender, EventArgs e)
        {
            if (dataGridAddress.CurrentRow != null)
                if (dataGridAddress.Rows[dataGridAddress.CurrentRow.Index].Cells[0].Value != null)
                {
                    comboBoxRegion.Text = dataGridAddress.Rows[dataGridAddress.CurrentRow.Index].Cells[1].Value.ToString();
                    comboBoxArea.Text = dataGridAddress.Rows[dataGridAddress.CurrentRow.Index].Cells[2].Value.ToString();
                    comboBoxCity.Text = dataGridAddress.Rows[dataGridAddress.CurrentRow.Index].Cells[3].Value.ToString();
                    comboBoxStreet.Text = dataGridAddress.Rows[dataGridAddress.CurrentRow.Index].Cells[4].Value.ToString();
                    numberHome.Text = dataGridAddress.Rows[dataGridAddress.CurrentRow.Index].Cells[5].Value.ToString();
                    if (dataGridAddress.Rows[dataGridAddress.CurrentRow.Index].Cells[6].Value == null)
                        numberApatament.Text = string.Empty;
                    else
                        numberApatament.Text = dataGridAddress.Rows[dataGridAddress.CurrentRow.Index].Cells[6].Value.ToString();
                }
        }
        private void DeleteAddress(object sender, EventArgs e)
        {
            if (dataGridAddress.CurrentRow != null)
            {
                Guid id = (Guid)dataGridAddress.Rows[dataGridAddress.CurrentRow.Index].Cells[0].Value;
                using (LiteDatabase database = new LiteDatabase(Properties.Settings.Default.Database))
                {
                    LiteCollection<Class.Address> tableAddress = database.GetCollection<Class.Address>(Class.AddressText);
                    Class.Address address = tableAddress.FindById(id);
                    if (address != null)
                    {
                        if (DialogResult.OK == System.Windows.Forms.MessageBox.Show("Удалить адрес?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                        {
                            LiteCollection<Class.PersonalAccount> tablePersonaAccount = database.GetCollection<Class.PersonalAccount>(Class.PersonalAccountText);
                            IEnumerable<Class.PersonalAccount> dataPersonalAccount = tablePersonaAccount.Find(x => x.AddressID.Equals(id));
                            if (dataPersonalAccount.Count() > 0)
                            {
                                if (DialogResult.OK == System.Windows.Forms.MessageBox.Show("У данного адреса есть лицевые счета.\n Вы уверены что хотите продолжить?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                                {
                                    if (DialogResult.OK == System.Windows.Forms.MessageBox.Show("Удалить лицевые счета?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                                    {

                                        foreach (Class.PersonalAccount personalAccount in dataPersonalAccount)
                                        {
                                            LiteCollection<Class.Operation> tableOperation = database.GetCollection<Class.Operation>(Class.OperationText);
                                            tableOperation.EnsureIndex(x => x.PersonalAccountID);
                                            tableOperation.Delete(x => x.PersonalAccountID.Equals(personalAccount.ID));
                                        }
                                        tablePersonaAccount.EnsureIndex(x => x.AddressID);
                                        tablePersonaAccount.Delete(x => x.AddressID.Equals(id));
                                    }
                                    else
                                    {
                                        foreach (Class.PersonalAccount personalAccount in dataPersonalAccount)
                                        {
                                            personalAccount.AddressID = Guid.Empty;
                                            tablePersonaAccount.Update(personalAccount);
                                        }
                                    }
                                    tableAddress.EnsureIndex(x => x.ID);
                                    tableAddress.Delete(x => x.ID.Equals(id));
                                    ClearData(sender, e);
                                }
                            }
                            else
                            {
                                tableAddress.EnsureIndex(x => x.ID);
                                tableAddress.Delete(x => x.ID.Equals(id));
                                ClearData(sender, e);
                            }
                        }
                    }
                    else
                        System.Windows.Forms.MessageBox.Show("Такого адреса не существует, возможно его уже удалили", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                errorProvider.Clear();
                LoadingAddress();
            }
            else
                errorProvider.SetError(dataGridAddress, "Выберите адрес для удаления!");
        }
        private void CloseClick(object sender, EventArgs e)
        {
            Close();
        }
        private void AddressBookFormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.AddressBookProperties = this.Bounds;
            Settings.Default.Save();
        }
    }

}
