namespace Planets
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox_sun = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            pictureBox_mercury = new PictureBox();
            pictureBox_venus = new PictureBox();
            pictureBox_earth = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_sun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_mercury).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_venus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_earth).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_sun
            // 
            pictureBox_sun.Anchor = AnchorStyles.None;
            pictureBox_sun.Image = (Image)resources.GetObject("pictureBox_sun.Image");
            pictureBox_sun.Location = new Point(650, 650);
            pictureBox_sun.Name = "pictureBox_sun";
            pictureBox_sun.Size = new Size(200, 200);
            pictureBox_sun.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_sun.TabIndex = 0;
            pictureBox_sun.TabStop = false;
            pictureBox_sun.Click += pictureBox1_Click;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // pictureBox_mercury
            // 
            pictureBox_mercury.Anchor = AnchorStyles.None;
            pictureBox_mercury.Image = (Image)resources.GetObject("pictureBox_mercury.Image");
            pictureBox_mercury.Location = new Point(950, 700);
            pictureBox_mercury.Margin = new Padding(0);
            pictureBox_mercury.Name = "pictureBox_mercury";
            pictureBox_mercury.Size = new Size(100, 100);
            pictureBox_mercury.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_mercury.TabIndex = 1;
            pictureBox_mercury.TabStop = false;
            // 
            // pictureBox_venus
            // 
            pictureBox_venus.Anchor = AnchorStyles.None;
            pictureBox_venus.Image = (Image)resources.GetObject("pictureBox_venus.Image");
            pictureBox_venus.Location = new Point(1150, 700);
            pictureBox_venus.Margin = new Padding(0);
            pictureBox_venus.Name = "pictureBox_venus";
            pictureBox_venus.Size = new Size(100, 100);
            pictureBox_venus.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_venus.TabIndex = 2;
            pictureBox_venus.TabStop = false;
            // 
            // pictureBox_earth
            // 
            pictureBox_earth.Anchor = AnchorStyles.None;
            pictureBox_earth.Image = (Image)resources.GetObject("pictureBox_earth.Image");
            pictureBox_earth.Location = new Point(1350, 700);
            pictureBox_earth.Margin = new Padding(0);
            pictureBox_earth.Name = "pictureBox_earth";
            pictureBox_earth.Size = new Size(100, 100);
            pictureBox_earth.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_earth.TabIndex = 3;
            pictureBox_earth.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1468, 1412);
            Controls.Add(pictureBox_earth);
            Controls.Add(pictureBox_venus);
            Controls.Add(pictureBox_mercury);
            Controls.Add(pictureBox_sun);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Solar System Model [not to scale]";
            ((System.ComponentModel.ISupportInitialize)pictureBox_sun).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_mercury).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_venus).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_earth).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox_sun;
        private System.Windows.Forms.Timer timer;
        private PictureBox pictureBox_mercury;
        private PictureBox pictureBox_venus;
        private PictureBox pictureBox_earth;
    }
}