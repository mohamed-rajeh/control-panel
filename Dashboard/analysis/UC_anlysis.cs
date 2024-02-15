using System;
using System.Windows.Forms;

namespace Dashboard.analysis
{
    public partial class UC_anlysis : UserControl
    {
        public UC_anlysis()
        {
            InitializeComponent();
        }

        private void UC_anlysis_Load(object sender, EventArgs e)
        {

            chart1.Series["ser"].Points.AddXY("sun", 60);
            chart1.Series["ser"].Points.AddXY("sun", 20);
            chart1.Series["ser"].Points.AddXY("sun", 99);
            chart1.Series["ser"].Points.AddXY("sun", 43);
        }

        private void gunaPanel3_Paint(object sender, PaintEventArgs e)
        {



        }

        private void gunaElipsePanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
