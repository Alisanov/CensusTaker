
namespace CensusTakerWinFrom
{
    partial class ReportForm
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
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.EnterReport = new System.Windows.Forms.Button();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.personalAccountSource = new System.Windows.Forms.BindingSource(this.components);
            this.operationSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxPersonalAcc = new System.Windows.Forms.ComboBox();
            this.labelPersonalAcc = new System.Windows.Forms.Label();
            this.withСheck = new System.Windows.Forms.CheckBox();
            this.сlose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personalAccountSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(98, 10);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(155, 23);
            this.dateStart.TabIndex = 0;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(259, 10);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(150, 23);
            this.dateEnd.TabIndex = 1;
            // 
            // EnterReport
            // 
            this.EnterReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EnterReport.Location = new System.Drawing.Point(850, 7);
            this.EnterReport.Name = "EnterReport";
            this.EnterReport.Size = new System.Drawing.Size(75, 24);
            this.EnterReport.TabIndex = 2;
            this.EnterReport.Text = "Начать";
            this.EnterReport.UseVisualStyleBackColor = true;
            this.EnterReport.Click += new System.EventHandler(this.EnterReport_Click);
            // 
            // reportViewer
            // 
            this.reportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer.AutoScroll = true;
            this.reportViewer.LocalReport.DisplayName = "Отчет по лицевым счетам";
            this.reportViewer.LocalReport.EnableExternalImages = true;
            this.reportViewer.LocalReport.EnableHyperlinks = true;
            this.reportViewer.LocalReport.ReportEmbeddedResource = "CensusTakerWinFrom.ReportPersanolAcc.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(6, 37);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(919, 494);
            this.reportViewer.TabIndex = 5;
            // 
            // personalAccountSource
            // 
            this.personalAccountSource.DataSource = typeof(CensusTakerWinFrom.Class.PersonalAccount);
            // 
            // operationSource
            // 
            this.operationSource.DataSource = typeof(CensusTakerWinFrom.Class.Operation);
            // 
            // comboBoxPersonalAcc
            // 
            this.comboBoxPersonalAcc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPersonalAcc.FormattingEnabled = true;
            this.comboBoxPersonalAcc.Location = new System.Drawing.Point(524, 8);
            this.comboBoxPersonalAcc.Name = "comboBoxPersonalAcc";
            this.comboBoxPersonalAcc.Size = new System.Drawing.Size(238, 24);
            this.comboBoxPersonalAcc.TabIndex = 6;
            // 
            // labelPersonalAcc
            // 
            this.labelPersonalAcc.AutoSize = true;
            this.labelPersonalAcc.Location = new System.Drawing.Point(415, 12);
            this.labelPersonalAcc.Name = "labelPersonalAcc";
            this.labelPersonalAcc.Size = new System.Drawing.Size(103, 16);
            this.labelPersonalAcc.TabIndex = 7;
            this.labelPersonalAcc.Text = "Лицевой счет:";
            // 
            // withСheck
            // 
            this.withСheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.withСheck.AutoSize = true;
            this.withСheck.Location = new System.Drawing.Point(768, 11);
            this.withСheck.Name = "withСheck";
            this.withСheck.Size = new System.Drawing.Size(79, 20);
            this.withСheck.TabIndex = 8;
            this.withСheck.Text = "с чеком";
            this.withСheck.UseVisualStyleBackColor = true;
            // 
            // Close
            // 
            this.сlose.Location = new System.Drawing.Point(6, 5);
            this.сlose.Margin = new System.Windows.Forms.Padding(4);
            this.сlose.Name = "Close";
            this.сlose.Size = new System.Drawing.Size(85, 28);
            this.сlose.TabIndex = 20;
            this.сlose.Text = "🡸";
            this.сlose.UseVisualStyleBackColor = true;
            this.сlose.Click += new System.EventHandler(this.CloseClick);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 534);
            this.Controls.Add(this.сlose);
            this.Controls.Add(this.withСheck);
            this.Controls.Add(this.labelPersonalAcc);
            this.Controls.Add(this.comboBoxPersonalAcc);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.EnterReport);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Name = "ReportForm";
            this.Text = "Отчет по лицевому счету";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportForm_FormClosing);
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personalAccountSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Button EnterReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource personalAccountSource;
        private System.Windows.Forms.BindingSource operationSource;
        private System.Windows.Forms.ComboBox comboBoxPersonalAcc;
        private System.Windows.Forms.Label labelPersonalAcc;
        private System.Windows.Forms.CheckBox withСheck;
        private System.Windows.Forms.Button сlose;
    }
}