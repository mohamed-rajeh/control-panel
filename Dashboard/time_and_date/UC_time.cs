using System;
using System.Windows.Forms;

namespace Dashboard.time_and_date
{
    public partial class UC_time : UserControl
    {
        public UC_time()
        {
            InitializeComponent();
        }

        private void UC_time_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_lable.Text = DateTime.Now.ToLongTimeString();

        }
    }
}
