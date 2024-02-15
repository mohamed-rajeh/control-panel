using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class PN_provider : UserControl
    {
       private Provider _provider;
        public PN_provider(Provider provider)
        {
            InitializeComponent();
            _provider = provider;
            lpl_worker.Text = provider.Name;
            lpl_worker.ForeColor = provider.Available ? Color.Black : Color.Red;
        }





        private void picture_user_Click(object sender, EventArgs e)
        {
            provider_details worker_info_form = new provider_details(_provider);
            worker_info_form.Show();

        }
    }
}
