using CensusTakerWinFrom.Properties;
using Emgu.CV;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CensusTakerWinFrom
{
    public partial class SettingForm : FormStyle
    {
        private readonly Main main;
        public SettingForm(Main main)
        {
            InitializeComponent();
            this.main = main;
        }
        private void SettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.SettingPropertirs = Bounds;
            Settings.Default.Save();
        }
        private void SelectDB_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                Filter = "Файлы базы данных(*.db)| *.db"
            };
            openFile.ShowDialog();
            if (!openFile.FileName.Equals(string.Empty))
                fileDB.Text = openFile.FileName;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            string oldFileDB = Settings.Default.Database;
            //Settings.Default.Font = fontButton.Font;
            Settings.Default.Database = fileDB.Text;
            Settings.Default.KeyString = keyText.Text;
            Settings.Default.KeyPersonalAcc = keyPersonalAcc.Text;
            Settings.Default.KeyDate = keyDate.Text;
            Settings.Default.KeyOld = keyOld.Text;
            Settings.Default.KeyNew = keyNew.Text;
            Settings.Default.KeyCompany = keyCompany.Text;
            Settings.Default.KeyCompanyEnd = keyCompanyEnd.Text;
            Settings.Default.KeyTariff = keyTariff.Text;
            Settings.Default.Save();

            if (main.CheckDB())
            {
                MessageBox.Show("Настройки сохранены", "Настройки", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Ошибка подключения к базе", "Настройки", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Settings.Default.Database = oldFileDB;
                Settings.Default.Save();
            }

        }
        private void ColorForm_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
        }
        private void SettingForm_Load(object sender, EventArgs e)
        {
            Bounds = new Main().LoadSizeForn(Settings.Default.SettingPropertirs, Bounds);

            fileDB.Text = Settings.Default.Database;
            keyText.Text = Settings.Default.KeyString;
            keyPersonalAcc.Text = Settings.Default.KeyPersonalAcc;
            keyDate.Text = Settings.Default.KeyDate;
            keyOld.Text = Settings.Default.KeyOld;
            keyNew.Text = Settings.Default.KeyNew;
            keyCompany.Text = Settings.Default.KeyCompany;
            keyCompanyEnd.Text = Settings.Default.KeyCompanyEnd;
            keyTariff.Text = Settings.Default.KeyTariff;
        }
        private void CloseClick(object sender, EventArgs e)
        {
            Close();
        }
        private void DragEnterFile(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move))
                e.Effect = DragDropEffects.Move;
        }
        private void DragDropFile(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Move)
            {
                string[] objects = (string[])e.Data.GetData(DataFormats.FileDrop);
                // В objects хранятся пути к папкам и файлам
                if (objects.Length > 0)
                {
                    TextRecognition(objects[0]);
                }
            }
        }

        private void LoadFile(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                Filter = "Файлы изображений(*.bmp, *.jpg, *.png, *jpeg, *pdf)| *.bmp; *.jpg; *.png; *.jpeg; *.pdf"
            };
            if (openFile.ShowDialog() == DialogResult.OK)
                TextRecognition(openFile.FileName);

        }
        private void TextRecognition(string openFile)
        {
            try
            {
                if (openFile.Contains("pdf"))
                {
                    using (PdfDocument document = PdfDocument.Load(openFile))
                    {
                        Image image = document.Render(0, 300, 300, true);
                        openFile = openFile.Replace("pdf", "jpeg");
                        image.Save(openFile, ImageFormat.Jpeg);
                    }
                }
                //if (File.Exists("tessdata"))
                //    throw new Exception("Необходимо скачать пакет tessdata");
                using (Tesseract tessract = new Tesseract(@"tessdata", "rus", OcrEngineMode.TesseractLstmCombined))
                {
                    tessract.SetImage(new Image<Bgr, byte>(openFile));
                    tessract.Recognize();
                    textCheck.Text = tessract.GetUTF8Text();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, err.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
