using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace Dashboard
{
    public partial class frm_login : Form
    {
        DatabaseManager dbm = new DatabaseManager();
        DataTable dt = new DataTable();
        public frm_login()
        {
            InitializeComponent();

        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            string sql = "select * from admin where user_name='" + txt_uerName.Text + "'And password='" + txt_pass.Text + "' ";
            dt = dbm.ExecuteSelectQuery(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                Admin.AdminName = row["name"].ToString();
                this.Hide();
                Home form = new Home();
                form.Show();
                return;
            } 
            else
            {
                MessageBox.Show("user name or password is wrong *_*");
            }
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.RedClose;

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.close;

        }

        private void txt_uerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_uerName.Text.Trim() != String.Empty)
            {
                txt_pass.Focus();
            }
        }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_pass.Text.Trim() != String.Empty)
            {
                btn_login_Click(sender, e);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            txt_uerName.Focus();
        }
    }
}
