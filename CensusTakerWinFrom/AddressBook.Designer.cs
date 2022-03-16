
namespace CensusTakerWinFrom
{
    partial class AddressBook
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numberApatament = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxStreet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxArea = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numberHome = new System.Windows.Forms.TextBox();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridAddress = new System.Windows.Forms.DataGridView();
            this.addressID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberHomeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartametNumberAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button11 = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numberApatament);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxStreet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxCity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxArea);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numberHome);
            this.groupBox1.Controls.Add(this.comboBoxRegion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(242, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(244, 185);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Работа с адресами";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Location = new System.Drawing.Point(6, 157);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 22);
            this.button4.TabIndex = 7;
            this.button4.Text = "Очистить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ClearData);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(142, 157);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 22);
            this.button3.TabIndex = 6;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.InsertAddress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Номер квартиры";
            // 
            // numberApatament
            // 
            this.numberApatament.Location = new System.Drawing.Point(126, 131);
            this.numberApatament.Margin = new System.Windows.Forms.Padding(2);
            this.numberApatament.Name = "numberApatament";
            this.numberApatament.Size = new System.Drawing.Size(103, 20);
            this.numberApatament.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Номер дома";
            // 
            // comboBoxStreet
            // 
            this.comboBoxStreet.FormattingEnabled = true;
            this.comboBoxStreet.Location = new System.Drawing.Point(126, 88);
            this.comboBoxStreet.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxStreet.Name = "comboBoxStreet";
            this.comboBoxStreet.Size = new System.Drawing.Size(103, 21);
            this.comboBoxStreet.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Улица";
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(126, 66);
            this.comboBoxCity.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(103, 21);
            this.comboBoxCity.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Населенный пункт";
            // 
            // comboBoxArea
            // 
            this.comboBoxArea.FormattingEnabled = true;
            this.comboBoxArea.Location = new System.Drawing.Point(126, 44);
            this.comboBoxArea.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxArea.Name = "comboBoxArea";
            this.comboBoxArea.Size = new System.Drawing.Size(103, 21);
            this.comboBoxArea.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Район";
            // 
            // numberHome
            // 
            this.numberHome.Location = new System.Drawing.Point(126, 110);
            this.numberHome.Margin = new System.Windows.Forms.Padding(2);
            this.numberHome.Name = "numberHome";
            this.numberHome.Size = new System.Drawing.Size(103, 20);
            this.numberHome.TabIndex = 4;
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Location = new System.Drawing.Point(126, 22);
            this.comboBoxRegion.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(103, 21);
            this.comboBoxRegion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Область";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 5);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 22);
            this.button2.TabIndex = 8;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.EditAddress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 22);
            this.button1.TabIndex = 9;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DeleteAddress);
            // 
            // dataGridAddress
            // 
            this.dataGridAddress.AllowUserToAddRows = false;
            this.dataGridAddress.AllowUserToDeleteRows = false;
            this.dataGridAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridAddress.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAddress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addressID,
            this.regionAddress,
            this.areaAddress,
            this.cityAddress,
            this.streeAddress,
            this.numberHomeAddress,
            this.apartametNumberAddress});
            this.dataGridAddress.Location = new System.Drawing.Point(6, 33);
            this.dataGridAddress.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridAddress.MultiSelect = false;
            this.dataGridAddress.Name = "dataGridAddress";
            this.dataGridAddress.ReadOnly = true;
            this.dataGridAddress.RowHeadersVisible = false;
            this.dataGridAddress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAddress.Size = new System.Drawing.Size(228, 157);
            this.dataGridAddress.TabIndex = 19;
            this.dataGridAddress.Click += new System.EventHandler(this.SelectionDataGrid);
            // 
            // addressID
            // 
            this.addressID.HeaderText = "ID";
            this.addressID.Name = "addressID";
            this.addressID.ReadOnly = true;
            this.addressID.Visible = false;
            // 
            // regionAddress
            // 
            this.regionAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.regionAddress.HeaderText = "Область";
            this.regionAddress.Name = "regionAddress";
            this.regionAddress.ReadOnly = true;
            // 
            // areaAddress
            // 
            this.areaAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.areaAddress.HeaderText = "Район";
            this.areaAddress.Name = "areaAddress";
            this.areaAddress.ReadOnly = true;
            // 
            // cityAddress
            // 
            this.cityAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cityAddress.HeaderText = "Населенный пункт";
            this.cityAddress.Name = "cityAddress";
            this.cityAddress.ReadOnly = true;
            // 
            // streeAddress
            // 
            this.streeAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.streeAddress.HeaderText = "Улица";
            this.streeAddress.Name = "streeAddress";
            this.streeAddress.ReadOnly = true;
            // 
            // numberHomeAddress
            // 
            this.numberHomeAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.numberHomeAddress.HeaderText = "№ дома";
            this.numberHomeAddress.Name = "numberHomeAddress";
            this.numberHomeAddress.ReadOnly = true;
            this.numberHomeAddress.Width = 67;
            // 
            // apartametNumberAddress
            // 
            this.apartametNumberAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.apartametNumberAddress.HeaderText = "№ квартиры";
            this.apartametNumberAddress.Name = "apartametNumberAddress";
            this.apartametNumberAddress.ReadOnly = true;
            this.apartametNumberAddress.Width = 87;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(6, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(64, 23);
            this.button11.TabIndex = 10;
            this.button11.Text = "🡸";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.CloseClick);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddressBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 197);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridAddress);
            this.Controls.Add(this.button11);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(509, 236);
            this.Name = "AddressBook";
            this.Text = "Адресная книга";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddressBookFormClosing);
            this.Load += new System.EventHandler(this.AddressBookLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataGridView dataGridAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressID;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn streeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberHomeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartametNumberAddress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox numberApatament;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxStreet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberHome;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}