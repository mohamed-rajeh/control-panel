using System;
using System.Windows.Forms;
using System.Drawing;


namespace Dashboard
{
    public partial class User_information_form : Form
    {
        User user;
        public User_information_form(User _user)
        {
            InitializeComponent();
            user = _user;
        }
   
        private void Client_information_form_Load(object sender, EventArgs e)
        {
            Panel_username.Width = txt_username.Width;
            Panel_phone.Width = label_phone.Width;
            txt_username.Text = user.Name;
            label_phone.Text = user.Phone;
            label_city.Text = user.Address.city;
            lbl_street.Text = user.Address.street;
            lbl_note.Text = user.Address.address_note;
            label_date.Text = user.Date.ToString();

            if (user.Availbale)
            {
                but_block.Image = Properties.Resources.Ok_48px;
                but_block.OnHoverBaseColor = Color.Green;
                but_block.Text = "active";

                but_block.BaseColor = Color.Green;

            }
            else
            {
                but_block.Image = Properties.Resources.Cancel_48px;
                but_block.Text = "blocked";
                //but_block.BaseColor = Color.Red;

                but_block.OnHoverBaseColor = Color.Red;
                but_block.BaseColor = Color.Red;
            }
            if (user.Gender == true)
            {
                Radio_Man.Checked = true;
            }
            else
            {
                Radio_Woman.Checked = true;
            }
           // but_active_blocked();
        }
       
        private void but_block_Click(object sender, EventArgs e)
        {     
            but_active_blocked();
      
        } 

        void but_active_blocked()
        {
            if (but_block.Text == "blocked")
            {
                if (MessageBox.Show("Do you want to activate this user?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    UserController.blockOrActeiveUser(user.Id, true);

                    but_block.Image = Properties.Resources.Ok_48px;
                    but_block.Text = "active";
                    but_block.OnHoverBaseColor = Color.Green;
                    but_block.BaseColor = Color.Green;
                    return;
                }
            }
            if (but_block.Text == "active")
            {
                if (MessageBox.Show("Do you want to block this user?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    UserController.blockOrActeiveUser(user.Id, false);
                    but_block.Image = Properties.Resources.Cancel_48px;
                    but_block.Text = "blocked";
                    but_block.OnHoverBaseColor = Color.Red;
                    but_block.BaseColor = Color.Red;
                    return;
                }
            }
        }
    }
}
