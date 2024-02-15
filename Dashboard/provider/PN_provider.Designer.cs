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
            this.picture_worker = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picture_worker)).BeginInit();
            this.SuspendLayout();
            // 
            // lpl_worker
            // 
            this.lpl_worker.AutoEllipsis = true;
            this.lpl_worker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lpl_worker.ForeColor = System.Drawing.Color.Black;
            this.lpl_worker.Location = new System.Drawing.Point(3, 56);
            this.lpl_worker.Name = "lpl_worker";
            this.lpl_worker.Size = new System.Drawing.Size(76, 17);
            this.lpl_worker.TabIndex = 3;
            this.lpl_worker.Text = "gtgggg";
            this.lpl_worker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picture_worker
            // 
            this.picture_worker.BackColor = System.Drawing.Color.Transparent;
            this.picture_worker.BaseColor = System.Drawing.Color.White;
            this.picture_worker.Image = global::Dashboard.Properties.Resources.Old_Man_Skin_Type_3_48px;
            this.picture_worker.Location = new System.Drawing.Point(15, 6);
            this.picture_worker.Name = "picture_worker";
            this.picture_worker.Size = new System.Drawing.Size(54, 47);
            this.picture_worker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_worker.TabIndex = 2;
            this.picture_worker.TabStop = false;
            this.picture_worker.UseTransfarantBackground = false;
            this.picture_worker.Click += new System.EventHandler(this.picture_user_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // PN_worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.lpl_worker);
            this.Controls.Add(this.picture_worker);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 3, 3);
            this.Name = "PN_worker";
            this.Size = new System.Drawing.Size(82, 82);
            ((System.ComponentModel.ISupportInitialize)(this.picture_worker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaCirclePictureBox picture_worker;
        private System.Windows.Forms.Label lpl_worker;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}
