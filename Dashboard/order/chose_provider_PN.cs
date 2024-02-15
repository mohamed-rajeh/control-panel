using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.order
{
    
    public partial class chose_provider_PN : UserControl
    { 
        Provider provider;

        public chose_provider_PN(Provider provider)
        {
            InitializeComponent();
            this.provider = provider;
            txt_provider_name.Text = provider.Name;
            Label_provider_phone.Text = provider.Phone;
            Label_provider_address.Text = provider.Address.street;
            Label_provider_service.Text = provider.Id;
           
        }

        private void but_chose_Click(object sender, EventArgs e)
        {
            // set the new provider
            OrderController.order.provider = provider;

            // Access the main form using FindForm()
            Form mainForm = this.FindForm();

            // Check if the main form is found
            if (mainForm != null)
            {
                // Close the user control (which is the "this" form)
                mainForm.Close();   

                //pass and show the new details form
                order_details _Details = new order_details(OrderController.order); 
                _Details.Show();
            }
           
        }
    }
}
