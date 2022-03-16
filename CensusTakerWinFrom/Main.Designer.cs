
namespace CensusTakerWinFrom
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateRange = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.listView = new System.Windows.Forms.ListView();
            this.info = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоЛицевымСчетамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.infoSumm = new System.Windows.Forms.Label();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.comboBoxAddress = new System.Windows.Forms.ComboBox();
            this.clearAddress = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateRange
            // 
            this.dateRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateRange.AutoSize = true;
            this.dateRange.ForeColor = System.Drawing.Color.DarkGreen;
            this.dateRange.Location = new System.Drawing.Point(399, 95);
            this.dateRange.Name = "dateRange";
            this.dateRange.Size = new System.Drawing.Size(43, 16);
            this.dateRange.TabIndex = 4;
            this.dateRange.Text = "Дата";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar.Location = new System.Drawing.Point(394, 118);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.monthCalendar.MaxSelectionCount = 999999999;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2021, 1, 1, 0, 0, 0, 0), new System.DateTime(2021, 1, 7, 0, 0, 0, 0));
            this.monthCalendar.ShowWeekNumbers = true;
            this.monthCalendar.TabIndex = 1;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendarDateChanged);
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.listView);
            this.groupBox.Controls.Add(this.info);
            this.groupBox.Location = new System.Drawing.Point(394, 32);
            this.groupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox.Size = new System.Drawing.Size(376, 62);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Уведомления";
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(5, 38);
            this.listView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(363, 19);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.SmallIcon;
            this.listView.DoubleClick += new System.EventHandler(this.ListViewDoubleClick);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(5, 20);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(45, 16);
            this.info.TabIndex = 1;
            this.info.Text = "Инфо";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.payToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.connectionCheckToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(780, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalAccountToolStripMenuItem,
            this.addressBookToolStripMenuItem,
            this.отчетПоЛицевымСчетамToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.dataToolStripMenuItem.Text = "Данные";
            // 
            // personalAccountToolStripMenuItem
            // 
            this.personalAccountToolStripMenuItem.Name = "personalAccountToolStripMenuItem";
            this.personalAccountToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.personalAccountToolStripMenuItem.Text = "Лицевые счета";
            this.personalAccountToolStripMenuItem.Click += new System.EventHandler(this.PersonalAccountToolStripClick);
            // 
            // addressBookToolStripMenuItem
            // 
            this.addressBookToolStripMenuItem.Name = "addressBookToolStripMenuItem";
            this.addressBookToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.addressBookToolStripMenuItem.Text = "Адресная книга";
            this.addressBookToolStripMenuItem.Click += new System.EventHandler(this.AddressToolStripMenuItem_Click);
            // 
            // отчетПоЛицевымСчетамToolStripMenuItem
            // 
            this.отчетПоЛицевымСчетамToolStripMenuItem.Name = "отчетПоЛицевымСчетамToolStripMenuItem";
            this.отчетПоЛицевымСчетамToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.отчетПоЛицевымСчетамToolStripMenuItem.Text = "Отчет по лицевым счетам";
            this.отчетПоЛицевымСчетамToolStripMenuItem.Click += new System.EventHandler(this.ReportToolStripMenuItem_Click);
            // 
            // payToolStripMenuItem
            // 
            this.payToolStripMenuItem.Name = "payToolStripMenuItem";
            this.payToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.payToolStripMenuItem.Text = "Оплата";
            this.payToolStripMenuItem.Click += new System.EventHandler(this.OperationToolStripClick);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.settingToolStripMenuItem.Text = "Настройки ";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.SettingToolStripMenuItem_Click);
            // 
            // connectionCheckToolStripMenuItem
            // 
            this.connectionCheckToolStripMenuItem.Name = "connectionCheckToolStripMenuItem";
            this.connectionCheckToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
            this.connectionCheckToolStripMenuItem.Text = "Проверка подключения";
            this.connectionCheckToolStripMenuItem.Click += new System.EventHandler(this.ConnectionCheckToolStripMenuItemClick);
            // 
            // cartesianChart
            // 
            this.cartesianChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChart.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cartesianChart.Location = new System.Drawing.Point(0, 70);
            this.cartesianChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartesianChart.Name = "cartesianChart";
            this.cartesianChart.Size = new System.Drawing.Size(382, 322);
            this.cartesianChart.TabIndex = 5;
            this.cartesianChart.Text = "cartesianChart";
            // 
            // infoSumm
            // 
            this.infoSumm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.infoSumm.AutoSize = true;
            this.infoSumm.Location = new System.Drawing.Point(15, 410);
            this.infoSumm.Name = "infoSumm";
            this.infoSumm.Size = new System.Drawing.Size(46, 16);
            this.infoSumm.TabIndex = 6;
            this.infoSumm.Text = "summ";
            // 
            // pieChart1
            // 
            this.pieChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pieChart1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pieChart1.Location = new System.Drawing.Point(0, 70);
            this.pieChart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(382, 322);
            this.pieChart1.TabIndex = 7;
            this.pieChart1.Text = "pieChart";
            // 
            // comboBoxAddress
            // 
            this.comboBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddress.FormattingEnabled = true;
            this.comboBoxAddress.Location = new System.Drawing.Point(12, 33);
            this.comboBoxAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxAddress.Name = "comboBoxAddress";
            this.comboBoxAddress.Size = new System.Drawing.Size(333, 24);
            this.comboBoxAddress.TabIndex = 8;
            // 
            // clearAddress
            // 
            this.clearAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearAddress.Location = new System.Drawing.Point(351, 32);
            this.clearAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearAddress.Name = "clearAddress";
            this.clearAddress.Size = new System.Drawing.Size(31, 26);
            this.clearAddress.TabIndex = 9;
            this.clearAddress.Text = "✕";
            this.clearAddress.UseVisualStyleBackColor = true;
            this.clearAddress.Click += new System.EventHandler(this.ClearAddressClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 438);
            this.Controls.Add(this.clearAddress);
            this.Controls.Add(this.comboBoxAddress);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.infoSumm);
            this.Controls.Add(this.cartesianChart);
            this.Controls.Add(this.dateRange);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(796, 477);
            this.Name = "Main";
            this.Text = "Главное";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressBookToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label dateRange;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private LiveCharts.WinForms.CartesianChart cartesianChart;
        private System.Windows.Forms.Label infoSumm;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.ComboBox comboBoxAddress;
        private System.Windows.Forms.Button clearAddress;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетПоЛицевымСчетамToolStripMenuItem;
    }
}

