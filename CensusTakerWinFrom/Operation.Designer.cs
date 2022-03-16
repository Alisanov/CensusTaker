
namespace CensusTakerWinFrom
{
    partial class Operation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operation));
            this.root = new System.Windows.Forms.CheckBox();
            this.infoPersonalAccount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureCheck = new System.Windows.Forms.PictureBox();
            this.clearAddress = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fileСheck = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxAddress = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.CheckBox();
            this.peopleOperation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxPersonalAccount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateOperation = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.oldIndicators = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.newIndicators = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.Button();
            this.tariff = new System.Windows.Forms.TextBox();
            this.summ = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.totalYear = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.dataGridOperation = new System.Windows.Forms.DataGridView();
            this.OperationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusOperation = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalAccountOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldIndicatorsOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newIndicatorsOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tariffOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peopleOperationData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOperation = new System.Windows.Forms.DataGridViewImageColumn();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.AutoSize = true;
            this.root.Location = new System.Drawing.Point(121, 19);
            this.root.Margin = new System.Windows.Forms.Padding(4);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(186, 20);
            this.root.TabIndex = 22;
            this.root.Text = "Расширенные функции";
            this.root.UseVisualStyleBackColor = true;
            this.root.CheckedChanged += new System.EventHandler(this.RootCheckedChanged);
            // 
            // infoPersonalAccount
            // 
            this.infoPersonalAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.infoPersonalAccount.AutoSize = true;
            this.infoPersonalAccount.ForeColor = System.Drawing.Color.DarkBlue;
            this.infoPersonalAccount.Location = new System.Drawing.Point(8, 20);
            this.infoPersonalAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoPersonalAccount.Name = "infoPersonalAccount";
            this.infoPersonalAccount.Size = new System.Drawing.Size(228, 16);
            this.infoPersonalAccount.TabIndex = 21;
            this.infoPersonalAccount.Text = "Информация по лицевому счету";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel);
            this.groupBox1.Controls.Add(this.clearAddress);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.infoPersonalAccount);
            this.groupBox1.Controls.Add(this.fileСheck);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBoxAddress);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Controls.Add(this.peopleOperation);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxPersonalAccount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateOperation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.oldIndicators);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.newIndicators);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.enter);
            this.groupBox1.Controls.Add(this.tariff);
            this.groupBox1.Controls.Add(this.summ);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(615, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(528, 432);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операция";
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoScroll = true;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.pictureCheck);
            this.panel.Location = new System.Drawing.Point(332, 100);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(189, 215);
            this.panel.TabIndex = 32;
            // 
            // pictureCheck
            // 
            this.pictureCheck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureCheck.Location = new System.Drawing.Point(3, 2);
            this.pictureCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureCheck.Name = "pictureCheck";
            this.pictureCheck.Size = new System.Drawing.Size(179, 209);
            this.pictureCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCheck.TabIndex = 28;
            this.pictureCheck.TabStop = false;
            this.pictureCheck.DoubleClick += new System.EventHandler(this.PictureCheckDoubleClick);
            this.pictureCheck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureCheckMouseDown);
            this.pictureCheck.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureCheckMouseMove);
            this.pictureCheck.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureCheckMouseUp);
            // 
            // clearAddress
            // 
            this.clearAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearAddress.Location = new System.Drawing.Point(284, 107);
            this.clearAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearAddress.Name = "clearAddress";
            this.clearAddress.Size = new System.Drawing.Size(28, 25);
            this.clearAddress.TabIndex = 30;
            this.clearAddress.Text = "✕";
            this.clearAddress.UseVisualStyleBackColor = true;
            this.clearAddress.Click += new System.EventHandler(this.ClearAddressClick);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorProvider.SetIconAlignment(this.button2, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.button2.Location = new System.Drawing.Point(320, 319);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 20);
            this.button2.TabIndex = 29;
            this.button2.Text = "Убрать чек";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ClearImage);
            // 
            // fileСheck
            // 
            this.fileСheck.AllowDrop = true;
            this.fileСheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileСheck.Location = new System.Drawing.Point(160, 343);
            this.fileСheck.Margin = new System.Windows.Forms.Padding(4);
            this.fileСheck.Name = "fileСheck";
            this.fileСheck.Size = new System.Drawing.Size(360, 23);
            this.fileСheck.TabIndex = 27;
            this.fileСheck.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropFile);
            this.fileСheck.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterFile);
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(8, 342);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 25);
            this.button1.TabIndex = 26;
            this.button1.Text = "Выбрать чек....";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SelectCheck);
            this.button1.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropFile);
            this.button1.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterFile);
            // 
            // comboBoxAddress
            // 
            this.comboBoxAddress.FormattingEnabled = true;
            this.comboBoxAddress.Location = new System.Drawing.Point(64, 108);
            this.comboBoxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAddress.Name = "comboBoxAddress";
            this.comboBoxAddress.Size = new System.Drawing.Size(219, 24);
            this.comboBoxAddress.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Адрес";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Checked = true;
            this.status.CheckState = System.Windows.Forms.CheckState.Checked;
            this.status.Location = new System.Drawing.Point(160, 319);
            this.status.Margin = new System.Windows.Forms.Padding(4);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(76, 20);
            this.status.TabIndex = 23;
            this.status.Text = "Статус";
            this.status.UseVisualStyleBackColor = true;
            // 
            // peopleOperation
            // 
            this.peopleOperation.Location = new System.Drawing.Point(160, 260);
            this.peopleOperation.Margin = new System.Windows.Forms.Padding(4);
            this.peopleOperation.Name = "peopleOperation";
            this.peopleOperation.Size = new System.Drawing.Size(152, 23);
            this.peopleOperation.TabIndex = 15;
            this.peopleOperation.TextChanged += new System.EventHandler(this.TextChangedSumm);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 270);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Кол-во человек:";
            // 
            // comboBoxPersonalAccount
            // 
            this.comboBoxPersonalAccount.FormattingEnabled = true;
            this.comboBoxPersonalAccount.Location = new System.Drawing.Point(160, 142);
            this.comboBoxPersonalAccount.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPersonalAccount.Name = "comboBoxPersonalAccount";
            this.comboBoxPersonalAccount.Size = new System.Drawing.Size(152, 24);
            this.comboBoxPersonalAccount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Лицевой счет";
            // 
            // dateOperation
            // 
            this.dateOperation.Location = new System.Drawing.Point(160, 171);
            this.dateOperation.Margin = new System.Windows.Forms.Padding(4);
            this.dateOperation.Name = "dateOperation";
            this.dateOperation.Size = new System.Drawing.Size(152, 23);
            this.dateOperation.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата";
            // 
            // oldIndicators
            // 
            this.oldIndicators.Enabled = false;
            this.oldIndicators.Location = new System.Drawing.Point(160, 202);
            this.oldIndicators.Margin = new System.Windows.Forms.Padding(4);
            this.oldIndicators.Name = "oldIndicators";
            this.oldIndicators.Size = new System.Drawing.Size(152, 23);
            this.oldIndicators.TabIndex = 5;
            this.oldIndicators.TextChanged += new System.EventHandler(this.TextChangedSumm);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Старые показатели";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(8, 391);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 14;
            this.button3.Text = "Очистить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ClearBox);
            // 
            // newIndicators
            // 
            this.newIndicators.Location = new System.Drawing.Point(160, 230);
            this.newIndicators.Margin = new System.Windows.Forms.Padding(4);
            this.newIndicators.Name = "newIndicators";
            this.newIndicators.Size = new System.Drawing.Size(152, 23);
            this.newIndicators.TabIndex = 7;
            this.newIndicators.TextChanged += new System.EventHandler(this.TextChangedSumm);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Новые показатели";
            // 
            // enter
            // 
            this.enter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.enter.Location = new System.Drawing.Point(416, 390);
            this.enter.Margin = new System.Windows.Forms.Padding(4);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(100, 28);
            this.enter.TabIndex = 12;
            this.enter.Text = "Провести";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.InsertOperation);
            // 
            // tariff
            // 
            this.tariff.Location = new System.Drawing.Point(160, 289);
            this.tariff.Margin = new System.Windows.Forms.Padding(4);
            this.tariff.Name = "tariff";
            this.tariff.Size = new System.Drawing.Size(152, 23);
            this.tariff.TabIndex = 9;
            this.tariff.TextChanged += new System.EventHandler(this.TextChangedSumm);
            // 
            // summ
            // 
            this.summ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.summ.AutoSize = true;
            this.summ.ForeColor = System.Drawing.Color.DarkRed;
            this.summ.Location = new System.Drawing.Point(8, 370);
            this.summ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.summ.Name = "summ";
            this.summ.Size = new System.Drawing.Size(63, 16);
            this.summ.TabIndex = 11;
            this.summ.Text = "Сумма: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 299);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Тариф";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(16, 10);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(85, 28);
            this.button11.TabIndex = 19;
            this.button11.Text = "🡸";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.CloseClick);
            // 
            // totalYear
            // 
            this.totalYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalYear.AutoSize = true;
            this.totalYear.ForeColor = System.Drawing.Color.DarkRed;
            this.totalYear.Location = new System.Drawing.Point(8, 404);
            this.totalYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalYear.Name = "totalYear";
            this.totalYear.Size = new System.Drawing.Size(89, 16);
            this.totalYear.TabIndex = 18;
            this.totalYear.Text = "Итог за год: ";
            // 
            // total
            // 
            this.total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.total.AutoSize = true;
            this.total.ForeColor = System.Drawing.Color.DarkRed;
            this.total.Location = new System.Drawing.Point(8, 425);
            this.total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(151, 16);
            this.total.TabIndex = 17;
            this.total.Text = "Итог за весь период: ";
            // 
            // edit
            // 
            this.edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edit.Location = new System.Drawing.Point(463, 14);
            this.edit.Margin = new System.Windows.Forms.Padding(4);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(140, 28);
            this.edit.TabIndex = 16;
            this.edit.Text = "Редактировать";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.EditOperation);
            // 
            // delete
            // 
            this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete.Location = new System.Drawing.Point(315, 14);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(140, 28);
            this.delete.TabIndex = 15;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.DeleteOperation);
            // 
            // dataGridOperation
            // 
            this.dataGridOperation.AllowUserToAddRows = false;
            this.dataGridOperation.AllowUserToDeleteRows = false;
            this.dataGridOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridOperation.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridOperation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOperation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OperationID,
            this.statusOperation,
            this.dataOperation,
            this.personalAccountOperation,
            this.oldIndicatorsOperation,
            this.newIndicatorsOperation,
            this.tariffOperation,
            this.peopleOperationData,
            this.summOperation,
            this.CheckOperation});
            this.dataGridOperation.Location = new System.Drawing.Point(16, 47);
            this.dataGridOperation.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridOperation.MultiSelect = false;
            this.dataGridOperation.Name = "dataGridOperation";
            this.dataGridOperation.ReadOnly = true;
            this.dataGridOperation.RowHeadersVisible = false;
            this.dataGridOperation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOperation.Size = new System.Drawing.Size(587, 346);
            this.dataGridOperation.TabIndex = 0;
            this.dataGridOperation.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridOperationCellContentDoubleClick);
            this.dataGridOperation.Click += new System.EventHandler(this.SelectGridDataOperation);
            // 
            // OperationID
            // 
            this.OperationID.HeaderText = "ID";
            this.OperationID.Name = "OperationID";
            this.OperationID.ReadOnly = true;
            this.OperationID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OperationID.Visible = false;
            // 
            // statusOperation
            // 
            this.statusOperation.HeaderText = "✔";
            this.statusOperation.Name = "statusOperation";
            this.statusOperation.ReadOnly = true;
            this.statusOperation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusOperation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusOperation.Width = 30;
            // 
            // dataOperation
            // 
            this.dataOperation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataOperation.HeaderText = "Дата";
            this.dataOperation.Name = "dataOperation";
            this.dataOperation.ReadOnly = true;
            this.dataOperation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataOperation.Width = 49;
            // 
            // personalAccountOperation
            // 
            this.personalAccountOperation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.personalAccountOperation.HeaderText = "Лицевой счет";
            this.personalAccountOperation.Name = "personalAccountOperation";
            this.personalAccountOperation.ReadOnly = true;
            this.personalAccountOperation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.personalAccountOperation.Width = 95;
            // 
            // oldIndicatorsOperation
            // 
            this.oldIndicatorsOperation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.oldIndicatorsOperation.HeaderText = "Предыдущие показания";
            this.oldIndicatorsOperation.Name = "oldIndicatorsOperation";
            this.oldIndicatorsOperation.ReadOnly = true;
            this.oldIndicatorsOperation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // newIndicatorsOperation
            // 
            this.newIndicatorsOperation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.newIndicatorsOperation.HeaderText = "Новые показания";
            this.newIndicatorsOperation.Name = "newIndicatorsOperation";
            this.newIndicatorsOperation.ReadOnly = true;
            this.newIndicatorsOperation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tariffOperation
            // 
            this.tariffOperation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tariffOperation.HeaderText = "Тариф";
            this.tariffOperation.Name = "tariffOperation";
            this.tariffOperation.ReadOnly = true;
            this.tariffOperation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tariffOperation.Width = 58;
            // 
            // peopleOperationData
            // 
            this.peopleOperationData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.peopleOperationData.HeaderText = "Количество человек";
            this.peopleOperationData.Name = "peopleOperationData";
            this.peopleOperationData.ReadOnly = true;
            this.peopleOperationData.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.peopleOperationData.Width = 131;
            // 
            // summOperation
            // 
            this.summOperation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.summOperation.HeaderText = "Сумма";
            this.summOperation.Name = "summOperation";
            this.summOperation.ReadOnly = true;
            this.summOperation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.summOperation.Width = 61;
            // 
            // CheckOperation
            // 
            this.CheckOperation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckOperation.DefaultCellStyle = dataGridViewCellStyle1;
            this.CheckOperation.HeaderText = "Чек";
            this.CheckOperation.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.CheckOperation.Name = "CheckOperation";
            this.CheckOperation.ReadOnly = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Operation
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 444);
            this.Controls.Add(this.root);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.totalYear);
            this.Controls.Add(this.total);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.dataGridOperation);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1163, 483);
            this.Name = "Operation";
            this.Text = "Операция с лицевыми счетами";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OperationFormClosing);
            this.Load += new System.EventHandler(this.Operation_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropFile);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterFile);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOperation;
        private System.Windows.Forms.ComboBox comboBoxPersonalAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateOperation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oldIndicators;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newIndicators;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tariff;
        private System.Windows.Forms.Label summ;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label totalYear;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox peopleOperation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label infoPersonalAccount;
        private System.Windows.Forms.CheckBox root;
        private System.Windows.Forms.CheckBox status;
        private System.Windows.Forms.ComboBox comboBoxAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fileСheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureCheck;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button clearAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperationID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalAccountOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldIndicatorsOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn newIndicatorsOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn tariffOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn peopleOperationData;
        private System.Windows.Forms.DataGridViewTextBoxColumn summOperation;
        private System.Windows.Forms.DataGridViewImageColumn CheckOperation;
        private System.Windows.Forms.Panel panel;
    }
}