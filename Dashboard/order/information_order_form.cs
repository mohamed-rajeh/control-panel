using System;
using System.Windows.Forms;

namespace Dashboard.order
{
    public partial class information_order_form : Form
    {
        public information_order_form(Order order)
        {
            InitializeComponent();
         if(order != null)
            {
                label_id.Text = order.id;
                txt_provider.Text = order.provider != null ? order.provider.Name : "chouse a provider !";
                txt_service.Text = order.service.name;
                txt_state.Text = order.state.name;
                txt_date.Text = order.date.ToString();
                lebl_user.Text = order.customer.Name; 
            }
        }
        public information_order_form()
        {
            InitializeComponent();
        }
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void information_order_form_Load(object sender, EventArgs e)
        {
            Panel_username.Width = lebl_user.Width;
        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_add_worker_Click(object sender, EventArgs e)
        {
            
        }
    }
}
