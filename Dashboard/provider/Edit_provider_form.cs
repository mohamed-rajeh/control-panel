using System;
using System.Drawing;
using System.Windows.Forms;
using Dashboard.services;
using System.Collections.Generic;

namespace Dashboard.provider
{
    public partial class Edit_provider_form : Form
    {
       

    
        public Edit_provider_form()
        {
            InitializeComponent();
        }
        public Edit_provider_form(Provider provider)
        {

            InitializeComponent();
            setAttribute(provider);
            ProviderController.provider = provider;

        }
        private void setAttribute(Provider provider)
        {
            txt_name.Text = provider.Name;
            txt_idcard.Text = provider.IdCard;
            txt_phone.Text = provider.Phone;
            txt_note.Text = provider.Note;

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
        






        private void but_addres_form_Click(object sender, EventArgs e)
        {
            Add_addres_form add_addres_form = new Add_addres_form(ProviderController.provider.Address);
            add_addres_form.Show();
        }

        private void Add_picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Title = "open images";
            f.Filter = "ALL Images |*.PNG; *.jpg; *.BMB";
            if (f.ShowDialog() == DialogResult.OK)
            {
                img_picure.Image = Image.FromFile(f.FileName);
            }
        }

        private void but_block_Click(object sender, EventArgs e)
        {
            update();

        }
        private void update()
        {
            ProviderController.provider.Name = txt_name.Text;
            ProviderController.provider.Phone = txt_phone.Text;
            ProviderController.provider.Note = txt_note.Text;
            ProviderController.provider.IdCard = txt_idcard.Text;
            if(ProviderController.UpdateProvider(ProviderController.provider) > 0)
            {
                MessageBox.Show("Updated successfully ^^ ");
                this.Close();
                provider_details providerd = new provider_details(ProviderController.provider);
                providerd.Show();
            }
            else
            {

                MessageBox.Show("Updating Feild *_* ");
            }

        }
    }
}
