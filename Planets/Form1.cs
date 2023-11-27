using System;

namespace Planets
{
    public partial class Form1 : Form
    {
        double angle_mercury = 0;
        double angle_venus = 0;
        double angle_earth = 0;
        // coordinates of centre of the sun
        int center = 750;
        public Form1()
        {
            InitializeComponent();
            timer.Enabled = true;
            timer.Interval = 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // xn = r * cos(a) and yn = r * sin(a) where r is the radius and a in the angle in radians.
            angle_mercury += 0.001;
            angle_venus += 0.003;
            angle_earth += 0.005;
            pictureBox_mercury.Location = new Point((int)(250 * Math.Cos(angle_mercury) + center - 50), (int)(250 * Math.Sin(angle_mercury) + center - 50));
            pictureBox_venus.Location = new Point((int)(450 * Math.Cos(angle_venus) + center - 50), (int)(450 * Math.Sin(angle_venus) + center - 50));
            pictureBox_earth.Location = new Point((int)(650 * Math.Cos(angle_earth) + center - 50), (int)(650 * Math.Sin(angle_earth) + center - 50));
        }
    }
}