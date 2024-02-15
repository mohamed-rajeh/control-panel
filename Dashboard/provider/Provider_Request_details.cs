using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.provider
{
    public partial class Provider_Request_details : Form
    {
        ProviderRequest _Request;
        public Provider_Request_details(ProviderRequest Request)
        {
            InitializeComponent();
            _Request = Request;

            setAttribute(Request);
        }

        private void setAttribute(ProviderRequest request)
        {
            lbl_name.Text = request.name;
            lbl_date.Text = request.date.ToString();
            lbl_idcard.Text = request.id_card;
            lbl_phon.Text = request.phone;

            lbl_service.Text = request.service.name;
            lbl_street.Text = request.addres.street;
            lbl_city.Text = request.addres.city;    
            lbl_address_note.Text = request.addres.address_note;


        }

        private void but_block_Click(object sender, EventArgs e)
        {
            if (but_block.Text == "Accept")
            {
                if (MessageBox.Show("Do you want to accept this provider ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    but_block.Image = Properties.Resources.Ok_48px;
                    but_block.Text = "Accepted";
                    but_block.OnHoverBaseColor = Color.Green;
                    but_block.BaseColor = Color.Green;

                    return;
                }
            }
            if (but_block.Text == "Accepted")
            {
                if (MessageBox.Show("Do you want to Cancel this provider ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    but_block.Image = Properties.Resources.Add_64px;
                    but_block.Text = "Accept";
                    but_block.OnHoverBaseColor = Color.CornflowerBlue;
                    but_block.BaseColor = Color.CornflowerBlue;

                    return;
                }
            }
        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Provider provider = new Provider(
                id: null,
                name: _Request.name,
                address: _Request.addres,
                phone: _Request.phone,
                picture: _Request.picuter,
                idCard: _Request.id_card,
                available: true,
                note: null
               );
            int providerId = ProviderController.InsertProvider(provider); // save  a provider 
            if (providerId > 0) {
                provider.Id = providerId.ToString(); // set the id of provider that we saved
                ProviderServiceController.InsertPS(provider.Id, _Request.service.id, null); // we saved a provders service
                if (ProviderRequestController.deleteProviderRequest(_Request.id) > 0) // remove requst after save a prvider
                {
                    MessageBox.Show("Reqest Accepted");
                    
                    this.Close();
                    provider_details provider_d = new provider_details(provider); // pass the new privider to from
                    provider_d.Show(); // show details for the provider ^^


                }
                else
                    MessageBox.Show("Field to remove the requst");
            }
            else
            {
                MessageBox.Show("Some thing Wrong ,Acceptance failed  *_* ");
            }
        }
    }
}


