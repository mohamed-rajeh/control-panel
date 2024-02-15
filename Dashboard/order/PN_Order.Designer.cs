namespace Dashboard.order
{
    partial class PN_Order
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PN_Order));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_order_date = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_state = new System.Windows.Forms.Label();
            this.lbl_custmor_name = new System.Windows.Forms.Label();
            this.lbl_service_nme = new System.Windows.Forms.Label();
            this.pic_order = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_order)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_order_date);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbl_state);
            this.panel1.Controls.Add(this.lbl_custmor_name);
            this.panel1.Controls.Add(this.lbl_service_nme);
            this.panel1.Controls.Add(this.pic_order);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 69);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_order_date
            // 
            this.lbl_order_date.AutoEllipsis = true;
            this.lbl_order_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_date.ForeColor = System.Drawing.Color.Black;
            this.lbl_order_date.Location = new System.Drawing.Point(572, 23);
            this.lbl_order_date.Name = "lbl_order_date";
            this.lbl_order_date.Size = new System.Drawing.Size(166, 22);
            this.lbl_order_date.TabIndex = 51;
            this.lbl_order_date.Text = "date_time";
            this.lbl_order_date.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbl_order_date.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(3, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 3);
            this.panel2.TabIndex = 50;
            // 
            // lbl_state
            // 
            this.lbl_state.AutoEllipsis = true;
            this.lbl_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_state.ForeColor = System.Drawing.Color.Black;
            this.lbl_state.Location = new System.Drawing.Point(776, 22);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(88, 22);
            this.lbl_state.TabIndex = 49;
            this.lbl_state.Text = "state";
            this.lbl_state.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_state.Click += new System.EventHandler(this.label_state_Click);
            // 
            // lbl_custmor_name
            // 
            this.lbl_custmor_name.AutoEllipsis = true;
            this.lbl_custmor_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_custmor_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_custmor_name.Location = new System.Drawing.Point(280, 19);
            this.lbl_custmor_name.Name = "lbl_custmor_name";
            this.lbl_custmor_name.Size = new System.Drawing.Size(264, 26);
            this.lbl_custmor_name.TabIndex = 46;
            this.lbl_custmor_name.Text = "Name";
            this.lbl_custmor_name.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbl_custmor_name.Click += new System.EventHandler(this.label_cname_Click);
            // 
            // lbl_service_nme
            // 
            this.lbl_service_nme.AutoEllipsis = true;
            this.lbl_service_nme.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_service_nme.ForeColor = System.Drawing.Color.Black;
            this.lbl_service_nme.Location = new System.Drawing.Point(62, 19);
            this.lbl_service_nme.Name = "lbl_service_nme";
            this.lbl_service_nme.Size = new System.Drawing.Size(182, 26);
            this.lbl_service_nme.TabIndex = 44;
            this.lbl_service_nme.Text = "service_name";
            this.lbl_service_nme.Click += new System.EventHandler(this.lable_ser_name_order_Click);
            // 
            // pic_order
            // 
            this.pic_order.BaseColor = System.Drawing.Color.White;
            this.pic_order.Image = ((System.Drawing.Image)(resources.GetObject("pic_order.Image")));
            this.pic_order.Location = new System.Drawing.Point(3, 7);
            this.pic_order.Name = "pic_order";
            this.pic_order.Size = new System.Drawing.Size(57, 48);
            this.pic_order.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_order.TabIndex = 0;
            this.pic_order.TabStop = false;
            this.pic_order.UseTransfarantBackground = false;
            this.pic_order.Click += new System.EventHandler(this.pic_order_Click);
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(13, 94);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(886, 41);
            this.panel5.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(804, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 25);
            this.label8.TabIndex = 49;
            this.label8.Text = "State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(632, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 25);
            this.label7.TabIndex = 48;
            this.label7.Text = "Date && Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(433, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Cname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(223, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "Order ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(45, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Service";
            // 
            // PN_Order
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "PN_Order";
            this.Size = new System.Drawing.Size(875, 71);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_order)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCirclePictureBox pic_order;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.Label lbl_custmor_name;
        private System.Windows.Forms.Label lbl_service_nme;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_order_date;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
