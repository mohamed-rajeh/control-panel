using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using Dashboard.model;
namespace Dashboard
{
   
    public partial class Form2 : Form
    {
        public Admin admin;
        public Form2()
        {
            InitializeComponent();
            try
            {
                but_order_Click(null, null); 
            }
            catch (Exception e)
            {

                throw e;
            }
            


        }
        private void addUserControl(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;
            panel_display.Controls.Clear();
            panel_display.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            lbl_adminName.Text = Admin.AdminName ?? "Unknoune";
           
        }

        //ادخل العناصر
        //private void populateItems()
        //{
        //   // string[] Users_name = { "sohib", "mohammed", "marwan", "hamoosh" };
        //    //populate it here 
        //    pro_control[] pro_control = new pro_control[5];
        //    // loop through each itme
        //    for (int i = 0; i < pro_control.Length; i++)
        //    {
        //        pro_control[i] = new pro_control();
        //        pro_control[i].laple_user = "sohib";

        //        //   pro_control[i].picture = Image.FromFile("C:\\Users\tehama\\Desktop\\New folder\\photo_2023-01-02_23-38-56.jpg");

        //        //add to flowlayout
        //        //if (flowLayoutPanel1.Controls.Count >0)
        //        //{
        //        //    flowLayoutPanel1.Controls.Clear();
        //        //}
        //        //else
        //        flowLayoutPanel1.Controls.Add(pro_control[i]);
        //    }
        //}




        private void but_User_Click(object sender, EventArgs e)
        {
            UC_Users uc = new UC_Users();
            addUserControl(uc);
            panl_v.Height = but_User.Height;
            panl_v.Top = but_User.Top;
            panl_v.Left = but_User.Left;
           // but_User.BackColor = Color.FromArgb(230, 230, 230);
           // but_pic_user.BackColor = Color.FromArgb(230, 230, 230);

        }
        private void but_User_Leave(object sender, EventArgs e)
        {
            but_User.BackColor = Color.FromArgb(253, 253, 253);
            but_pic_user.BackColor = Color.FromArgb(253, 253, 253);
        }


        private void but_services_Click(object sender, EventArgs e)
        {
            UC_services uc = new UC_services();
            addUserControl(uc);
            //  Tool_User.Visible = false;
            // Tool_services.Visible = true;
            panl_v.Height = but_services.Height;
            panl_v.Top = but_services.Top;
            panl_v.Left = but_services.Left;
           // but_services.BackColor = Color.FromArgb(230, 230, 230);
           // but_pic_services.BackColor = Color.FromArgb(230, 230, 230);
        }
        private void but_services_Leave(object sender, EventArgs e)
        {
            but_services.BackColor = Color.FromArgb(253, 253, 253);
            but_pic_services.BackColor = Color.FromArgb(253, 253, 253);
        }


        private void but_workers_Click(object sender, EventArgs e)
        {
            provider.provider_UC uc = new provider.provider_UC();
            addUserControl(uc);
            panl_v.Height = but_workers.Height;
            panl_v.Top = but_workers.Top;
            panl_v.Left = but_workers.Left;
           // but_workers.BackColor = Color.FromArgb(230, 230, 230);
           // but_pic_worker.BackColor = Color.FromArgb(230, 230, 230);
        }
        private void but_workers_Leave(object sender, EventArgs e)
        {
            but_workers.BackColor = Color.FromArgb(253, 253, 253);
            but_pic_worker.BackColor = Color.FromArgb(253, 253, 253);
        }


        private void but_order_Click(object sender, EventArgs e)
        {

            order.UC_order uc = new order.UC_order();
            addUserControl(uc);
            panl_v.Height = but_order.Height;
            panl_v.Top = but_order.Top;
            panl_v.Left = but_order.Left;
          //  but_order.BackColor = Color.FromArgb(230, 230, 230);
           // but_pic_order.BackColor = Color.FromArgb(230, 230, 230);
        }
        private void but_order_Leave(object sender, EventArgs e)
        {
            but_order.BackColor = Color.FromArgb(253, 253, 253);
            but_pic_order.BackColor = Color.FromArgb(253, 253, 253);
        }


        private void but_Analysis_Click(object sender, EventArgs e)
        {
            analysis.UC_anlysis uc = new analysis.UC_anlysis();
            addUserControl(uc);
            panl_v.Height = but_Analysis.Height;
            panl_v.Top = but_Analysis.Top;
            panl_v.Left = but_Analysis.Left;
          //  but_Analysis.BackColor = Color.FromArgb(230, 230, 230);
         //   but_pic_Analysis.BackColor = Color.FromArgb(230, 230, 230);
        }
        private void but_Analysis_Leave(object sender, EventArgs e)
        {
            but_Analysis.BackColor = Color.FromArgb(253, 253, 253);
            but_pic_Analysis.BackColor = Color.FromArgb(253, 253, 253);
        }


        private void but_sttings_Click(object sender, EventArgs e)
        {
            panl_v.Height = but_sttings.Height;
            panl_v.Top = but_sttings.Top;
            panl_v.Left = but_sttings.Left;
            but_sttings.BackColor = Color.FromArgb(230, 230, 230);
            but_pic_setting.BackColor = Color.FromArgb(230, 230, 230);
        }
        private void but_sttings_Leave(object sender, EventArgs e)
        {
            but_sttings.BackColor = Color.FromArgb(253, 253, 253);
            but_pic_setting.BackColor = Color.FromArgb(253, 253, 253);
        }


        private void gunaButton1_Click(object sender, EventArgs e)
        {

            this.Close();
            Application.Exit();
            //Close();
            //Form1 login = new Form1();
            //login.Close();
        }


    }
}
