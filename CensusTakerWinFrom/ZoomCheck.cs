using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CensusTakerWinFrom.Properties;

namespace CensusTakerWinFrom
{
    public partial class ZoomCheck : FormStyle
    {
        private Graphics g;
        private Bitmap bmp;
        private readonly int widthZoom;
        bool flagmousebutton = false;

        int mouseX, mouseY;

        public ZoomCheck(Image check)
        {
            InitializeComponent();
            pictureCheck.Width = check.Width;
            pictureCheck.Height = check.Height;
            pictureCheck.Image = check;
            Timer timer = new Timer();
            timer.Tick += new EventHandler(this.TimerTick);
            timer.Interval = 1;
            timer.Start();
            panel1.MouseWheel += new MouseEventHandler(this.PanelMouseWheel);
            panel1.AutoScroll = true;
            widthZoom = pictureCheck.Width;
        }
        private void TimerTick(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureZoom.Width, pictureZoom.Height);
            g = this.CreateGraphics();
            g = Graphics.FromImage(bmp);
            if (MousePosition.Y > Top && MousePosition.Y < Bottom)
            {
                g.CopyFromScreen(Left + 8, MousePosition.Y - 30, 0, 0, new Size(pictureZoom.Width, pictureZoom.Height));
            }
            pictureZoom.Image = bmp;
            //Point point = new Point(MousePosition.X, MousePosition.Y);
            //pictureZoom.Location = point;
        }
        private void MunisClick(object sender, EventArgs e)
        {
            pictureCheck.Width += 80; ;
            pictureCheck.Height += 160;
            pictureCheck.Location = new Point(pictureCheck.Location.X - 40, pictureCheck.Location.Y - 80);
        }
        private void PlusClick(object sender, EventArgs e)
        {
            pictureCheck.Width -= 80;
            pictureCheck.Height -= 160;
            pictureCheck.Location = new Point(pictureCheck.Location.X + 40, pictureCheck.Location.Y + 80);
        }
        private void ZoomCheck_Load(object sender, EventArgs e)
        {
            Bounds = new Main().LoadSizeForn(Settings.Default.ZoomCheckProperties, Bounds);
        }
        private void ZoomCheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.ZoomCheckProperties = Bounds;
            Settings.Default.Save();
        }
        private void PanelMouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                pictureCheck.Width += 80; ;
                pictureCheck.Height += 160;
                pictureCheck.Location = new Point(pictureCheck.Location.X - 40, pictureCheck.Location.Y - 80);
            }
            else
            {
                if (pictureCheck.Width > widthZoom)
                {
                    pictureCheck.Width -= 80;
                    pictureCheck.Height -= 160;
                    pictureCheck.Location = new Point(pictureCheck.Location.X + 40, pictureCheck.Location.Y + 80);
                }
            }
        }
        private void PictureCheckMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                flagmousebutton = true;

                mouseX = e.X;
                mouseY = e.Y;
                Cursor = Cursors.Hand;
            }
        }
        private void PictureCheckMouseUp(object sender, MouseEventArgs e)
        {
            if (flagmousebutton == true)
            {
                flagmousebutton = false;
                this.Cursor = Cursors.Default;
            }
        }
        private void PictureCheckMouseMove(object sender, MouseEventArgs e)
        {
            if (flagmousebutton == true)
            {
                int dx = e.X - mouseX;
                int dy = e.Y - mouseY;
                pictureCheck.Location = new Point(pictureCheck.Location.X + dx, pictureCheck.Location.Y + dy);
            }
        }
    }
}