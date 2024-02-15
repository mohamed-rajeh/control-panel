namespace Dashboard.provider
{
    partial class PN_Request
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
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_service = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_name_worker = new System.Windows.Forms.Label();
            this.pic_worker = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_worker)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.gunaElipsePanel1.Controls.Add(this.panel1);
            this.gunaElipsePanel1.Controls.Add(this.lbl_date);
            this.gunaElipsePanel1.Controls.Add(this.lbl_service);
            this.gunaElipsePanel1.Controls.Add(this.panel2);
            this.gunaElipsePanel1.Controls.Add(this.lbl_name_worker);
            this.gunaElipsePanel1.Controls.Add(this.pic_worker);
            this.gunaElipsePanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(658, 79);
            this.gunaElipsePanel1.TabIndex = 55;
            this.gunaElipsePanel1.Click += new System.EventHandler(this.gunaElipsePanel1_Click_1);
            this.gunaElipsePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaElipsePanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 3);
            this.panel1.TabIndex = 58;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lbl_date.Location = new System.Drawing.Point(533, 46);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(100, 24);
            this.lbl_date.TabIndex = 57;
            this.lbl_date.Text = "date_time";
            this.lbl_date.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_service
            // 
            this.lbl_service.AutoSize = true;
            this.lbl_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_service.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lbl_service.Location = new System.Drawing.Point(543, 7);
            this.lbl_service.Name = "lbl_service";
            this.lbl_service.Size = new System.Drawing.Size(77, 24);
            this.lbl_service.TabIndex = 56;
            this.lbl_service.Text = "service";
            this.lbl_service.Click += new System.EventHandler(this.lpl_service_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(503, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 5);
            this.panel2.TabIndex = 55;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // lbl_name_worker
            // 
            this.lbl_name_worker.AutoSize = true;
            this.lbl_name_worker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_worker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lbl_name_worker.Location = new System.Drawing.Point(90, 24);
            this.lbl_name_worker.Name = "lbl_name_worker";
            this.lbl_name_worker.Size = new System.Drawing.Size(75, 26);
            this.lbl_name_worker.TabIndex = 53;
            this.lbl_name_worker.Text = "Name";
            this.lbl_name_worker.Click += new System.EventHandler(this.lpl_name_worker_Click);
            // 
            // pic_worker
            // 
            this.pic_worker.BaseColor = System.Drawing.Color.White;
            this.pic_worker.Image = global::Dashboard.Properties.Resources.Worker_Male_40px;
            this.pic_worker.Location = new System.Drawing.Point(14, 7);
            this.pic_worker.Name = "pic_worker";
            this.pic_worker.Size = new System.Drawing.Size(61, 57);
            this.pic_worker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_worker.TabIndex = 52;
            this.pic_worker.TabStop = false;
            this.pic_worker.UseTransfarantBackground = false;
            this.pic_worker.Click += new System.EventHandler(this.pic_worker_Click);
            // 
            // List_of_worker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gunaElipsePanel1);
            this.Name = "List_of_worker";
            this.Size = new System.Drawing.Size(658, 79);
            this.Click += new System.EventHandler(this.List_of_worker_Click);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_worker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_service;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_name_worker;
        private Guna.UI.WinForms.GunaCirclePictureBox pic_worker;
    }
}
