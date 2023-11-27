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
            ((System.ComponentModel.ISupportInitialize)pictureBox_sun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_mercury).BeginInit();
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
            pictureBox_mercury.Location = new Point(850, 650);
            pictureBox_mercury.Margin = new Padding(0);
            pictureBox_mercury.Name = "pictureBox_mercury";
            pictureBox_mercury.Size = new Size(200, 200);
            pictureBox_mercury.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_mercury.TabIndex = 1;
            pictureBox_mercury.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1468, 1412);
            Controls.Add(pictureBox_mercury);
            Controls.Add(pictureBox_sun);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox_sun).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_mercury).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox_sun;
        private System.Windows.Forms.Timer timer;
        private PictureBox pictureBox_mercury;
    }
}