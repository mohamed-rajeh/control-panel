namespace Dashboard.provider
{
    partial class Add_addres_form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.but_block = new Guna.UI.WinForms.GunaButton();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.Txt_city = new Guna.UI.WinForms.GunaTextBox();
            this.txt_street = new Guna.UI.WinForms.GunaTextBox();
            this.txt_not = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Panel_username = new Guna.UI.WinForms.GunaElipsePanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lebl_address = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipsePanel2.SuspendLayout();
            this.Panel_username.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_block
            // 
            this.but_block.AnimationHoverSpeed = 0.07F;
            this.but_block.AnimationSpeed = 0.03F;
            this.but_block.BackColor = System.Drawing.Color.Transparent;
            this.but_block.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.but_block.BorderColor = System.Drawing.Color.Black;
            this.but_block.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_block.DialogResult = System.Windows.Forms.DialogResult.None;
            this.but_block.FocusedColor = System.Drawing.Color.Empty;
            this.but_block.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.but_block.ForeColor = System.Drawing.Color.Black;
            this.but_block.Image = global::Dashboard.Properties.Resources.Addd_64px;
            this.but_block.ImageSize = new System.Drawing.Size(20, 20);
            this.but_block.Location = new System.Drawing.Point(397, 371);
            this.but_block.Name = "but_block";
            this.but_block.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.but_block.OnHoverBorderColor = System.Drawing.Color.Black;
            this.but_block.OnHoverForeColor = System.Drawing.Color.White;
            this.but_block.OnHoverImage = null;
            this.but_block.OnPressedColor = System.Drawing.Color.Black;
            this.but_block.Radius = 12;
            this.but_block.Size = new System.Drawing.Size(124, 43);
            this.but_block.TabIndex = 95;
            this.but_block.Text = "Save";
            this.but_block.Click += new System.EventHandler(this.but_block_Click);
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaElipsePanel2.Controls.Add(this.Txt_city);
            this.gunaElipsePanel2.Controls.Add(this.txt_street);
            this.gunaElipsePanel2.Controls.Add(this.txt_not);
            this.gunaElipsePanel2.Controls.Add(this.label8);
            this.gunaElipsePanel2.Controls.Add(this.label9);
            this.gunaElipsePanel2.Controls.Add(this.label2);
            this.gunaElipsePanel2.Controls.Add(this.label6);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(29, 60);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Size = new System.Drawing.Size(492, 293);
            this.gunaElipsePanel2.TabIndex = 100;
            // 
            // Txt_city
            // 
            this.Txt_city.BaseColor = System.Drawing.Color.White;
            this.Txt_city.BorderColor = System.Drawing.Color.Silver;
            this.Txt_city.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_city.FocusedBaseColor = System.Drawing.Color.White;
            this.Txt_city.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_city.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Txt_city.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Txt_city.Location = new System.Drawing.Point(132, 22);
            this.Txt_city.Multiline = true;
            this.Txt_city.Name = "Txt_city";
            this.Txt_city.PasswordChar = '\0';
            this.Txt_city.SelectedText = "";
            this.Txt_city.Size = new System.Drawing.Size(243, 40);
            this.Txt_city.TabIndex = 104;
            this.Txt_city.Text = "City";
            this.Txt_city.Enter += new System.EventHandler(this.Txt_city_Enter);
            this.Txt_city.Validated += new System.EventHandler(this.Txt_city_Validated);
            // 
            // txt_street
            // 
            this.txt_street.BaseColor = System.Drawing.Color.White;
            this.txt_street.BorderColor = System.Drawing.Color.Silver;
            this.txt_street.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_street.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_street.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_street.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_street.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txt_street.Location = new System.Drawing.Point(132, 80);
            this.txt_street.Multiline = true;
            this.txt_street.Name = "txt_street";
            this.txt_street.PasswordChar = '\0';
            this.txt_street.SelectedText = "";
            this.txt_street.Size = new System.Drawing.Size(243, 40);
            this.txt_street.TabIndex = 103;
            this.txt_street.Text = "Street";
            this.txt_street.Enter += new System.EventHandler(this.txt_street_Enter);
            this.txt_street.Validated += new System.EventHandler(this.txt_street_Validated);
            // 
            // txt_not
            // 
            this.txt_not.BaseColor = System.Drawing.Color.White;
            this.txt_not.BorderColor = System.Drawing.Color.Silver;
            this.txt_not.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_not.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_not.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_not.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_not.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txt_not.Location = new System.Drawing.Point(125, 148);
            this.txt_not.Multiline = true;
            this.txt_not.Name = "txt_not";
            this.txt_not.PasswordChar = '\0';
            this.txt_not.SelectedText = "";
            this.txt_not.Size = new System.Drawing.Size(343, 112);
            this.txt_not.TabIndex = 102;
            this.txt_not.Text = "Note";
            this.txt_not.Enter += new System.EventHandler(this.txt_not_Enter);
            this.txt_not.Validated += new System.EventHandler(this.txt_not_Validated);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(32, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 24);
            this.label8.TabIndex = 98;
            this.label8.Text = "City ";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(32, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 24);
            this.label9.TabIndex = 96;
            this.label9.Text = "Street ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(32, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 97;
            this.label2.Text = "Note  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 2;
            // 
            // Panel_username
            // 
            this.Panel_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Panel_username.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Panel_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_username.Controls.Add(this.label15);
            this.Panel_username.Controls.Add(this.label4);
            this.Panel_username.Location = new System.Drawing.Point(34, 43);
            this.Panel_username.Name = "Panel_username";
            this.Panel_username.Size = new System.Drawing.Size(117, 6);
            this.Panel_username.TabIndex = 102;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(82, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, -24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 93;
            this.label4.Text = "User Name";
            // 
            // lebl_address
            // 
            this.lebl_address.AutoSize = true;
            this.lebl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.lebl_address.ForeColor = System.Drawing.Color.Black;
            this.lebl_address.Location = new System.Drawing.Point(34, 14);
            this.lebl_address.Name = "lebl_address";
            this.lebl_address.Size = new System.Drawing.Size(109, 29);
            this.lebl_address.TabIndex = 101;
            this.lebl_address.Text = "Address";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 2;
            this.gunaElipse1.TargetControl = this;
            // 
            // Add_addres_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(550, 426);
            this.Controls.Add(this.Panel_username);
            this.Controls.Add(this.lebl_address);
            this.Controls.Add(this.gunaElipsePanel2);
            this.Controls.Add(this.but_block);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_addres_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_addres_form";
            this.Load += new System.EventHandler(this.Add_addres_form_Load);
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaElipsePanel2.PerformLayout();
            this.Panel_username.ResumeLayout(false);
            this.Panel_username.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton but_block;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaElipsePanel Panel_username;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lebl_address;
        protected internal Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaTextBox Txt_city;
        private Guna.UI.WinForms.GunaTextBox txt_street;
        private Guna.UI.WinForms.GunaTextBox txt_not;
    }
}