using System;
using System.Drawing;
using System.Windows.Forms;
using Dashboard.services;
using System.Collections.Generic;

namespace Dashboard.provider
{
    public partial class Add_provider_form : Form
    {
        public Add_provider_form()
        {
            InitializeComponent();
        }

        private void setAttribute(Provider provider)
        {
            txt_name.Text = provider.Name;
            txt_idcard.Text = provider.IdCard;
            txt_phone.Text = provider.Phone;
            txt_note.Text = provider.Note;



        }
        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void but_addres_form_Click_1(object sender, EventArgs e)
        {
            Add_addres_form add_addres_form = new Add_addres_form();
            add_addres_form.Show();
        }

        private void Add_picture_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Title = "open images";
            f.Filter = "ALL Images |*.PNG; *.jpg; *.BMB";
            if (f.ShowDialog() == DialogResult.OK)
            {
                img_picure.Image = Image.FromFile(f.FileName);
            }
        }

        private void but_new_service_Click(object sender, EventArgs e)
        {
            
        }

        private void but_block_Click(object sender, EventArgs e)
        {
            Address address = AddressController.address;
            ProviderController.provider = new Provider(
                null ,
                txt_name.Text ,
                address,
                txt_phone.Text,
                null,
                txt_idcard.Text,
                true,
                txt_note.Text
                );

            int id = ProviderController.InsertProvider(ProviderController.provider);
            if (id > 0)
            {
                ProviderController.provider.Id = id.ToString();
                MessageBox.Show("تمت اضافة العنوان");
            }
            else
            {
                MessageBox.Show("Inserting Feild *_*");

            }
            Close();
        }
    }
}
