using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class UC_services : UserControl
    {
        public List<Service> _services = new List<Service>();
        public UC_services()
        {
            InitializeComponent();

            _services.AddRange(ServiceContrller.GetAllServices());

        }


        private void addServcie(List<Service> services)
        {

            flowLayoutPanel1.Controls.Clear();
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
            addServcie(_services);
            // count of unavailble service ^^
            int unavailbleService = _services.FindAll(service => service.available == false).Count;
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





        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            List<Service> services = _services.FindAll(service => service.id.Contains(txt_search.Text) ||
                                                                 service.name.ToLower().Contains(txt_search.Text) ||
                                                                 service.description.ToLower().Contains(txt_search.Text) ||
                                                                 service.category.name.ToLower().Contains(txt_search.Text));
            addServcie(services);
        }
    }
}
