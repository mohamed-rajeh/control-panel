using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Dashboard.formwindow
{
    public partial class Add_services : Form
    {

        public Add_services()
        {
            InitializeComponent();
            //***************************************************//
            // get all categries into the comboBox
            List<Category> categories = CategoryController.GetAllcategorys();
            cmb_cat.Items.AddRange(categories.ToArray());
            // cmb_cat.Text = _service.category.name;
            cmb_cat.ValueMember = "id";
            cmb_cat.DisplayMember = "name";
            //to select the currnt catagry 
            cmb_cat.SelectedItem = categories[0];

        }

        private void but_block_Click(object sender, EventArgs e)
        {
            chack_empty(); // your fuction s
            chack_not_empty();  // your fuction s

            // get data from fields into a service object
            Service service = new Service(
                null ,
                txt_name_service.Text,
                cmb_cat.SelectedItem as Category,
                Txt_price.Text,
                chbox_available.Checked,
                txt_desc.Text,
                Txt_Details.Text
                ) ;
            int id = ServiceContrller.InsertService(service); // inssert data
            if (id > 0)
            {
                MessageBox.Show("Service added");
                Close();
            }
            else
                MessageBox.Show("inserting is field");
            
            
            
            
            
            //MessageBox.Show("تمت الاضافة");
            ///
            /// soheb 
            ///
            //List<Service> Add_class_service = new List<Service>();
            ////Add_class_service.Add(new Service(Txt_name_service.Text,
            ////                                          null, Txt_price.Text,
            ////                                            Txt_Descrip.Text,
            ////                                              checkBox1.Checked));

        }

        void chack_not_empty()
        {
            if (txt_name_service.Text != "")
            {
                label_name_empty.Visible = false;
                Txt_price.Focus();
            }
            if (Txt_price.Text != "")
            {
                label_price_empty.Visible = false;
                txt_name_service.Focus();
            }
            if (cmb_cat.Text != "")
            {
                label_cotg_empty.Visible = false;
                cmb_cat.Focus();
            }
        }
        void chack_empty()
        {
            if (txt_name_service.Text == "")
            {
                label_name_empty.Visible = true;
                Txt_price.Focus();
            }
            if (Txt_price.Text == "")
            {
                label_price_empty.Visible = true;
                txt_name_service.Focus();
            }
            if (cmb_cat.Text == "")
            {
                label_cotg_empty.Visible = true;
                cmb_cat.Focus();
            }
        }

        private  void Add_picture_ClickAsync(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Title = "Open Image";
            f.Filter = "All Images (*.png;*.jpg;*.bmp)|*.png;*.jpg;*.bmp";

            if (f.ShowDialog() == DialogResult.OK)
            {
                
                img_service.Image = Image.FromFile(f.FileName);
                _ = upimgAsync(f.FileName);

               
            }
        }

        async Task upimgAsync(string img)
        {
            MessageBox.Show(img);

            string apiUrl = "https://localhost/ser/uploud_img.php";

            var client = new HttpClient();
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri(apiUrl);
            request.Method = HttpMethod.Post;
            request.Headers.Add("Accept", "*/*");
            request.Headers.Add("User-Agent", "Thunder Client (https://www.thunderclient.com)");
            var content = new MultipartFormDataContent();
            content.Add(new ByteArrayContent(File.ReadAllBytes(img)), "file", "picture");
            request.Content = content;
            MessageBox.Show("b clint");

            var response = await client.SendAsync(request);
            MessageBox.Show(response.ToString());

            var result = await response.Content.ReadAsStringAsync();
            MessageBox.Show(result);

        }
    }
}
