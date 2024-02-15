using System;
using System.Windows.Forms;

namespace Dashboard.provider
{
    public partial class Add_addres_form : Form
    {
        bool update = false;
        public Add_addres_form(Address address)
        {
            InitializeComponent();

            Txt_city.Text = address.city;
            txt_street.Text = address.street;
            txt_not.Text = address.address_note;
            update = true;


        }
        public Add_addres_form( )
        {
            InitializeComponent();


        }
        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_addres_form_Load(object sender, EventArgs e)
        {

           
        }
        
        private void but_block_Click(object sender, EventArgs e)
        {
          

            if (update)
            {
                updateFunc();
            }
            else
            {
                insertFunc();
            }
            Close();

        }
        void updateFunc()
        {
            if (Txt_city.Text == string.Empty|| txt_street.Text == string.Empty)
            {
                MessageBox.Show("fill address feilds");
                return;
            }
            else
            {
                ProviderController.provider.Address.city = Txt_city.Text;
                ProviderController.provider.Address.street = txt_street.Text;
                ProviderController.provider.Address.address_note = txt_not.Text;
               if( AddressController.Updateaddress(ProviderController.provider.Address) > 0)
                {
                    MessageBox.Show("update sucesfuly ^^");
                }
                else
                {
                     MessageBox.Show("update Feild *_*");

                };

            }
        }
        void insertFunc()
        {
            if (Txt_city.Text == "City" && txt_street.Text == "Street" && txt_not.Text == "Note")
            {
                MessageBox.Show("ادخل عنوانك من فضلك");
                return;
            }
            if (Txt_city.Text == "City")
            {
                MessageBox.Show("ادخل اسم المدينة من فضلك");
                return;
            }
            if (txt_street.Text == "Street")
            {
                MessageBox.Show("ادخل اسم الشارع من فضلك");
                return;
            }
            if (txt_not.Text == "Note")
            {
                MessageBox.Show("ادخل الملاحظة من فضلك");
                return;
            }
            else
            {
                AddressController.address = new Address(null, Txt_city.Text, txt_street.Text, txt_not.Text);

                int id = AddressController.Insertaddress(AddressController.address);
                if (id > 0)
                {
                    AddressController.address.id = id.ToString();
                    MessageBox.Show("تمت اضافة العنوان");
                }
                else
                {
                    MessageBox.Show("Inserting Feild *_*");

                }
            }
        }
       
        private void Txt_city_Enter(object sender, EventArgs e)
        {
            if (Txt_city.Text == "City")
            {
                Txt_city.Text = "";
            }
        }
        private void Txt_city_Validated(object sender, EventArgs e)
        {
            if (Txt_city.Text == "")
            {
                Txt_city.Text = "City";
            }
        }
        private void txt_street_Enter(object sender, EventArgs e)
        {
            if (txt_street.Text == "Street")
            {
                txt_street.Text = "";
            }
        }
        private void txt_street_Validated(object sender, EventArgs e)
        {
            if (txt_street.Text == "")
            {
                txt_street.Text = "Street";
            }
        }
        private void txt_not_Enter(object sender, EventArgs e)
        {
            if (txt_not.Text == "Note")
            {
                txt_not.Text = "";
            }
        }

        private void txt_not_Validated(object sender, EventArgs e)
        {
            if (txt_not.Text == "")
            {
                txt_not.Text = "Note";
            }
        }

      
    }
}
