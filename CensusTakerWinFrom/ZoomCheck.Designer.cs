
namespace CensusTakerWinFrom
{
    partial class ZoomCheck
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.уменьшитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureCheck = new System.Windows.Forms.PictureBox();
            this.pictureZoom = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // уменьшитьToolStripMenuItem
            // 
            this.уменьшитьToolStripMenuItem.Name = "уменьшитьToolStripMenuItem";
            this.уменьшитьToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.pictureCheck);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(2, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 257);
            this.panel1.TabIndex = 7;
            // 
            // pictureCheck
            // 
            this.pictureCheck.Location = new System.Drawing.Point(265, 55);
            this.pictureCheck.Name = "pictureCheck";
            this.pictureCheck.Size = new System.Drawing.Size(183, 134);
            this.pictureCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCheck.TabIndex = 6;
            this.pictureCheck.TabStop = false;
            this.pictureCheck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureCheckMouseDown);
            this.pictureCheck.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureCheckMouseMove);
            this.pictureCheck.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureCheckMouseUp);
            // 
            // pictureZoom
            // 
            this.pictureZoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureZoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureZoom.Location = new System.Drawing.Point(2, 295);
            this.pictureZoom.Name = "pictureZoom";
            this.pictureZoom.Size = new System.Drawing.Size(735, 88);
            this.pictureZoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureZoom.TabIndex = 3;
            this.pictureZoom.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "-🔍";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.PlusClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "+🔍";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MunisClick);
            // 
            // ZoomCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 383);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureZoom);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(300, 259);
            this.Name = "ZoomCheck";
            this.Text = "Просмотр чека";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ZoomCheck_FormClosing);
            this.Load += new System.EventHandler(this.ZoomCheck_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureZoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem уменьшитьToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureZoom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureCheck;
        private System.Windows.Forms.Panel panel1;
    }
}