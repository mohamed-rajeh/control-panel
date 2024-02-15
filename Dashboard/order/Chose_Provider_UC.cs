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
    public partial class Chose_Provider_UC : Form
    {
        List<Provider> providers = new List<Provider>();
        public Chose_Provider_UC()
        {
            InitializeComponent();


        }

        private void GetProviders()
        {
            // get the service id 
            string serviceId = OrderController.order.service.id;
            if (ProviderServiceController.getProvidersByServic(serviceId) != null)
            {
                //get providers who proviod the service in this order
                providers.AddRange(ProviderServiceController.getProvidersByServic(serviceId));
                Add_provider();

            }
            else
            {
                MessageBox.Show("No Provder for this Service *_*");
                this.Close();
                order_details _Details = new order_details(OrderController.order);
                _Details.Show();
            }



        }

        private void Add_provider()
        {
            foreach (var provider in providers)
            {
                
                chose_provider_PN chose_provider = new chose_provider_PN(provider);
                flowLayoutPanel1.Controls.Add(chose_provider);
            }
        }
        private void Chose_Provider_form1_Load(object sender, EventArgs e)
        {
            // get the providers 
            GetProviders();
        }
    }
}
