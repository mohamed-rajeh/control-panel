using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Dashboard.order
{
    public partial class PN_Order : UserControl
    {
        Order _order;
        
        public PN_Order(Order order)
        {
            InitializeComponent();
            
            _order = order;
            
            lbl_custmor_name.Text = order.customer.Name;
            lbl_service_nme.Text = order.service.name;
            lbl_state.Text = order.state.name;
            lbl_order_date.Text = order.date.ToString();
        }

       
        private void pic_order_Click(object sender, EventArgs e)
        {
            order_details order_Details = new order_details(_order);
            order_Details.Show();
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            order_details info_order = new order_details(_order);
            info_order.Show();
        }

        private void lable_ser_name_order_Click(object sender, EventArgs e)
        {
            order_details order_Details = new order_details(_order);
            order_Details.Show();
        }

        private void label_orderID_Click(object sender, EventArgs e)
        {
            order_details order_Details = new order_details(_order);
            order_Details.Show();
        }

        private void label_cname_Click(object sender, EventArgs e)
        {
            order_details order_Details = new order_details(_order);
            order_Details.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            order_details order_Details = new order_details(_order);
            order_Details.Show();
        }

        private void label_state_Click(object sender, EventArgs e)
        {
            order_details order_Details = new order_details(_order);
            order_Details.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
