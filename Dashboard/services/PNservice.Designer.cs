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
            this.lbl_service = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pic_photo = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_service
            // 
            this.lbl_service.AutoEllipsis = true;
            this.lbl_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_service.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.lbl_service.Location = new System.Drawing.Point(3, 73);
            this.lbl_service.Name = "lbl_service";
            this.lbl_service.Size = new System.Drawing.Size(95, 18);
            this.lbl_service.TabIndex = 2;
            this.lbl_service.Text = "service";
            this.lbl_service.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pic_photo
            // 
            this.pic_photo.ErrorImage = global::Dashboard.Properties.Resources.servicepng;
            this.pic_photo.Image = global::Dashboard.Properties.Resources.servicepng;
            this.pic_photo.ImageRotate = 0F;
            this.pic_photo.InitialImage = global::Dashboard.Properties.Resources.servicepng;
            this.pic_photo.Location = new System.Drawing.Point(12, 3);
            this.pic_photo.Name = "pic_photo";
            this.pic_photo.Size = new System.Drawing.Size(73, 67);
            this.pic_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_photo.TabIndex = 3;
            this.pic_photo.TabStop = false;
            this.pic_photo.Click += new System.EventHandler(this.pic_photo_Click);
            // 
            // PNservice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.pic_photo);
            this.Controls.Add(this.lbl_service);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(20, 10, 3, 3);
            this.Name = "PNservice";
            this.Size = new System.Drawing.Size(101, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pic_photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_service;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox pic_photo;
    }
}
