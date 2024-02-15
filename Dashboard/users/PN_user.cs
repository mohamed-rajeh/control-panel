using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class PN_user : UserControl
    {
        User _user;
        public PN_user(User user)
        {
            InitializeComponent();
            _user = user;
            lbl_name.Text = _user.Name;
            if(!user.Availbale) lbl_name.ForeColor = Color.Red;   
        }




        private void picture_user_Click(object sender, EventArgs e)
        {
            User_information_form Client_information = new User_information_form(_user);
            Client_information.Show();
        }

        private void PN_user_Load(object sender, EventArgs e)
        {
            pic_user.Image = _user.Gender ? Properties.Resources.male : Properties.Resources.fmale;
        }
    }
}
