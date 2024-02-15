using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Dashboard.order
{
    public partial class UC_order : UserControl
    {
        List<Order> orders = new List<Order>();
        public UC_order()
        {
            InitializeComponent();
            orders.AddRange(OrderController.getAllOrders());

        }

        private void Add_order()
        {
            foreach (var order in orders)
            {
                PN_Order list_Order_Clients = new PN_Order(order);
                flowLayoutPanel1.Controls.Add(list_Order_Clients);
            }







            ///
            /// soooooheb coooooooooooooooooooode
            ///




            //string[] order_service_name = { "مهندس دش", "كهربائي", "سباك" };
            ////populate it here 
            //string[] orderid = { "Null", "null", "null" };
            //string[] name_client = { "mohamed", "Ali", "mansor" };
            //string[] order_state = { "ملغي", "تم", "قيد الموافقة" };


            //List_Order_Client[] list_order_client = new List_Order_Client[orders.Count];

            // loop through each itme
            //for (int i = 0; i < list_order_client.Length; i++)
            //{
            //    list_order_client[i] = new List_Order_Client();
            //    list_order_client[i].laple_service_order = orders[i].service.name;
            //    list_order_client[i].laple_orderID = orders[i].id;
            //    list_order_client[i].lapel_cname = orders[i].customer.Name;
            //    list_order_client[i].lapel_state = orders[i].state.name;
            //   list_order_client[i].order = orders[i];


            //   pro_control[i].picture = Image.FromFile("C:\\Users\tehama\\Desktop\\New folder\\photo_2023-01-02_23-38-56.jpg");

            //add to flowlayout
            //if (flowLayoutPanel1.Controls.Count >0)
            //{
            //    flowLayoutPanel1.Controls.Clear();
            //}
            //else
            //flowLayoutPanel1.Controls.Add(list_order_client[i]);


            ///
            /// soooooheb cooooooooooooooooooooooooooooooooooooooooooooooooooooode
            ///



        }
        private void label13_Click(object sender, EventArgs e)
        {
            panel_line_lable.Width = label_all.Width;

            panel_line_lable.Top = label_all.Bottom;
            panel_line_lable.Left = label_all.Left;


        }

        private void labe_new_Click(object sender, EventArgs e)
        {
            panel_line_lable.Width = label_new.Width;
            panel_line_lable.Top = label_new.Bottom;
            panel_line_lable.Left = label_new.Left;
        }

        private void label_cancel_Click(object sender, EventArgs e)
        {
            panel_line_lable.Width = label_cancel.Width;
            panel_line_lable.Top = label_cancel.Bottom;
            panel_line_lable.Left = label_cancel.Left;
        }
        private void UC_order_Load(object sender, EventArgs e)
        {
            Add_order();
            // to show count of orders hav done . 
            lbl_done_orders.Text = orders.FindAll(order=> order.state.name.ToLower() == "done").Count.ToString();
        }

        private void text_order_search_Enter_1(object sender, EventArgs e)
        {
            if (text_order_search.Text == "search")
            {
                text_order_search.Text = "";

                text_order_search.ForeColor = Color.Black;
            }
        }

        private void text_order_search_Leave(object sender, EventArgs e)
        {
            if (text_order_search.Text == "")
            {
                text_order_search.Text = "search";

                text_order_search.ForeColor = Color.Silver;
            }
        }
    }
}
