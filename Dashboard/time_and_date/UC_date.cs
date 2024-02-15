using System;
using System.Windows.Forms;

namespace Dashboard.time_and_date
{
    public partial class UC_date : UserControl
    {
        public UC_date()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date_lable.Text = DateTime.Now.ToLongDateString();
        }

        private void UC_date_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
