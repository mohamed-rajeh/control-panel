namespace Dashboard.time_and_date
{
    partial class UC_date
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
            this.date_lable = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // date_lable
            // 
            this.date_lable.AutoSize = true;
            this.date_lable.Font = new System.Drawing.Font("Tahoma", 8F);
            this.date_lable.Location = new System.Drawing.Point(14, 6);
            this.date_lable.Name = "date_lable";
            this.date_lable.Size = new System.Drawing.Size(29, 13);
            this.date_lable.TabIndex = 1;
            this.date_lable.Text = "date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.date_lable);
            this.Name = "UC_date";
            this.Size = new System.Drawing.Size(179, 26);
            this.Load += new System.EventHandler(this.UC_date_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label date_lable;
        private System.Windows.Forms.Timer timer1;
    }
}
