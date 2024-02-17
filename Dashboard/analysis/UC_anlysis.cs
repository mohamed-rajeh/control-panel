using System;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Dashboard.analysis
{
    public partial class UC_anlysis : UserControl
    {
        private int customerCount = 0;
        private System.Timers.Timer timer;
        Random random = new Random();

        public UC_anlysis()
        {
            InitializeComponent();
        }

        private void UC_anlysis_Load(object sender, EventArgs e)
        {

            int serviceCount = ServiceContrller.GetAllServices().Count;
            int ordersCount = OrderController.getAllOrders().Count;
            int usersCount = UserController.getAllUsers().Count;
            lbl_service.Text = serviceCount.ToString();
            lbl_orders.Text = ordersCount.ToString();
            lbl_users.Text = usersCount.ToString();

            // إعداد مؤقت لتحديث البيانات كل فترة زمنية
            timer = new System.Timers.Timer(1000); // تحديث البيانات كل ثانية
            timer.Elapsed += TimerElapsed;
            timer.Start();
        }
        private  void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            // Create an instance of Random

            // Generate a random integer between 1 and 100 (inclusive)
            int randomNumber = random.Next(1, 101);
            // تحديث عدد العملاء (يمكنك استبداله بقراءة عدد العملاء من قاعدة البيانات)
            customerCount += randomNumber; // زيادة عدد العملاء بشكل عشوائي

            // إضافة نقطة جديدة إلى المخطط
            chart_users.Invoke((MethodInvoker)delegate
            {
            //    chart1.Series["CustomerRate"].Points.AddY(customerCount);
                chart_users.Series["Count"].Points.AddY(customerCount);
            });
        }

    }
}
