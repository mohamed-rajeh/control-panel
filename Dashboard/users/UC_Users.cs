using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Dashboard
{

    public partial class UC_Users : UserControl
    {
        // list of our users 
        List<User> _users = new List<User>();


        public UC_Users()
        {
            InitializeComponent();

            //fetch data 
            _users.AddRange(UserController.getAllUsers());
           
        }

        private void UC_Users_Load(object sender, EventArgs e)
        {
            try
            {
                //getData(dt);
                addUSers(_users);
                lbl_users.Text = _users.Count.ToString();  // to show count of users ^^
                // to get blocked users ^^
                lbl_blockedUsers.Text = _users.FindAll(user => user.Availbale ==false).Count.ToString();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
  
        private void addUSers(List<User> users)//populate it here 
        {
            flowLayoutPanel_user.Controls.Clear();
           foreach(var user in users)
            {
                PN_user pN_User= new PN_user(user);

                flowLayoutPanel_user.Controls.Add(pN_User);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            List<User> users = _users.FindAll(user => user.Id.Contains(txt_search.Text) ||
                                                     user.Name.ToLower().Contains(txt_search.Text) ||
                                                     user.Address.city.ToLower().Contains(txt_search.Text) ||
                                                     user.Phone.Contains(txt_search.Text));
            addUSers(users);
        }
    }

}
