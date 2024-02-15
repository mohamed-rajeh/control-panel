using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.order
{
    public partial class order_details : Form
    {
        List<Order_State> list = new List<Order_State>();

        public order_details(Order order)
        {
            InitializeComponent();
            if (order != null)
            {
                lbl_id.Text = order.id;
                lbl_name.Text = order.customer.Name;
                lbl_service.Text = order.service.name;
                lbl_date.Text = order.date.ToString();
                lbl_provider.Text = order.provider != null ? order.provider.Name : "chouse a provider !";
                lbl_note.Text = order.note;

                
            }
            list.Clear();
            // fetch a data of states to a combo 
            list.AddRange( StateController.getAllSate());
            if (list != null)
            {
                cmb_states.DataSource = list;
                // set the name as  display item 
                cmb_states.DisplayMember = "name";
                //set the id to be a value
                cmb_states.ValueMember = "id";

                if(order.state != null) cmb_states.SelectedItem  = list.Find(state => state.id == order.state.id);
               
            }
            OrderController.order = order;

        }




        private void gunaButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sava");
        }


        private void txt_msg_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Save changes ! " , "Save" , MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                OrderController.order.state = cmb_states.SelectedItem as Order_State;
                if (OrderController.UpdateOrder(OrderController.order) <= 0) MessageBox.Show("Feild *_*");
                else this.Close();
            }
        }

        private void But_chose_provider_Click(object sender, EventArgs e)
        {
            OrderController.order.state = cmb_states.SelectedItem as Order_State;
            this.Close();
            Chose_Provider_UC _providrs = new Chose_Provider_UC(); 
            _providrs.Show();
        }

        

        
    }
}
