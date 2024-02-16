namespace Dashboard
{
    partial class PN_provider
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
            this.lpl_worker = new System.Windows.Forms.Label();
            this.pic_photo = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // lpl_worker
            // 
            this.lpl_worker.AutoEllipsis = true;
            this.lpl_worker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpl_worker.ForeColor = System.Drawing.Color.Black;
            this.lpl_worker.Location = new System.Drawing.Point(3, 86);
            this.lpl_worker.Name = "lpl_worker";
            this.lpl_worker.Size = new System.Drawing.Size(114, 34);
            this.lpl_worker.TabIndex = 3;
            this.lpl_worker.Text = "gtgggg";
            this.lpl_worker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_photo
            // 
            this.pic_photo.BackColor = System.Drawing.Color.Transparent;
            this.pic_photo.BaseColor = System.Drawing.Color.White;
            this.pic_photo.Image = global::Dashboard.Properties.Resources.Worker_Male_48px;
            this.pic_photo.Location = new System.Drawing.Point(16, 3);
            this.pic_photo.Name = "pic_photo";
            this.pic_photo.Size = new System.Drawing.Size(80, 80);
            this.pic_photo.TabIndex = 2;
            this.pic_photo.TabStop = false;
            this.pic_photo.UseTransfarantBackground = false;
            this.pic_photo.Click += new System.EventHandler(this.picture_user_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // PN_provider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.lpl_worker);
            this.Controls.Add(this.pic_photo);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "PN_provider";
            this.Size = new System.Drawing.Size(120, 120);
            ((System.ComponentModel.ISupportInitialize)(this.pic_photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaCirclePictureBox pic_photo;
        private System.Windows.Forms.Label lpl_worker;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}
