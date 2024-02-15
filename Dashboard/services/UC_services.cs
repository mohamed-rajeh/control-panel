using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class UC_services : UserControl
    {
        public List<Service> services = new List<Service>();
        public UC_services()
        {
            InitializeComponent();

            services.AddRange(ServiceContrller.GetAllServices());

        }


        public void populateItems_service()
        {

            /// get all service and put all PN in a flow panel
            foreach (var ser in services)
            {
                services.PNservice pNservice = new services.PNservice(ser);
                
                flowLayoutPanel1.Controls.Add(pNservice);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_services_Load(object sender, EventArgs e)
        {
            populateItems_service();
            // count of unavailble service ^^
            int unavailbleService = services.FindAll(service => service.available == false).Count;
            servicers_Unavailable_Label.Text =unavailbleService.ToString();
                

        }

        private void but_add_Click(object sender, EventArgs e)
        {
            formwindow.Add_services add_service = new formwindow.Add_services();
            add_service.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //N12345678
        }

        private void text_service_search_Enter(object sender, EventArgs e)
        {
            if (text_service_search.Text == "search")
            {
                text_service_search.Text = "";

                text_service_search.ForeColor = Color.Black;
            }
        }

        private void text_service_search_Leave(object sender, EventArgs e)
        {
            if (text_service_search.Text == "")
            {
                text_service_search.Text = "search";

                text_service_search.ForeColor = Color.Silver;
            }
        }
    }
}
