namespace Dashboard
{
    partial class UC_Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Users));
            this.flowLayoutPanel_user = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Elipse_active = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.Panel_users = new Guna.UI.WinForms.GunaGradientPanel();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Users_Label1 = new Guna.UI.WinForms.GunaLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.Panel_blocked = new Guna.UI.WinForms.GunaGradientPanel();
            this.user_Unavailable_Label = new Guna.UI.WinForms.GunaLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Elipse_blocked = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Elipse_user = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            this.Panel_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.Panel_blocked.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_user
            // 
            this.flowLayoutPanel_user.AutoScroll = true;
            this.flowLayoutPanel_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_user.Location = new System.Drawing.Point(77, 102);
            this.flowLayoutPanel_user.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel_user.Name = "flowLayoutPanel_user";
            this.flowLayoutPanel_user.Size = new System.Drawing.Size(688, 366);
            this.flowLayoutPanel_user.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 36);
            this.label1.TabIndex = 47;
            this.label1.Text = "Users";
            // 
            // Elipse_active
            // 
            this.Elipse_active.BorderRadius = 30;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.flowLayoutPanel_user);
            this.panel1.Location = new System.Drawing.Point(161, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 503);
            this.panel1.TabIndex = 65;
            // 
            // txt_search
            // 
            this.txt_search.BorderRadius = 10;
            this.txt_search.BorderThickness = 2;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultText = "";
            this.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Location = new System.Drawing.Point(270, 54);
            this.txt_search.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderText = "Search ... ";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(268, 43);
            this.txt_search.TabIndex = 83;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.gunaElipsePanel1.Controls.Add(this.Panel_users);
            this.gunaElipsePanel1.Controls.Add(this.Panel_blocked);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(297, 50);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 7;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(574, 147);
            this.gunaElipsePanel1.TabIndex = 64;
            // 
            // Panel_users
            // 
            this.Panel_users.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_users.BackgroundImage")));
            this.Panel_users.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_users.Controls.Add(this.guna2CirclePictureBox2);
            this.Panel_users.Controls.Add(this.Users_Label1);
            this.Panel_users.Controls.Add(this.label3);
            this.Panel_users.ForeColor = System.Drawing.Color.Black;
            this.Panel_users.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Panel_users.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Panel_users.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Panel_users.GradientColor4 = System.Drawing.Color.White;
            this.Panel_users.Location = new System.Drawing.Point(56, 25);
            this.Panel_users.Name = "Panel_users";
            this.Panel_users.Quality = 8;
            this.Panel_users.Size = new System.Drawing.Size(165, 94);
            this.Panel_users.TabIndex = 66;
            this.Panel_users.Text = "gunaGradientPanel1";
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.Image = global::Dashboard.Properties.Resources.User_48px;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(12, 13);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(40, 32);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox2.TabIndex = 60;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // Users_Label1
            // 
            this.Users_Label1.AutoSize = true;
            this.Users_Label1.BackColor = System.Drawing.Color.Transparent;
            this.Users_Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Users_Label1.Font = new System.Drawing.Font("Segoe UI Emoji", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.Users_Label1.Location = new System.Drawing.Point(83, 50);
            this.Users_Label1.Name = "Users_Label1";
            this.Users_Label1.Size = new System.Drawing.Size(30, 35);
            this.Users_Label1.TabIndex = 48;
            this.Users_Label1.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(68, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 26);
            this.label3.TabIndex = 33;
            this.label3.Text = "Users";
            // 
            // Panel_blocked
            // 
            this.Panel_blocked.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_blocked.BackgroundImage")));
            this.Panel_blocked.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_blocked.Controls.Add(this.user_Unavailable_Label);
            this.Panel_blocked.Controls.Add(this.label5);
            this.Panel_blocked.Controls.Add(this.guna2CirclePictureBox1);
            this.Panel_blocked.ForeColor = System.Drawing.Color.Black;
            this.Panel_blocked.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Panel_blocked.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Panel_blocked.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Panel_blocked.GradientColor4 = System.Drawing.Color.White;
            this.Panel_blocked.Location = new System.Drawing.Point(351, 25);
            this.Panel_blocked.Name = "Panel_blocked";
            this.Panel_blocked.Quality = 8;
            this.Panel_blocked.Size = new System.Drawing.Size(165, 94);
            this.Panel_blocked.TabIndex = 65;
            this.Panel_blocked.Text = "gunaGradientPanel1";
            // 
            // user_Unavailable_Label
            // 
            this.user_Unavailable_Label.AutoSize = true;
            this.user_Unavailable_Label.BackColor = System.Drawing.Color.Transparent;
            this.user_Unavailable_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_Unavailable_Label.Font = new System.Drawing.Font("Segoe UI Emoji", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.user_Unavailable_Label.Location = new System.Drawing.Point(87, 50);
            this.user_Unavailable_Label.Name = "user_Unavailable_Label";
            this.user_Unavailable_Label.Size = new System.Drawing.Size(30, 35);
            this.user_Unavailable_Label.TabIndex = 48;
            this.user_Unavailable_Label.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(62, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 26);
            this.label5.TabIndex = 35;
            this.label5.Text = "blocked";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::Dashboard.Properties.Resources.user;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(11, 16);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(40, 32);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 59;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // Elipse_blocked
            // 
            this.Elipse_blocked.BorderRadius = 30;
            this.Elipse_blocked.TargetControl = this.Panel_blocked;
            // 
            // Elipse_user
            // 
            this.Elipse_user.BorderRadius = 30;
            this.Elipse_user.TargetControl = this.Panel_users;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // UC_Users
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.label1);
            this.Name = "UC_Users";
            this.Size = new System.Drawing.Size(1106, 832);
            this.Load += new System.EventHandler(this.UC_Users_Load);
            this.panel1.ResumeLayout(false);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.Panel_users.ResumeLayout(false);
            this.Panel_users.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.Panel_blocked.ResumeLayout(false);
            this.Panel_blocked.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_user;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse Elipse_active;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI2.WinForms.Guna2Elipse Elipse_blocked;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse Elipse_user;
        private Guna.UI.WinForms.GunaGradientPanel Panel_users;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI.WinForms.GunaLabel Users_Label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaGradientPanel Panel_blocked;
        private Guna.UI.WinForms.GunaLabel user_Unavailable_Label;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
    }
}
