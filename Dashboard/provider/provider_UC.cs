using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Dashboard.provider
{
    public partial class provider_UC : UserControl
    {
         List<Provider> _providers = new List<Provider>();

        public provider_UC()
        {
            InitializeComponent();
            _providers.AddRange(ProviderController.getAllProviders());
            lbl_providers_count.Text = _providers.Count.ToString();
            lbl_providers_available.Text = _providers.FindAll(provider => provider.Available == true).Count.ToString();
        }

        //get set all providers in the panel  whene UI load 
        private void UC_worker_Load(object sender, EventArgs e)
        {
            AddProviders(_providers);
        }


        // show the adding Form 
        private void but_add_worker_Click(object sender, EventArgs e)
        {

            Add_provider_form add_worker_form = new Add_provider_form();
            add_worker_form.Show();
        }

        // show a requests Form 
        private void but_Request_workers_Click_1(object sender, EventArgs e)
        {
            request_UC list_provider_form = new request_UC();
            list_provider_form.Show();
        }

        // searching event 
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            List<Provider> providers = _providers.FindAll(provider => provider.Id.Contains(txt_search.Text) ||
                                                     provider.Name.ToLower().Contains(txt_search.Text) ||
                                                     provider.Address.city.ToLower().Contains(txt_search.Text) ||
                                                     provider.IdCard.Contains(txt_search.Text));
            AddProviders(providers);
        }

        // put provierds  in panel "Functon" 
        private void AddProviders(List<Provider> providers)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var provider in providers)
            {
                PN_provider pnProvider = new PN_provider(provider);
                flowLayoutPanel1.Controls.Add(pnProvider);
            }
        }
    }
}
