using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace Dashboard
{
    public partial class Form1 : Form
    {
        DatabaseManager dbm = new DatabaseManager();
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();

        }



        private void but_login_user_Click(object sender, EventArgs e)
        {
            string sql = "select * from admin where user_name='" + txt_user_name.Text + "'And password='" + txt_user_pass.Text + "' ";
            dt = dbm.ExecuteSelectQuery(sql);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Form2 form = new Form2();
                form.Show();
                return;
            }

            else if (txt_user_name.Text == "User Name" && txt_user_pass.Text == "Password")
            {
                MessageBox.Show("write user and password");
            }
            else if (txt_user_name.Text == "User Name")
            {
                MessageBox.Show("write user name");
            }
            else if (txt_user_pass.Text == "Password")
            {
                MessageBox.Show("write Password");
            }
            else
            {
                MessageBox.Show("rong");
            }
        }





        private void txt_user_name_Enter(object sender, EventArgs e)
        {
            Panel_line_in_name.Visible = true;
            if (txt_user_name.Text == "User Name")
            {

                txt_user_name.Text = "";

                txt_user_name.ForeColor = Color.Blue;
                //  txt_name.UseSystemPasswordChar
            }
        }

        private void txt_user_name_Validated(object sender, EventArgs e)
        {
            Panel_line_in_name.Visible = false;
            if (txt_user_name.Text == "")
            {

                txt_user_name.Text = "User Name";

                txt_user_name.ForeColor = Color.DarkGray;

            }
        }

        private void txt_user_name_Click(object sender, EventArgs e)
        {

        }

        private void txt_user_pass_Validated(object sender, EventArgs e)
        {
            Panel_line_in_pass.Visible = false;
            if (txt_user_pass.Text == "")
            {
                txt_user_pass.UseSystemPasswordChar = false;

                txt_user_pass.Text = "Password";

                txt_user_pass.ForeColor = Color.DarkGray;
            }
        }

        private void txt_user_pass_Enter(object sender, EventArgs e)
        {
            Panel_line_in_pass.Visible = true;
            if (txt_user_pass.Text == "Password")
            {

                txt_user_pass.Text = "";
                txt_user_pass.UseSystemPasswordChar = true;
                txt_user_pass.ForeColor = Color.Black;

            }
        }

        private void txt_user_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
