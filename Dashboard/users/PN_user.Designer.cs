namespace Dashboard
{
    partial class PN_user
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
            this.components = new System.ComponentModel.Container();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pic_user = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoEllipsis = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_name.Location = new System.Drawing.Point(3, 70);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(98, 20);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "user";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_user
            // 
            this.pic_user.BackColor = System.Drawing.Color.Transparent;
            this.pic_user.BaseColor = System.Drawing.Color.White;
            this.pic_user.Image = global::Dashboard.Properties.Resources.person;
            this.pic_user.InitialImage = global::Dashboard.Properties.Resources.person;
            this.pic_user.Location = new System.Drawing.Point(16, 3);
            this.pic_user.Name = "pic_user";
            this.pic_user.Size = new System.Drawing.Size(70, 65);
            this.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_user.TabIndex = 2;
            this.pic_user.TabStop = false;
            this.pic_user.UseTransfarantBackground = false;
            this.pic_user.Click += new System.EventHandler(this.picture_user_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // PN_user
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pic_user);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(20, 10, 3, 3);
            this.Name = "PN_user";
            this.Size = new System.Drawing.Size(104, 98);
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaCirclePictureBox pic_user;
        private System.Windows.Forms.Label lbl_name;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
