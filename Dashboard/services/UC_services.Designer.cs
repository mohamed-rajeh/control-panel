namespace Dashboard
{
    partial class UC_services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_services));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.but_add = new Guna.UI.WinForms.GunaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.text_service_search = new Guna.UI.WinForms.GunaTextBox();
            this.servicers_Unavailable_Label = new Guna.UI.WinForms.GunaLabel();
            this.Panel_Unavailable = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel2.SuspendLayout();
            this.Panel_Unavailable.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 36);
            this.label1.TabIndex = 67;
            this.label1.Text = "Servicers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 68;
            this.label5.Text = "Unavailable";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(35, 110);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(821, 420);
            this.flowLayoutPanel1.TabIndex = 65;
            // 
            // but_add
            // 
            this.but_add.AnimationHoverSpeed = 0.07F;
            this.but_add.AnimationSpeed = 0.03F;
            this.but_add.BackColor = System.Drawing.Color.Transparent;
            this.but_add.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.but_add.BorderColor = System.Drawing.Color.Black;
            this.but_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.but_add.FocusedColor = System.Drawing.Color.Empty;
            this.but_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.but_add.ForeColor = System.Drawing.Color.Black;
            this.but_add.Image = ((System.Drawing.Image)(resources.GetObject("but_add.Image")));
            this.but_add.ImageSize = new System.Drawing.Size(20, 20);
            this.but_add.Location = new System.Drawing.Point(672, 28);
            this.but_add.Name = "but_add";
            this.but_add.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.but_add.OnHoverBorderColor = System.Drawing.Color.Black;
            this.but_add.OnHoverForeColor = System.Drawing.Color.White;
            this.but_add.OnHoverImage = null;
            this.but_add.OnPressedColor = System.Drawing.Color.Black;
            this.but_add.Radius = 12;
            this.but_add.Size = new System.Drawing.Size(124, 43);
            this.but_add.TabIndex = 70;
            this.but_add.Text = "Add";
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.text_service_search);
            this.panel2.Controls.Add(this.but_add);
            this.panel2.Location = new System.Drawing.Point(187, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 565);
            this.panel2.TabIndex = 72;
            // 
            // text_service_search
            // 
            this.text_service_search.AllowDrop = true;
            this.text_service_search.BackColor = System.Drawing.Color.Transparent;
            this.text_service_search.BaseColor = System.Drawing.Color.White;
            this.text_service_search.BorderColor = System.Drawing.Color.Silver;
            this.text_service_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_service_search.FocusedBaseColor = System.Drawing.Color.White;
            this.text_service_search.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.text_service_search.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.text_service_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.text_service_search.ForeColor = System.Drawing.Color.Silver;
            this.text_service_search.Location = new System.Drawing.Point(35, 28);
            this.text_service_search.Name = "text_service_search";
            this.text_service_search.PasswordChar = '\0';
            this.text_service_search.Radius = 10;
            this.text_service_search.SelectedText = "";
            this.text_service_search.Size = new System.Drawing.Size(268, 43);
            this.text_service_search.TabIndex = 72;
            this.text_service_search.Text = "search";
            this.text_service_search.Enter += new System.EventHandler(this.text_service_search_Enter);
            this.text_service_search.Leave += new System.EventHandler(this.text_service_search_Leave);
            // 
            // servicers_Unavailable_Label
            // 
            this.servicers_Unavailable_Label.AutoSize = true;
            this.servicers_Unavailable_Label.BackColor = System.Drawing.Color.Transparent;
            this.servicers_Unavailable_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicers_Unavailable_Label.Font = new System.Drawing.Font("Segoe UI Emoji", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.servicers_Unavailable_Label.Location = new System.Drawing.Point(142, 7);
            this.servicers_Unavailable_Label.Name = "servicers_Unavailable_Label";
            this.servicers_Unavailable_Label.Size = new System.Drawing.Size(45, 35);
            this.servicers_Unavailable_Label.TabIndex = 71;
            this.servicers_Unavailable_Label.Text = "10";
            // 
            // Panel_Unavailable
            // 
            this.Panel_Unavailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.Panel_Unavailable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Unavailable.BackgroundImage")));
            this.Panel_Unavailable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Unavailable.Controls.Add(this.label5);
            this.Panel_Unavailable.Controls.Add(this.servicers_Unavailable_Label);
            this.Panel_Unavailable.ForeColor = System.Drawing.Color.Black;
            this.Panel_Unavailable.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.Panel_Unavailable.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.Panel_Unavailable.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.Panel_Unavailable.GradientColor4 = System.Drawing.Color.White;
            this.Panel_Unavailable.Location = new System.Drawing.Point(187, 59);
            this.Panel_Unavailable.Name = "Panel_Unavailable";
            this.Panel_Unavailable.Quality = 8;
            this.Panel_Unavailable.Size = new System.Drawing.Size(202, 49);
            this.Panel_Unavailable.TabIndex = 73;
            this.Panel_Unavailable.Text = "gunaGradientPanel1";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this.Panel_Unavailable;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 10;
            this.gunaElipse2.TargetControl = this.panel2;
            // 
            // UC_services
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Controls.Add(this.Panel_Unavailable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "UC_services";
            this.Size = new System.Drawing.Size(1153, 718);
            this.Load += new System.EventHandler(this.UC_services_Load);
            this.panel2.ResumeLayout(false);
            this.Panel_Unavailable.ResumeLayout(false);
            this.Panel_Unavailable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaButton but_add;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaLabel servicers_Unavailable_Label;
        private Guna.UI.WinForms.GunaTextBox text_service_search;
        private Guna.UI.WinForms.GunaGradientPanel Panel_Unavailable;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
    }
}
