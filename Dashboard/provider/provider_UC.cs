using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Dashboard.provider
{
    public partial class provider_UC : UserControl
    {
         List<Provider> providers = new List<Provider>();

        public provider_UC()
        {
            InitializeComponent();
            providers.AddRange(ProviderController.getAllProviders());
            lbl_providers_count.Text = providers.Count.ToString();
            lbl_providers_available.Text = providers.FindAll(provider => provider.Available == true).Count.ToString();
        }
        private void populateItems_worker()
        {
            // worke w = new worke("mo", Image.FromFile("C:\\Users\tehama\\Desktop\\New folder\\photo_2023-01-02_23-38-56.jpg"));

            // work[] worker_name = {work("moha","image/dd.png"),wor };

            //populate it here 
            PN_provider[] PN_Worker = new PN_provider[providers.Count];
            // loop through each itme
            for (int i = 0; i < PN_Worker.Length; i++)
            {
                PN_Worker[i] = new PN_provider();
                PN_Worker[i].worker = providers[i];

                //  pro_control[i].picture= Image.FromFile("C:\\Users\tehama\\Desktop\\New folder\\photo_2023-01-02_23-38-56.jpg");

                //add to flowlayout
                //if (flowLayoutPanel1.Controls.Count >0)
                //{
                //    flowLayoutPanel1.Controls.Clear();
                //}
                //else

                flowLayoutPanel1.Controls.Add(PN_Worker[i]);
            }
        }


        private void UC_worker_Load(object sender, EventArgs e)
        {
            populateItems_worker();
        }



        private void but_add_worker_Click(object sender, EventArgs e)
        {

            Add_provider_form add_worker_form = new Add_provider_form();
            add_worker_form.Show();
        }

        private void but_Request_workers_Click_1(object sender, EventArgs e)
        {
            provider.request_UC list_provider_form = new request_UC();
            list_provider_form.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void text_user_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



        private void text_worker_search_Enter(object sender, EventArgs e)
        {
            if (text_worker_search.Text == "search")
            {
                text_worker_search.Text = "";

                text_worker_search.ForeColor = Color.Black;
            }
        }

        private void text_worker_search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//class worke
//{

//    string name;
//    Image image;
//   public worke(string name, Image image)
//    {
//        this.name = name;
//        this.image = image;
//    }

//}