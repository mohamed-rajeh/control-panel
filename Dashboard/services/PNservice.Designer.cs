namespace Dashboard.services
{
    partial class PNservice
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
            this.picture_service = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.lbl_service = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picture_service)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_service
            // 
            this.picture_service.BaseColor = System.Drawing.Color.White;
            this.picture_service.Image = global::Dashboard.Properties.Resources.servicepng;
            this.picture_service.Location = new System.Drawing.Point(11, 5);
            this.picture_service.Name = "picture_service";
            this.picture_service.Size = new System.Drawing.Size(60, 50);
            this.picture_service.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_service.TabIndex = 0;
            this.picture_service.TabStop = false;
            this.picture_service.UseTransfarantBackground = false;
            this.picture_service.Click += new System.EventHandler(this.picture_service_Click);
            // 
            // lbl_service
            // 
            this.lbl_service.AutoEllipsis = true;
            this.lbl_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_service.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.lbl_service.Location = new System.Drawing.Point(3, 59);
            this.lbl_service.Name = "lbl_service";
            this.lbl_service.Size = new System.Drawing.Size(78, 18);
            this.lbl_service.TabIndex = 2;
            this.lbl_service.Text = "Admin";
            this.lbl_service.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // PNservice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.lbl_service);
            this.Controls.Add(this.picture_service);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(20, 10, 3, 3);
            this.Name = "PNservice";
            this.Size = new System.Drawing.Size(84, 84);
            ((System.ComponentModel.ISupportInitialize)(this.picture_service)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaCirclePictureBox picture_service;
        private System.Windows.Forms.Label lbl_service;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
