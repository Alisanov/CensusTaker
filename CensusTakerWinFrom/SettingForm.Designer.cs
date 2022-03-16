
namespace CensusTakerWinFrom
{
    partial class SettingForm
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
            this.button11 = new System.Windows.Forms.Button();
            this.fileDB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectDB = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.keyText = new System.Windows.Forms.TextBox();
            this.cancellation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.keyDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.keyPersonalAcc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.keyOld = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.keyNew = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.keyCompany = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.keyTariff = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.keyCompanyEnd = new System.Windows.Forms.TextBox();
            this.textCheck = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(13, 11);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(85, 28);
            this.button11.TabIndex = 18;
            this.button11.Text = "🡸";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.CloseClick);
            // 
            // fileDB
            // 
            this.fileDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileDB.Location = new System.Drawing.Point(159, 44);
            this.fileDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fileDB.Name = "fileDB";
            this.fileDB.Size = new System.Drawing.Size(256, 23);
            this.fileDB.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Файл базы данных:";
            // 
            // selectDB
            // 
            this.selectDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectDB.Location = new System.Drawing.Point(422, 43);
            this.selectDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectDB.Name = "selectDB";
            this.selectDB.Size = new System.Drawing.Size(147, 26);
            this.selectDB.TabIndex = 21;
            this.selectDB.Text = "Выбрать файл...";
            this.selectDB.UseVisualStyleBackColor = true;
            this.selectDB.Click += new System.EventHandler(this.SelectDB_Click);
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save.Location = new System.Drawing.Point(424, 322);
            this.save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(145, 26);
            this.save.TabIndex = 24;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ключевое слово:";
            // 
            // keyText
            // 
            this.keyText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyText.Location = new System.Drawing.Point(163, 21);
            this.keyText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keyText.Name = "keyText";
            this.keyText.Size = new System.Drawing.Size(125, 23);
            this.keyText.TabIndex = 25;
            // 
            // cancellation
            // 
            this.cancellation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancellation.Location = new System.Drawing.Point(13, 322);
            this.cancellation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancellation.Name = "cancellation";
            this.cancellation.Size = new System.Drawing.Size(145, 26);
            this.cancellation.TabIndex = 27;
            this.cancellation.Text = "Отмена";
            this.cancellation.UseVisualStyleBackColor = true;
            this.cancellation.Click += new System.EventHandler(this.CloseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Кдюч(дата):";
            // 
            // keyDate
            // 
            this.keyDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyDate.Location = new System.Drawing.Point(163, 75);
            this.keyDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keyDate.Name = "keyDate";
            this.keyDate.Size = new System.Drawing.Size(125, 23);
            this.keyDate.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Ключ(лиц. счет):";
            // 
            // keyPersonalAcc
            // 
            this.keyPersonalAcc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyPersonalAcc.Location = new System.Drawing.Point(163, 48);
            this.keyPersonalAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keyPersonalAcc.Name = "keyPersonalAcc";
            this.keyPersonalAcc.Size = new System.Drawing.Size(125, 23);
            this.keyPersonalAcc.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ключ(ст. показ.):";
            // 
            // keyOld
            // 
            this.keyOld.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyOld.Location = new System.Drawing.Point(163, 102);
            this.keyOld.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keyOld.Name = "keyOld";
            this.keyOld.Size = new System.Drawing.Size(125, 23);
            this.keyOld.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Ключ(нов. показ.):";
            // 
            // keyNew
            // 
            this.keyNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyNew.Location = new System.Drawing.Point(163, 129);
            this.keyNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keyNew.Name = "keyNew";
            this.keyNew.Size = new System.Drawing.Size(125, 23);
            this.keyNew.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Ключ(организация):";
            // 
            // keyCompany
            // 
            this.keyCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyCompany.Location = new System.Drawing.Point(163, 156);
            this.keyCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keyCompany.Name = "keyCompany";
            this.keyCompany.Size = new System.Drawing.Size(125, 23);
            this.keyCompany.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Ключ(тариф):";
            // 
            // keyTariff
            // 
            this.keyTariff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyTariff.Location = new System.Drawing.Point(163, 210);
            this.keyTariff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keyTariff.Name = "keyTariff";
            this.keyTariff.Size = new System.Drawing.Size(125, 23);
            this.keyTariff.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.keyCompanyEnd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.keyText);
            this.groupBox1.Controls.Add(this.keyTariff);
            this.groupBox1.Controls.Add(this.keyDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.keyPersonalAcc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.keyCompany);
            this.groupBox1.Controls.Add(this.keyOld);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.keyNew);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 243);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Для распознавания";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 16);
            this.label8.TabIndex = 43;
            this.label8.Text = "Ключ(кон. организ.):";
            // 
            // keyCompanyEnd
            // 
            this.keyCompanyEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyCompanyEnd.Location = new System.Drawing.Point(163, 183);
            this.keyCompanyEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keyCompanyEnd.Name = "keyCompanyEnd";
            this.keyCompanyEnd.Size = new System.Drawing.Size(125, 23);
            this.keyCompanyEnd.TabIndex = 42;
            // 
            // textCheck
            // 
            this.textCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCheck.Location = new System.Drawing.Point(312, 83);
            this.textCheck.Multiline = true;
            this.textCheck.Name = "textCheck";
            this.textCheck.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textCheck.Size = new System.Drawing.Size(257, 197);
            this.textCheck.TabIndex = 43;
            this.textCheck.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropFile);
            this.textCheck.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterFile);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(312, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 26);
            this.button1.TabIndex = 44;
            this.button1.Text = "Выбрать файл...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoadFile);
            this.button1.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropFile);
            this.button1.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterFile);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 359);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textCheck);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancellation);
            this.Controls.Add(this.save);
            this.Controls.Add(this.selectDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileDB);
            this.Controls.Add(this.button11);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(598, 398);
            this.Name = "SettingForm";
            this.Text = "Настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropFile);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterFile);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox fileDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectDB;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyText;
        private System.Windows.Forms.Button cancellation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keyDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox keyPersonalAcc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox keyOld;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox keyNew;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox keyCompany;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox keyTariff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox keyCompanyEnd;
        private System.Windows.Forms.TextBox textCheck;
        private System.Windows.Forms.Button button1;
    }
}