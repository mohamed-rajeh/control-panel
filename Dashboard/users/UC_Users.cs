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
        List<User> userList = new List<User>();


        public UC_Users()
        {
            InitializeComponent();

            //fetch data 
            userList.AddRange(UserController.getAllUsers());
           
        }

        private void UC_Users_Load(object sender, EventArgs e)
        {
            try
            {
                //getData(dt);
                populateItems();
                Users_Label1.Text = userList.Count.ToString();  // to show count of users ^^
                // to get blocked users ^^
                user_Unavailable_Label.Text = userList.FindAll(user => user.Availbale ==false).Count.ToString();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void getData(DataTable myDataTable)
        {
            // Iterate through each row of the DataTable and create Class_User objects
            foreach (DataRow row in myDataTable.Rows)
            {
                // Extract values from the row based on column names, assuming they match Class_User properties
                string id = row["id"].ToString();
                string name = row["name"].ToString();
                string phone = row["phone"].ToString();
                DateTime date = Convert.ToDateTime(row["date"]);
                bool gender = Convert.ToBoolean(row["gender"]);
                string password = row["password"].ToString();
                string address = row["address"].ToString();
                string street = row["street"].ToString();
                string city = row["city"].ToString();
                string note = row["note"].ToString();
                bool availbale = Convert.ToBoolean(row["available"]);
                Address address1 = new Address("", city, street, note);


                // Create a new Class_User object with the extracted values
                User user = new User(id, name, phone, date, gender, password, address1, availbale);

                //  Add the created user object to the list
                userList.Add(user);
            }
        }

        private void populateItems()//populate it here 
        {

           foreach(var user in userList)
            {
                PN_user pN_User= new PN_user(user);

                flowLayoutPanel_user.Controls.Add(pN_User);
            }
        }
        private void text_user_search_Enter(object sender, EventArgs e)
        {
            if (text_user_search.Text == "search")
            {
                text_user_search.Text = "";

                text_user_search.ForeColor = Color.Black;
            }
        }

        private void text_user_search_Leave(object sender, EventArgs e)
        {
            if (text_user_search.Text == "")
            {
                text_user_search.Text = "search";

                text_user_search.ForeColor = Color.Silver;
            }
        }
    }

}
