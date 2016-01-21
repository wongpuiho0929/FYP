namespace Login
{
    partial class kitchenView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.FLP1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Location = new System.Drawing.Point(1168, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(200, 100);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
            this.gb1.Text = "Filter";
            // 
            // FLP1
            // 
            this.FLP1.Location = new System.Drawing.Point(12, 12);
            this.FLP1.Name = "FLP1";
            this.FLP1.Size = new System.Drawing.Size(735, 451);
            this.FLP1.TabIndex = 2;
            // 
            // kitchenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 618);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.FLP1);
            this.Name = "kitchenView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.kitchenView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.FlowLayoutPanel FLP1;
    }
}