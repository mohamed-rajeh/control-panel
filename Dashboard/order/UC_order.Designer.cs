namespace Dashboard.order
{
    partial class UC_order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_order));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel_line_lable = new System.Windows.Forms.Panel();
            this.label_cancel = new System.Windows.Forms.Label();
            this.label_new = new System.Windows.Forms.Label();
            this.label_all = new System.Windows.Forms.Label();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.text_order_search = new Guna.UI.WinForms.GunaTextBox();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_done_orders = new Guna.UI.WinForms.GunaLabel();
            this.Panel_Unavailable = new Guna.UI.WinForms.GunaGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.servicers_Unavailable_Label = new Guna.UI.WinForms.GunaLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            this.gunaGradientPanel1.SuspendLayout();
            this.Panel_Unavailable.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.gunaElipsePanel1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 779);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "make it UC";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Red;
            this.panel6.Controls.Add(this.panel_line_lable);
            this.panel6.Controls.Add(this.label_cancel);
            this.panel6.Controls.Add(this.label_new);
            this.panel6.Controls.Add(this.label_all);
            this.panel6.Location = new System.Drawing.Point(341, 200);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(402, 50);
            this.panel6.TabIndex = 50;
            this.panel6.Tag = "";
            // 
            // panel_line_lable
            // 
            this.panel_line_lable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel_line_lable.Location = new System.Drawing.Point(18, 37);
            this.panel_line_lable.Name = "panel_line_lable";
            this.panel_line_lable.Size = new System.Drawing.Size(368, 8);
            this.panel_line_lable.TabIndex = 48;
            // 
            // label_cancel
            // 
            this.label_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cancel.ForeColor = System.Drawing.Color.Black;
            this.label_cancel.Location = new System.Drawing.Point(264, 3);
            this.label_cancel.Name = "label_cancel";
            this.label_cancel.Size = new System.Drawing.Size(117, 32);
            this.label_cancel.TabIndex = 47;
            this.label_cancel.Text = "Accepted";
            this.label_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_cancel.Click += new System.EventHandler(this.label_cancel_Click);
            // 
            // label_new
            // 
            this.label_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_new.ForeColor = System.Drawing.Color.Black;
            this.label_new.Location = new System.Drawing.Point(151, 4);
            this.label_new.Name = "label_new";
            this.label_new.Size = new System.Drawing.Size(66, 30);
            this.label_new.TabIndex = 46;
            this.label_new.Text = "New";
            this.label_new.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_new.Click += new System.EventHandler(this.labe_new_Click);
            // 
            // label_all
            // 
            this.label_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_all.ForeColor = System.Drawing.Color.Black;
            this.label_all.Location = new System.Drawing.Point(36, 2);
            this.label_all.Name = "label_all";
            this.label_all.Size = new System.Drawing.Size(54, 34);
            this.label_all.TabIndex = 45;
            this.label_all.Text = "All";
            this.label_all.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_all.Click += new System.EventHandler(this.label13_Click);
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.text_order_search);
            this.gunaElipsePanel1.Controls.Add(this.gunaGradientPanel1);
            this.gunaElipsePanel1.Controls.Add(this.Panel_Unavailable);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(208, 22);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 10;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(668, 160);
            this.gunaElipsePanel1.TabIndex = 65;
            // 
            // text_order_search
            // 
            this.text_order_search.AllowDrop = true;
            this.text_order_search.BackColor = System.Drawing.Color.Transparent;
            this.text_order_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.text_order_search.BaseColor = System.Drawing.Color.White;
            this.text_order_search.BorderColor = System.Drawing.Color.Silver;
            this.text_order_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_order_search.FocusedBaseColor = System.Drawing.Color.White;
            this.text_order_search.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.text_order_search.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.text_order_search.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.text_order_search.ForeColor = System.Drawing.Color.Silver;
            this.text_order_search.Location = new System.Drawing.Point(197, 106);
            this.text_order_search.Name = "text_order_search";
            this.text_order_search.PasswordChar = '\0';
            this.text_order_search.Radius = 10;
            this.text_order_search.SelectedText = "";
            this.text_order_search.Size = new System.Drawing.Size(267, 42);
            this.text_order_search.TabIndex = 52;
            this.text_order_search.Text = "search";
            this.text_order_search.Enter += new System.EventHandler(this.text_order_search_Enter_1);
            this.text_order_search.Leave += new System.EventHandler(this.text_order_search_Leave);
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.label9);
            this.gunaGradientPanel1.Controls.Add(this.lbl_done_orders);
            this.gunaGradientPanel1.ForeColor = System.Drawing.Color.Black;
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.White;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(385, 34);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Quality = 8;
            this.gunaGradientPanel1.Size = new System.Drawing.Size(239, 49);
            this.gunaGradientPanel1.TabIndex = 75;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(7, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 26);
            this.label9.TabIndex = 72;
            this.label9.Text = "Done Orders";
            // 
            // lbl_done_orders
            // 
            this.lbl_done_orders.AutoSize = true;
            this.lbl_done_orders.BackColor = System.Drawing.Color.Transparent;
            this.lbl_done_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_done_orders.Font = new System.Drawing.Font("Segoe UI Emoji", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.lbl_done_orders.Location = new System.Drawing.Point(183, 7);
            this.lbl_done_orders.Name = "lbl_done_orders";
            this.lbl_done_orders.Size = new System.Drawing.Size(45, 35);
            this.lbl_done_orders.TabIndex = 71;
            this.lbl_done_orders.Text = "40";
            // 
            // Panel_Unavailable
            // 
            this.Panel_Unavailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.Panel_Unavailable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Unavailable.BackgroundImage")));
            this.Panel_Unavailable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Unavailable.Controls.Add(this.label1);
            this.Panel_Unavailable.Controls.Add(this.servicers_Unavailable_Label);
            this.Panel_Unavailable.ForeColor = System.Drawing.Color.Black;
            this.Panel_Unavailable.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.Panel_Unavailable.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.Panel_Unavailable.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.Panel_Unavailable.GradientColor4 = System.Drawing.Color.White;
            this.Panel_Unavailable.Location = new System.Drawing.Point(48, 34);
            this.Panel_Unavailable.Name = "Panel_Unavailable";
            this.Panel_Unavailable.Quality = 8;
            this.Panel_Unavailable.Size = new System.Drawing.Size(227, 49);
            this.Panel_Unavailable.TabIndex = 74;
            this.Panel_Unavailable.Text = "gunaGradientPanel1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 72;
            this.label1.Text = "Dey Orders";
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
            this.servicers_Unavailable_Label.Text = "40";
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Location = new System.Drawing.Point(92, 262);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(925, 473);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(20, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(886, 55);
            this.panel5.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(787, 7);
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
            this.label7.Location = new System.Drawing.Point(586, 7);
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
            this.label6.Location = new System.Drawing.Point(287, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Cname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(62, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Service";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(200)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 55);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(882, 392);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 31);
            this.label2.TabIndex = 44;
            this.label2.Text = "Order";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.panel6;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UC_order
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Name = "UC_order";
            this.Size = new System.Drawing.Size(1035, 779);
            this.Load += new System.EventHandler(this.UC_order_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            this.Panel_Unavailable.ResumeLayout(false);
            this.Panel_Unavailable.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel_line_lable;
        private System.Windows.Forms.Label label_cancel;
        private System.Windows.Forms.Label label_new;
        private System.Windows.Forms.Label label_all;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaGradientPanel Panel_Unavailable;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLabel servicers_Unavailable_Label;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaLabel lbl_done_orders;
        private Guna.UI.WinForms.GunaTextBox text_order_search;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.Label label3;
    }
}
