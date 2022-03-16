using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CensusTakerWinFrom.Properties;
using LiteDB;
using Microsoft.Reporting.WinForms;

namespace CensusTakerWinFrom
{
    public partial class ReportForm : FormStyle
    {
        private List<Guid> idPersonalAccount = new List<Guid>();
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            dateStart.Value = new DateTime(date.Year, 1, 1);
            dateEnd.Value = new DateTime(date.Year, 12, 31);
            Bounds = new Main().LoadSizeForn(Settings.Default.ReportPropertirs, Bounds);
            reportViewer.ProcessingMode = ProcessingMode.Local;

            LiteDatabase database = new LiteDatabase(Settings.Default.Database);
            LiteCollection<Class.PersonalAccount> tablePersonalAccount = database.GetCollection<Class.PersonalAccount>(Class.PersonalAccountText);
            IEnumerable<Class.PersonalAccount> dataPersonalAccount = tablePersonalAccount.FindAll();
            foreach (var personalAccount in dataPersonalAccount)
            {
                idPersonalAccount.Add(personalAccount.ID);
                comboBoxPersonalAcc.Items.Add(personalAccount.NamePersonalAccFull);
            }
            if (comboBoxPersonalAcc.Items.Count > 0 && comboBoxPersonalAcc.SelectedIndex == -1)
                comboBoxPersonalAcc.SelectedIndex = 0;

        }

        private void ReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.ReportPropertirs = Bounds;
            Settings.Default.Save();
        }

        private void EnterReport_Click(object sender, EventArgs e)
        {
            if (comboBoxPersonalAcc.SelectedIndex != -1)
            {
                List<Class.PersonalAccount> personalAccounts = new List<Class.PersonalAccount>();
                List<Class.Operation> operations = new List<Class.Operation>();

                using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
                {
                    LiteCollection<Class.Operation> tableOperation = database.GetCollection<Class.Operation>(Class.OperationText);
                    IEnumerable<Class.Operation> dataOperation = tableOperation.Find(x => x.PersonalAccountID.Equals(idPersonalAccount[comboBoxPersonalAcc.SelectedIndex]) && x.Date >= dateStart.Value && x.Date <= dateEnd.Value);
                    dataOperation = dataOperation.OrderBy(z => z.Date);

                    foreach (Class.Operation operation in dataOperation)
                    {
                        operations.Add(operation);
                    }
                }
                personalAccountSource.DataSource = personalAccounts;
                operationSource.DataSource = operations;

                reportViewer.LocalReport.SetParameters(new ReportParameter("PersonalAcc", comboBoxPersonalAcc.Text));
                reportViewer.LocalReport.SetParameters(new ReportParameter("dateStart", dateStart.Value.ToString()));
                reportViewer.LocalReport.SetParameters(new ReportParameter("dateEnd", dateEnd.Value.ToString()));
                reportViewer.LocalReport.SetParameters(new ReportParameter("PersonalAcc", comboBoxPersonalAcc.Text));
                reportViewer.LocalReport.SetParameters(new ReportParameter("withСheck", (!withСheck.Checked).ToString()));
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Operation", operationSource));
                reportViewer.LocalReport.Refresh();
                reportViewer.RefreshReport();

                PageSettings ps = new PageSettings();
                ps.Margins.Bottom = 5;
                ps.Margins.Top = 5;
                ps.Margins.Right = 5;
                ps.Margins.Left = 5;
                ps.Landscape = true;
                // ps.PaperSize = new PaperSize("A4", 1170, 827);
                ps.PaperSize.RawKind = (int)PaperKind.A4;


                reportViewer.SetPageSettings(ps);
            }
        }

        private void CloseClick(object sender, EventArgs e)
        {
            Close();
        }
    }

}
