using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Dashboard.provider
{
    public partial class PN_Request : UserControl
    {
        ProviderRequest providerRequest;
        public PN_Request(ProviderRequest request)
        {
            InitializeComponent();
            providerRequest = request;
            lbl_name_worker.Text = request.name;
            lbl_service.Text = request.service.name;
            lbl_date.Text = request.date.ToString();
            
        }



        private void gunaElipsePanel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sd");
        }

        private void List_of_worker_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sd");
        }

     
        private void gunaElipsePanel1_Click_1(object sender, EventArgs e)
        {
            provider.Provider_Request_details provider_Request_in_Form = new Provider_Request_details(providerRequest);
            provider_Request_in_Form.Show();
        }

        private void pic_worker_Click(object sender, EventArgs e)
        {
            provider.Provider_Request_details provider_Request_in_Form = new Provider_Request_details(providerRequest);
            provider_Request_in_Form.Show();
        }

        private void lpl_name_worker_Click(object sender, EventArgs e)
        {
            provider.Provider_Request_details provider_Request_in_Form = new Provider_Request_details(providerRequest);
            provider_Request_in_Form.Show();
        }

        private void lpl_service_Click(object sender, EventArgs e)
        {
            provider.Provider_Request_details provider_Request_in_Form = new Provider_Request_details(providerRequest);
            provider_Request_in_Form.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            provider.Provider_Request_details provider_Request_in_Form = new Provider_Request_details(providerRequest);
            provider_Request_in_Form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            provider.Provider_Request_details provider_Request_in_Form = new Provider_Request_details(providerRequest);
            provider_Request_in_Form.Show();
        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
