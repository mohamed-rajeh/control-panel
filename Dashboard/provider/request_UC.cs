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
    public partial class request_UC : Form
    {
        public request_UC()
        {
            InitializeComponent();
        }

        private void list_provider_form_Load(object sender, EventArgs e)
        {
            Add_provider();
        }
        private void Add_provider()
        {

            List<ProviderRequest> requests = new List<ProviderRequest>();
            requests.AddRange(ProviderRequestController.getAllRequests());
            lbl_request.Text = requests.Count.ToString();   

            // loop through each itme
            foreach (var request in requests)
            {
                //   pro_control[i].picture = Image.FromFile("C:\\Users\tehama\\Desktop\\New folder\\photo_2023-01-02_23-38-56.jpg");

                //add to flowlayout
                //if (flowLayoutPanel1.Controls.Count >0)
                //{
                //    flowLayoutPanel1.Controls.Clear();
                //}
                //else
                PN_Request request_info = new PN_Request(request);
               
                flowLayoutPanel1.Controls.Add(request_info);
            }

            }
        }
    }

