using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class PN_provider : UserControl
    {
        
        public PN_provider( )
        {
            InitializeComponent();
        }



        #region Properties

        private Provider _worker;

        private Image _picture;

        [Category("Custom Props")]
        public Provider worker
        {
            get { return _worker; }
            set { _worker = value; lpl_worker.Text = value.Name; }

        }

        [Category("Custom Props")]
        public Image picture
        {
            get { return _picture; }
            set { _picture = value; picture_worker.Image = value; }
        }

        #endregion

        private void pro_control_Load(object sender, EventArgs e)
        {
            if (!_worker.Available)
            {
                lpl_worker.ForeColor = Color.Red;
            }
            
        }

        private void picture_user_Click(object sender, EventArgs e)
        {
            provider_details worker_info_form = new provider_details(_worker);
            worker_info_form.Show();

        }
    }
}
