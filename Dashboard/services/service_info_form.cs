using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Dashboard.services
{
    public partial class service_info_form : Form
    {
        Service service;
        public service_info_form(Service _service)
        {
            InitializeComponent();
            
            service = _service;

          

            checkBox_Available_service.Checked = _service.available;

            txt_name.Text = _service.name;
            txt_cotg.Text = _service.category.name;
            txt_price.Text = _service.price;
            txt_desc.Text = _service.description;
            txt_details.Text = _service.details;
            checkBox_Available_service.Focus();
            
            //***************************************************//
            // get all categries into the comboBox
            List<Category> categories = CategoryController.GetAllcategorys();
            cmb_cat.Items.AddRange(categories.ToArray()); 
           // cmb_cat.Text = _service.category.name;
            cmb_cat.ValueMember = "id";
            cmb_cat.DisplayMember = "name";
            //to select the currnt catagry 
            cmb_cat.SelectedItem = categories.Find(c => c.id == _service.category.id);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void service_info_form_Load(object sender, EventArgs e)
        {
            checkBox_Available_service.Focus();


        }

        private void Txt_Descrip_service_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void but_block_Click(object sender, EventArgs e)
        {
            if (but_Edit.Text == "Edit")
            {
                if (MessageBox.Show("Do you want to edit this ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                  //  but_Edit.Image = Properties.Resources.Ok_48px;
                    but_Edit.Text = "Sava";
                    but_Edit.OnHoverBaseColor = Color.Green;
                    but_Edit.BaseColor = Color.Green;
                    //   *******************************************
                    txt_name.BorderColor = System.Drawing.Color.Silver;
                    txt_name.FocusedBorderColor = System.Drawing.Color.Silver;
                    txt_name.ReadOnly = false;

                    txt_price.ReadOnly = false;
                    txt_price.BorderColor = System.Drawing.Color.Silver;
                    txt_price.FocusedBorderColor = System.Drawing.Color.Silver;
                     

                    txt_cotg.Visible = false;
                    txt_cotg.ReadOnly = false;
                    txt_cotg.BorderColor = System.Drawing.Color.Silver;
                    txt_cotg.FocusedBorderColor = System.Drawing.Color.Silver;
                    cmb_cat.Enabled = true;
                    txt_details.ReadOnly = false;
                    txt_details.BorderColor = System.Drawing.Color.Silver;
                    txt_details.FocusedBorderColor = System.Drawing.Color.Silver;

                    checkBox_Available_service.Enabled = true;
                    txt_name.Focus();
                    return;
                }
            }
            if (but_Edit.Text == "Sava")
            {
                if (MessageBox.Show("Do you want to sava this ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    service.name = txt_name.Text;
                    service.price = txt_price.Text;
                    service.details = txt_details.Text;
                    service.description = txt_desc.Text;
                    //MessageBox.Show(cmb_cat.SelectedItem.ToString());
                    service.category = cmb_cat.SelectedItem as Category;
                    service.available = checkBox_Available_service.Checked;
                    if (ServiceContrller.Update(service) != null)
                    {
                        MessageBox.Show("تم التعديل");
                        Close();
                    }else
                    
                        MessageBox.Show("فشل التعديل");
            
                    
                   // but_Edit.Image = Properties.Resources.Cancel_48px;
                    but_Edit.Text = "Edit";
                    but_Edit.OnHoverBaseColor = Color.Blue;
                    but_Edit.BaseColor = Color.Blue;

        
                    return;
                }

            }
           

         
        }

        private void cmb_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            service.category =  cmb_cat.SelectedItem as Category;
        }
    }
}
