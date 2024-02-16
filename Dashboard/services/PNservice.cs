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
            // get photo from wep
            if(!string.IsNullOrEmpty(service.photo))
            ServerController.DownloadAndDisplayImage(service.photo, pic_photo);
        }

  

        private void pic_photo_Click(object sender, EventArgs e)
        {
            service_details _Info_Form = new service_details(_service);
            _Info_Form.ShowDialog();
        }
    }
}
