namespace Login
{
    partial class MaintainUser
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
            this.checkType = new System.Windows.Forms.CheckedListBox();
            this.lab_seachType = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.showData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.showData)).BeginInit();
            this.SuspendLayout();
            // 
            // checkType
            // 
            this.checkType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.checkType.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.checkType.FormattingEnabled = true;
            this.checkType.Items.AddRange(new object[] {
            "Staff",
            "Student",
            "Manager"});
            this.checkType.Location = new System.Drawing.Point(12, 103);
            this.checkType.Name = "checkType";
            this.checkType.Size = new System.Drawing.Size(231, 254);
            this.checkType.TabIndex = 0;
            this.checkType.SelectedIndexChanged += new System.EventHandler(this.checkType_SelectedIndexChanged);
            // 
            // lab_seachType
            // 
            this.lab_seachType.AutoSize = true;
            this.lab_seachType.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.lab_seachType.Location = new System.Drawing.Point(8, 8);
            this.lab_seachType.Name = "lab_seachType";
            this.lab_seachType.Size = new System.Drawing.Size(221, 47);
            this.lab_seachType.TabIndex = 1;
            this.lab_seachType.Text = "Search Type";
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logout.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.btn_logout.Location = new System.Drawing.Point(648, 12);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(173, 60);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // showData
            // 
            this.showData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showData.Location = new System.Drawing.Point(268, 103);
            this.showData.Name = "showData";
            this.showData.RowTemplate.Height = 27;
            this.showData.Size = new System.Drawing.Size(553, 254);
            this.showData.TabIndex = 3;
            // 
            // MaintainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(834, 486);
            this.Controls.Add(this.showData);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lab_seachType);
            this.Controls.Add(this.checkType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MaintainUser";
            this.Text = "MaintainUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MaintainUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkType;
        private System.Windows.Forms.Label lab_seachType;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.DataGridView showData;
    }
}