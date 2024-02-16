namespace Dashboard.services
{
    partial class service_details
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
            this.pic_photo = new System.Windows.Forms.PictureBox();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.cmb_cat = new System.Windows.Forms.ComboBox();
            this.txt_name = new Guna.UI.WinForms.GunaTextBox();
            this.txt_desc = new Guna.UI.WinForms.GunaTextBox();
            this.txt_price = new Guna.UI.WinForms.GunaTextBox();
            this.but_Edit = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.txt_details = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_Available_service = new Guna.UI.WinForms.GunaMediumCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_photo)).BeginInit();
            this.gunaElipsePanel2.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_photo
            // 
            this.pic_photo.Enabled = false;
            this.pic_photo.Image = global::Dashboard.Properties.Resources.Automation_48px;
            this.pic_photo.Location = new System.Drawing.Point(271, 4);
            this.pic_photo.Name = "pic_photo";
            this.pic_photo.Size = new System.Drawing.Size(72, 66);
            this.pic_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_photo.TabIndex = 59;
            this.pic_photo.TabStop = false;
            this.pic_photo.Click += new System.EventHandler(this.pic_photo_Click);
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaElipsePanel2.Controls.Add(this.cmb_cat);
            this.gunaElipsePanel2.Controls.Add(this.txt_name);
            this.gunaElipsePanel2.Controls.Add(this.txt_desc);
            this.gunaElipsePanel2.Controls.Add(this.txt_price);
            this.gunaElipsePanel2.Controls.Add(this.but_Edit);
            this.gunaElipsePanel2.Controls.Add(this.gunaGroupBox1);
            this.gunaElipsePanel2.Controls.Add(this.label3);
            this.gunaElipsePanel2.Controls.Add(this.checkBox_Available_service);
            this.gunaElipsePanel2.Controls.Add(this.label1);
            this.gunaElipsePanel2.Controls.Add(this.label11);
            this.gunaElipsePanel2.Controls.Add(this.label7);
            this.gunaElipsePanel2.Controls.Add(this.label9);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(37, 74);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Size = new System.Drawing.Size(557, 552);
            this.gunaElipsePanel2.TabIndex = 74;
            // 
            // cmb_cat
            // 
            this.cmb_cat.Enabled = false;
            this.cmb_cat.FormattingEnabled = true;
            this.cmb_cat.Location = new System.Drawing.Point(125, 103);
            this.cmb_cat.Name = "cmb_cat";
            this.cmb_cat.Size = new System.Drawing.Size(121, 21);
            this.cmb_cat.TabIndex = 110;
            this.cmb_cat.SelectedIndexChanged += new System.EventHandler(this.cmb_cat_SelectedIndexChanged);
            // 
            // txt_name
            // 
            this.txt_name.BaseColor = System.Drawing.Color.White;
            this.txt_name.BorderColor = System.Drawing.Color.Transparent;
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_name.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.txt_name.FocusedForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txt_name.Location = new System.Drawing.Point(125, 17);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.ReadOnly = true;
            this.txt_name.SelectedText = "";
            this.txt_name.Size = new System.Drawing.Size(211, 38);
            this.txt_name.TabIndex = 109;
            this.txt_name.Text = "name";
            // 
            // txt_desc
            // 
            this.txt_desc.BaseColor = System.Drawing.Color.White;
            this.txt_desc.BorderColor = System.Drawing.Color.Transparent;
            this.txt_desc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_desc.FocusedBaseColor = System.Drawing.Color.Transparent;
            this.txt_desc.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.txt_desc.FocusedForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_desc.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txt_desc.Location = new System.Drawing.Point(149, 212);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.PasswordChar = '\0';
            this.txt_desc.ReadOnly = true;
            this.txt_desc.SelectedText = "";
            this.txt_desc.Size = new System.Drawing.Size(345, 38);
            this.txt_desc.TabIndex = 108;
            this.txt_desc.Text = "a short desc";
            // 
            // txt_price
            // 
            this.txt_price.BaseColor = System.Drawing.Color.White;
            this.txt_price.BorderColor = System.Drawing.Color.Transparent;
            this.txt_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_price.FocusedBaseColor = System.Drawing.Color.Transparent;
            this.txt_price.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.txt_price.FocusedForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_price.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txt_price.Location = new System.Drawing.Point(125, 154);
            this.txt_price.Multiline = true;
            this.txt_price.Name = "txt_price";
            this.txt_price.PasswordChar = '\0';
            this.txt_price.ReadOnly = true;
            this.txt_price.SelectedText = "";
            this.txt_price.Size = new System.Drawing.Size(211, 38);
            this.txt_price.TabIndex = 108;
            this.txt_price.Text = "price";
            // 
            // but_Edit
            // 
            this.but_Edit.AnimationHoverSpeed = 0.07F;
            this.but_Edit.AnimationSpeed = 0.03F;
            this.but_Edit.BackColor = System.Drawing.Color.Transparent;
            this.but_Edit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.but_Edit.BorderColor = System.Drawing.Color.Black;
            this.but_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_Edit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.but_Edit.FocusedColor = System.Drawing.Color.Empty;
            this.but_Edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.but_Edit.ForeColor = System.Drawing.Color.Black;
            this.but_Edit.Image = global::Dashboard.Properties.Resources.Worker_Male_40px;
            this.but_Edit.ImageSize = new System.Drawing.Size(20, 20);
            this.but_Edit.Location = new System.Drawing.Point(43, 476);
            this.but_Edit.Name = "but_Edit";
            this.but_Edit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.but_Edit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.but_Edit.OnHoverForeColor = System.Drawing.Color.White;
            this.but_Edit.OnHoverImage = null;
            this.but_Edit.OnPressedColor = System.Drawing.Color.Black;
            this.but_Edit.Radius = 12;
            this.but_Edit.Size = new System.Drawing.Size(124, 43);
            this.but_Edit.TabIndex = 86;
            this.but_Edit.Text = "Edit";
            this.but_Edit.Click += new System.EventHandler(this.but_block_Click);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Black;
            this.gunaGroupBox1.Controls.Add(this.txt_details);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(23, 296);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(471, 174);
            this.gunaGroupBox1.TabIndex = 107;
            this.gunaGroupBox1.Text = "Details";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(5, 3);
            // 
            // txt_details
            // 
            this.txt_details.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txt_details.BorderColor = System.Drawing.Color.Transparent;
            this.txt_details.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_details.FocusedBaseColor = System.Drawing.Color.Transparent;
            this.txt_details.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.txt_details.FocusedForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_details.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txt_details.Location = new System.Drawing.Point(3, 32);
            this.txt_details.Multiline = true;
            this.txt_details.Name = "txt_details";
            this.txt_details.PasswordChar = '\0';
            this.txt_details.ReadOnly = true;
            this.txt_details.SelectedText = "";
            this.txt_details.Size = new System.Drawing.Size(465, 139);
            this.txt_details.TabIndex = 109;
            this.txt_details.Text = "Details\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(384, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 26);
            this.label3.TabIndex = 84;
            this.label3.Text = "Available";
            // 
            // checkBox_Available_service
            // 
            this.checkBox_Available_service.BaseColor = System.Drawing.Color.White;
            this.checkBox_Available_service.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkBox_Available_service.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkBox_Available_service.Enabled = false;
            this.checkBox_Available_service.FillColor = System.Drawing.Color.White;
            this.checkBox_Available_service.Location = new System.Drawing.Point(359, 487);
            this.checkBox_Available_service.Name = "checkBox_Available_service";
            this.checkBox_Available_service.Size = new System.Drawing.Size(20, 20);
            this.checkBox_Available_service.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(18, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 26);
            this.label1.TabIndex = 43;
            this.label1.Text = "Desciption :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label11.Location = new System.Drawing.Point(18, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 26);
            this.label11.TabIndex = 3;
            this.label11.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label7.Location = new System.Drawing.Point(18, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 26);
            this.label7.TabIndex = 43;
            this.label7.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label9.Location = new System.Drawing.Point(18, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 26);
            this.label9.TabIndex = 43;
            this.label9.Text = "Cotg";
            // 
            // service_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(649, 653);
            this.Controls.Add(this.gunaElipsePanel2);
            this.Controls.Add(this.pic_photo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "service_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "service information";
            this.Load += new System.EventHandler(this.service_info_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_photo)).EndInit();
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaElipsePanel2.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_photo;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaMediumCheckBox checkBox_Available_service;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaButton but_Edit;
        private Guna.UI.WinForms.GunaTextBox txt_name;
        private Guna.UI.WinForms.GunaTextBox txt_price;
        private Guna.UI.WinForms.GunaTextBox txt_details;
        private System.Windows.Forms.ComboBox cmb_cat;
        private Guna.UI.WinForms.GunaTextBox txt_desc;
        private System.Windows.Forms.Label label1;
    }
}
