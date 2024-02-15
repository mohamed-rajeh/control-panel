namespace Dashboard.time_and_date
{
    partial class UC_time
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
            this.time_lable = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // time_lable
            // 
            this.time_lable.AutoSize = true;
            this.time_lable.Font = new System.Drawing.Font("Tahoma", 8F);
            this.time_lable.Location = new System.Drawing.Point(17, 6);
            this.time_lable.Name = "time_lable";
            this.time_lable.Size = new System.Drawing.Size(27, 13);
            this.time_lable.TabIndex = 0;
            this.time_lable.Text = "time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_time
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.time_lable);
            this.Name = "UC_time";
            this.Size = new System.Drawing.Size(179, 26);
            this.Load += new System.EventHandler(this.UC_time_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label time_lable;
        private System.Windows.Forms.Timer timer1;
    }
}
