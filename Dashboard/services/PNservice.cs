using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Dashboard.services
{
    public partial class PNservice : UserControl
    {
        Service _service;
        public PNservice(Service service)
        {
            InitializeComponent();
            lbl_service.Text = service.name;
            if(!service.available) lbl_service.ForeColor = Color.Red;
            _service = service;
        }

        private void picture_service_Click(object sender, EventArgs e)
        {
            service_info_form _Info_Form = new service_info_form(_service);
            _Info_Form.ShowDialog();
        }

        private void PNservice_Load(object sender, EventArgs e)
        {

        }

        private void lbl_service_Click(object sender, EventArgs e)
        {

        }
    }
}
