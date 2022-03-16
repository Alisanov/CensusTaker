
namespace CensusTakerWinFrom
{
    partial class PersonalAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dataGridCompany = new System.Windows.Forms.DataGridView();
            this.CompanyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button10 = new System.Windows.Forms.Button();
            this.textCompany = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridResourse = new System.Windows.Forms.DataGridView();
            this.ResourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameResourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.textResourse = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxAddress = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numberPeople = new System.Windows.Forms.TextBox();
            this.paymetMethod = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxResourse = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.tariff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.personalAccountText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridPersonalAccount = new System.Windows.Forms.DataGridView();
            this.PersonalAccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymetMethodPersonalAccount = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PersonalAccountInt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyPersonalAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResoursePersonalAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TariffPersonalAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PepoplePersonalAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressPersonalAccountDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompany)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResourse)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonalAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(11, 7);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(85, 29);
            this.button11.TabIndex = 17;
            this.button11.Text = "🡸";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.CloseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.dataGridCompany);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.textCompany);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(676, 499);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(379, 195);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Организация";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(224, 122);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(133, 29);
            this.button8.TabIndex = 15;
            this.button8.Text = "Редактировать";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.EditCompanyClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(224, 154);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(133, 29);
            this.button9.TabIndex = 14;
            this.button9.Text = "Удалить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.DeleteCompany);
            // 
            // dataGridCompany
            // 
            this.dataGridCompany.AllowUserToAddRows = false;
            this.dataGridCompany.AllowUserToDeleteRows = false;
            this.dataGridCompany.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyID,
            this.NameCompany});
            this.dataGridCompany.Location = new System.Drawing.Point(8, 24);
            this.dataGridCompany.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridCompany.Name = "dataGridCompany";
            this.dataGridCompany.ReadOnly = true;
            this.dataGridCompany.RowHeadersVisible = false;
            this.dataGridCompany.Size = new System.Drawing.Size(208, 163);
            this.dataGridCompany.TabIndex = 13;
            this.dataGridCompany.Click += new System.EventHandler(this.DataGridCompanySelectionChanged);
            // 
            // CompanyID
            // 
            this.CompanyID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CompanyID.HeaderText = "ID";
            this.CompanyID.Name = "CompanyID";
            this.CompanyID.ReadOnly = true;
            this.CompanyID.Visible = false;
            // 
            // NameCompany
            // 
            this.NameCompany.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameCompany.HeaderText = "Организация";
            this.NameCompany.Name = "NameCompany";
            this.NameCompany.ReadOnly = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(224, 91);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(133, 29);
            this.button10.TabIndex = 10;
            this.button10.Text = "Добавить";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.InsertCompany);
            // 
            // textCompany
            // 
            this.textCompany.Location = new System.Drawing.Point(224, 59);
            this.textCompany.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textCompany.Name = "textCompany";
            this.textCompany.Size = new System.Drawing.Size(132, 23);
            this.textCompany.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Название \r\nорганизации:";
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(516, 7);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 29);
            this.button6.TabIndex = 12;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.DeletePersonalAccount);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.dataGridResourse);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.textResourse);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(675, 306);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(379, 184);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ресурс";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(224, 109);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 29);
            this.button5.TabIndex = 15;
            this.button5.Text = "Редактировать";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.EditResourseClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 141);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 29);
            this.button3.TabIndex = 14;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DeleteResourse);
            // 
            // dataGridResourse
            // 
            this.dataGridResourse.AllowUserToAddRows = false;
            this.dataGridResourse.AllowUserToDeleteRows = false;
            this.dataGridResourse.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridResourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridResourse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridResourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResourseID,
            this.NameResourse});
            this.dataGridResourse.Location = new System.Drawing.Point(8, 24);
            this.dataGridResourse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridResourse.MultiSelect = false;
            this.dataGridResourse.Name = "dataGridResourse";
            this.dataGridResourse.ReadOnly = true;
            this.dataGridResourse.RowHeadersVisible = false;
            this.dataGridResourse.Size = new System.Drawing.Size(208, 147);
            this.dataGridResourse.TabIndex = 13;
            this.dataGridResourse.Click += new System.EventHandler(this.DataGridResourseSelectionChanged);
            // 
            // ResourseID
            // 
            this.ResourseID.HeaderText = "ID";
            this.ResourseID.Name = "ResourseID";
            this.ResourseID.ReadOnly = true;
            this.ResourseID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ResourseID.Visible = false;
            this.ResourseID.Width = 24;
            // 
            // NameResourse
            // 
            this.NameResourse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameResourse.HeaderText = "Ресурс";
            this.NameResourse.Name = "NameResourse";
            this.NameResourse.ReadOnly = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(224, 79);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 29);
            this.button4.TabIndex = 10;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.InsertResourse);
            // 
            // textResourse
            // 
            this.textResourse.Location = new System.Drawing.Point(224, 47);
            this.textResourse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textResourse.Name = "textResourse";
            this.textResourse.Size = new System.Drawing.Size(133, 23);
            this.textResourse.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Название ресурса:";
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(372, 7);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(132, 29);
            this.button7.TabIndex = 13;
            this.button7.Text = "Редактировать";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.EditPersonalAccount);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboBoxAddress);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numberPeople);
            this.groupBox1.Controls.Add(this.paymetMethod);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxResourse);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxCompany);
            this.groupBox1.Controls.Add(this.tariff);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.personalAccountText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(673, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(379, 288);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление счетчика";
            // 
            // comboBoxAddress
            // 
            this.comboBoxAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddress.FormattingEnabled = true;
            this.comboBoxAddress.Location = new System.Drawing.Point(72, 27);
            this.comboBoxAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxAddress.Name = "comboBoxAddress";
            this.comboBoxAddress.Size = new System.Drawing.Size(287, 24);
            this.comboBoxAddress.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Адрес:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 221);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Кол-во чел.:";
            // 
            // numberPeople
            // 
            this.numberPeople.Location = new System.Drawing.Point(192, 217);
            this.numberPeople.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numberPeople.Name = "numberPeople";
            this.numberPeople.Size = new System.Drawing.Size(168, 23);
            this.numberPeople.TabIndex = 15;
            // 
            // paymetMethod
            // 
            this.paymetMethod.AutoSize = true;
            this.paymetMethod.Location = new System.Drawing.Point(24, 189);
            this.paymetMethod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.paymetMethod.Name = "paymetMethod";
            this.paymetMethod.Size = new System.Drawing.Size(162, 20);
            this.paymetMethod.TabIndex = 14;
            this.paymetMethod.Text = "Оплата за человека";
            this.paymetMethod.UseVisualStyleBackColor = true;
            this.paymetMethod.CheckedChanged += new System.EventHandler(this.PaymetMethodCheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 249);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ClearData);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 249);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.InsertPersonalAccount);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Тариф:";
            // 
            // comboBoxResourse
            // 
            this.comboBoxResourse.FormattingEnabled = true;
            this.comboBoxResourse.Location = new System.Drawing.Point(192, 124);
            this.comboBoxResourse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxResourse.Name = "comboBoxResourse";
            this.comboBoxResourse.Size = new System.Drawing.Size(169, 24);
            this.comboBoxResourse.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ресурс:";
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(192, 91);
            this.comboBoxCompany.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(169, 24);
            this.comboBoxCompany.TabIndex = 6;
            // 
            // tariff
            // 
            this.tariff.Location = new System.Drawing.Point(192, 157);
            this.tariff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tariff.Name = "tariff";
            this.tariff.Size = new System.Drawing.Size(169, 23);
            this.tariff.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Организация:";
            // 
            // personalAccountText
            // 
            this.personalAccountText.Location = new System.Drawing.Point(192, 59);
            this.personalAccountText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.personalAccountText.Name = "personalAccountText";
            this.personalAccountText.Size = new System.Drawing.Size(169, 23);
            this.personalAccountText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер лицевого счета:";
            // 
            // dataGridPersonalAccount
            // 
            this.dataGridPersonalAccount.AllowUserToAddRows = false;
            this.dataGridPersonalAccount.AllowUserToDeleteRows = false;
            this.dataGridPersonalAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPersonalAccount.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridPersonalAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPersonalAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPersonalAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonalAccountID,
            this.PaymetMethodPersonalAccount,
            this.PersonalAccountInt,
            this.CompanyPersonalAccount,
            this.ResoursePersonalAccount,
            this.TariffPersonalAccount,
            this.PepoplePersonalAccount,
            this.addressPersonalAccountDataGrid});
            this.dataGridPersonalAccount.Location = new System.Drawing.Point(11, 40);
            this.dataGridPersonalAccount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridPersonalAccount.MultiSelect = false;
            this.dataGridPersonalAccount.Name = "dataGridPersonalAccount";
            this.dataGridPersonalAccount.ReadOnly = true;
            this.dataGridPersonalAccount.RowHeadersVisible = false;
            this.dataGridPersonalAccount.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridPersonalAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPersonalAccount.Size = new System.Drawing.Size(641, 653);
            this.dataGridPersonalAccount.TabIndex = 0;
            this.dataGridPersonalAccount.Click += new System.EventHandler(this.DataGridPersonalAccountSelectionsChanged);
            // 
            // PersonalAccountID
            // 
            this.PersonalAccountID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PersonalAccountID.HeaderText = "ID";
            this.PersonalAccountID.Name = "PersonalAccountID";
            this.PersonalAccountID.ReadOnly = true;
            this.PersonalAccountID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PersonalAccountID.Visible = false;
            // 
            // PaymetMethodPersonalAccount
            // 
            this.PaymetMethodPersonalAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PaymetMethodPersonalAccount.HeaderText = "✔";
            this.PaymetMethodPersonalAccount.Name = "PaymetMethodPersonalAccount";
            this.PaymetMethodPersonalAccount.ReadOnly = true;
            this.PaymetMethodPersonalAccount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PaymetMethodPersonalAccount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PaymetMethodPersonalAccount.Width = 30;
            // 
            // PersonalAccountInt
            // 
            this.PersonalAccountInt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PersonalAccountInt.HeaderText = "Лицевой счет";
            this.PersonalAccountInt.Name = "PersonalAccountInt";
            this.PersonalAccountInt.ReadOnly = true;
            // 
            // CompanyPersonalAccount
            // 
            this.CompanyPersonalAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CompanyPersonalAccount.HeaderText = "Организация";
            this.CompanyPersonalAccount.Name = "CompanyPersonalAccount";
            this.CompanyPersonalAccount.ReadOnly = true;
            // 
            // ResoursePersonalAccount
            // 
            this.ResoursePersonalAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ResoursePersonalAccount.HeaderText = "Ресурс";
            this.ResoursePersonalAccount.Name = "ResoursePersonalAccount";
            this.ResoursePersonalAccount.ReadOnly = true;
            this.ResoursePersonalAccount.Width = 81;
            // 
            // TariffPersonalAccount
            // 
            this.TariffPersonalAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TariffPersonalAccount.HeaderText = "Тариф";
            this.TariffPersonalAccount.Name = "TariffPersonalAccount";
            this.TariffPersonalAccount.ReadOnly = true;
            this.TariffPersonalAccount.Width = 77;
            // 
            // PepoplePersonalAccount
            // 
            this.PepoplePersonalAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PepoplePersonalAccount.HeaderText = "Кол-во людей";
            this.PepoplePersonalAccount.Name = "PepoplePersonalAccount";
            this.PepoplePersonalAccount.ReadOnly = true;
            this.PepoplePersonalAccount.Width = 112;
            // 
            // addressPersonalAccountDataGrid
            // 
            this.addressPersonalAccountDataGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressPersonalAccountDataGrid.HeaderText = "Адрес";
            this.addressPersonalAccountDataGrid.Name = "addressPersonalAccountDataGrid";
            this.addressPersonalAccountDataGrid.ReadOnly = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // PersonalAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 701);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridPersonalAccount);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(818, 740);
            this.Name = "PersonalAccount";
            this.Text = "Работа с лицевыми счетами";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonalAccountFormClosing);
            this.Load += new System.EventHandler(this.PersonalAccount_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompany)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResourse)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonalAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPersonalAccount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxResourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.TextBox tariff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox personalAccountText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridResourse;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textResourse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dataGridCompany;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textCompany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox numberPeople;
        private System.Windows.Forms.CheckBox paymetMethod;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameResourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCompany;
        private System.Windows.Forms.ComboBox comboBoxAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonalAccountID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PaymetMethodPersonalAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonalAccountInt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyPersonalAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResoursePersonalAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TariffPersonalAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PepoplePersonalAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressPersonalAccountDataGrid;
    }
}