using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Dashboard
{
    
    public partial class provider_details : Form
    {
       
        public provider_details(Provider provider )
        {
            InitializeComponent();
           // provider = provider ?? throw new ArgumentNullException( nameof( provider ) );
           ProviderController.provider = provider;    

            txt_name.Text = provider.Name;
            txt_phone.Text = provider.Phone;
            txt_city.Text = provider.Address.city;
            txt_street.Text = provider.Address.street;
            txt_address_note.Text = provider.Address.address_note;
            txt_note.Text= provider.Note;
            
            if(provider.Available)
            {
                but_block.Text = "active";
            }
            else
            {
                but_block.Text = "unactive";
            }

            // set data to combo box 
            cmb_service.Items.Clear();
            // get all service for this provider
            List<Service> list = ProviderServiceController.getServicesByProvoder(provider.Id);
            if (list != null)
            {
                cmb_service.DataSource = list;
                // set the name as  display item 
                cmb_service.DisplayMember = "name";
                //set the id to be a value
                cmb_service.ValueMember = "id";

                cmb_service.SelectedIndex = 0;
            }
          


        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
          
        }

      
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void but_block_Click(object sender, EventArgs e)
        {
            if (but_block.Text == "unactive")
            {
                if (MessageBox.Show("Do you want to activate this user?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    but_block.Image = Properties.Resources.Ok_48px;
                    but_block.Text = "active";
                    but_block.OnHoverBaseColor = Color.Green;
                    but_block.BaseColor = Color.Green;
                    ProviderController.provider.Available = true;
                    ProviderController.UpdateProvider(ProviderController.provider);
                    return;
                }
            }
            if (but_block.Text == "active")
            {
                if (MessageBox.Show("Do you want to Unactivate this user?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    but_block.Image = Properties.Resources.Cancel_48px;
                    but_block.Text = "unactive";
                    but_block.OnHoverBaseColor = Color.Red;
                    but_block.BaseColor = Color.Red;
                    ProviderController.provider.Available = false;
                    ProviderController.UpdateProvider(ProviderController.provider);
                    return;
                }
            }
        }
        private void worker_information_form_Load(object sender, EventArgs e)
        {
            if (but_block.Text == "active")
            {
                but_block.Image = Properties.Resources.Ok_48px;
                but_block.OnHoverBaseColor = Color.Green;

                but_block.BaseColor = Color.Green;
                return;

            }
            if (but_block.Text == "unactive")
            {

                but_block.Image = Properties.Resources.Cancel_48px;
                but_block.OnHoverBaseColor = Color.Red;
                but_block.BaseColor = Color.Red;
                return;

            }

        }

        private void but_Edit_Click(object sender, EventArgs e)
        {

            provider.Edit_provider_form add_worker_form = new provider.Edit_provider_form(ProviderController.provider);
            this.Close();
            add_worker_form.Show();
        }
    }
}
