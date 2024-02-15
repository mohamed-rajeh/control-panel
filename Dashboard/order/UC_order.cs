using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Dashboard.order
{
    public partial class UC_order : UserControl
    {
       private List<Order> _orders = new List<Order>();
        public UC_order()
        {
            InitializeComponent();
            _orders.AddRange(OrderController.getAllOrders());


        }

        private void Add_order(List<Order> orders)
        {
            flowLayoutPanel1.Controls.Clear();
            // if(orders.Count ==0 || orders ==null ) lbl_noItems.Visible = true;
          
            //  soso shuod fix this ^_^
           //  if (orders.Count == 0 || orders == null) flowLayoutPanel1.Controls.Add(lbl_noItems);
                foreach (var order in orders)
            {
                PN_Order list_Order_Clients = new PN_Order(order);
                flowLayoutPanel1.Controls.Add(list_Order_Clients);
            }



        }

        //Get all orders
        private void label13_Click(object sender, EventArgs e)
        {
            panel_line_lable.Width = label_all.Width;

            panel_line_lable.Top = label_all.Bottom;
            panel_line_lable.Left = label_all.Left;
          
            Add_order(_orders);

        }

        // Get the new orders 
        private void labe_new_Click(object sender, EventArgs e)
        {
            panel_line_lable.Width = label_new.Width;
            panel_line_lable.Top = label_new.Bottom;
            panel_line_lable.Left = label_new.Left;

            List<Order> orders = _orders.FindAll(order => order.state.id == "1");
            Add_order(orders);
        }

        // Get the accepted orders 
        private void label_cancel_Click(object sender, EventArgs e)
        {
            panel_line_lable.Width = label_accepted.Width;
            panel_line_lable.Top = label_accepted.Bottom;
            panel_line_lable.Left = label_accepted.Left;

            List<Order> orders = _orders.FindAll(order => order.state.id == "2");
            Add_order(orders);
        }
        private void UC_order_Load(object sender, EventArgs e)
        {
           
            // to show count of orders hav done . 
            lbl_done_orders.Text = _orders.FindAll(order=> order.state.name.ToLower() == "done").Count.ToString();
            labe_new_Click(null, null);

        }

        private void text_order_search_Enter_1(object sender, EventArgs e)
        {
            if (txt_search.Text == "search")
            {
                txt_search.Text = "";

                txt_search.ForeColor = Color.Black;
            }
        }




        private void txt_search_TextChanged_1(object sender, EventArgs e)
        {
            // find all orders that Contain a value in search TextBox 
            List<Order> orders = _orders.FindAll(order => order.customer.Name.Contains(txt_search.Text) ||
                                                          order.service.name.Contains(txt_search.Text) ||
                                                          order.id.Contains(txt_search.Text) ||
                                                          order.state.name.Contains(txt_search.Text));
            Add_order(orders);
        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            label13_Click(null, null);  
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
