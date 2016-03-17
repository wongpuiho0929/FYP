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
            this.txtId = new System.Windows.Forms.TextBox();
            this.btn_del2 = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.FLP1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.txtId);
            this.gb1.Controls.Add(this.btn_del2);
            this.gb1.Controls.Add(this.btn_del);
            this.gb1.Controls.Add(this.btn_add);
            this.gb1.Location = new System.Drawing.Point(1608, 15);
            this.gb1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb1.Name = "gb1";
            this.gb1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb1.Size = new System.Drawing.Size(216, 564);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
            this.gb1.Text = "Filter";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(37, 139);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(132, 25);
            this.txtId.TabIndex = 3;
            this.txtId.Visible = false;
            // 
            // btn_del2
            // 
            this.btn_del2.Location = new System.Drawing.Point(37, 101);
            this.btn_del2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_del2.Name = "btn_del2";
            this.btn_del2.Size = new System.Drawing.Size(100, 29);
            this.btn_del2.TabIndex = 2;
            this.btn_del2.Text = "del2";
            this.btn_del2.UseVisualStyleBackColor = true;
            this.btn_del2.Visible = false;
            this.btn_del2.Click += new System.EventHandler(this.btn_del2_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(37, 65);
            this.btn_del.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(100, 29);
            this.btn_del.TabIndex = 1;
            this.btn_del.Text = "del";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(37, 28);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 29);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Update";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // FLP1
            // 
            this.FLP1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FLP1.Location = new System.Drawing.Point(16, 15);
            this.FLP1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FLP1.Name = "FLP1";
            this.FLP1.Size = new System.Drawing.Size(980, 564);
            this.FLP1.TabIndex = 2;
            // 
            // kitchenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1860, 772);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.FLP1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "kitchenView";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.kitchenView_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.FlowLayoutPanel FLP1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_del2;
        private System.Windows.Forms.TextBox txtId;
    }
}