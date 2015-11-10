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
            this.btn_back = new System.Windows.Forms.Button();
            this.panel_chickType = new System.Windows.Forms.Panel();
            this.chk_type = new System.Windows.Forms.CheckedListBox();
            this.lab_type = new System.Windows.Forms.Label();
            this.lab_staff = new System.Windows.Forms.Label();
            this.lab_student = new System.Windows.Forms.Label();
            this.panel_staff = new System.Windows.Forms.Panel();
            this.showdata_staff = new System.Windows.Forms.DataGridView();
            this.panel_student = new System.Windows.Forms.Panel();
            this.showdata_student = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.lab_searchId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_chickType.SuspendLayout();
            this.panel_staff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showdata_staff)).BeginInit();
            this.panel_student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showdata_student)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_back.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.btn_back.Location = new System.Drawing.Point(760, 12);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(173, 60);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panel_chickType
            // 
            this.panel_chickType.Controls.Add(this.textBox1);
            this.panel_chickType.Controls.Add(this.lab_searchId);
            this.panel_chickType.Controls.Add(this.btn_search);
            this.panel_chickType.Controls.Add(this.chk_type);
            this.panel_chickType.Controls.Add(this.lab_type);
            this.panel_chickType.Location = new System.Drawing.Point(12, 26);
            this.panel_chickType.Name = "panel_chickType";
            this.panel_chickType.Size = new System.Drawing.Size(241, 662);
            this.panel_chickType.TabIndex = 2;
            // 
            // chk_type
            // 
            this.chk_type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_type.BackColor = System.Drawing.SystemColors.HighlightText;
            this.chk_type.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.chk_type.ForeColor = System.Drawing.SystemColors.WindowText;
            this.chk_type.FormattingEnabled = true;
            this.chk_type.Items.AddRange(new object[] {
            "Student",
            "Staff"});
            this.chk_type.Location = new System.Drawing.Point(3, 58);
            this.chk_type.Name = "chk_type";
            this.chk_type.Size = new System.Drawing.Size(235, 249);
            this.chk_type.TabIndex = 1;
            // 
            // lab_type
            // 
            this.lab_type.AutoSize = true;
            this.lab_type.Font = new System.Drawing.Font("Comic Sans MS", 22.5F);
            this.lab_type.Location = new System.Drawing.Point(3, 2);
            this.lab_type.Name = "lab_type";
            this.lab_type.Size = new System.Drawing.Size(132, 53);
            this.lab_type.TabIndex = 0;
            this.lab_type.Text = "Type: ";
            // 
            // lab_staff
            // 
            this.lab_staff.AutoSize = true;
            this.lab_staff.Dock = System.Windows.Forms.DockStyle.Top;
            this.lab_staff.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.lab_staff.Location = new System.Drawing.Point(0, 0);
            this.lab_staff.Name = "lab_staff";
            this.lab_staff.Size = new System.Drawing.Size(98, 42);
            this.lab_staff.TabIndex = 3;
            this.lab_staff.Text = "Staff";
            // 
            // lab_student
            // 
            this.lab_student.AutoSize = true;
            this.lab_student.Dock = System.Windows.Forms.DockStyle.Top;
            this.lab_student.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.lab_student.Location = new System.Drawing.Point(0, 0);
            this.lab_student.Name = "lab_student";
            this.lab_student.Size = new System.Drawing.Size(132, 42);
            this.lab_student.TabIndex = 4;
            this.lab_student.Text = "Student";
            // 
            // panel_staff
            // 
            this.panel_staff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_staff.Controls.Add(this.showdata_staff);
            this.panel_staff.Controls.Add(this.lab_staff);
            this.panel_staff.Location = new System.Drawing.Point(263, 70);
            this.panel_staff.Name = "panel_staff";
            this.panel_staff.Size = new System.Drawing.Size(671, 306);
            this.panel_staff.TabIndex = 5;
            // 
            // showdata_staff
            // 
            this.showdata_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showdata_staff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showdata_staff.Location = new System.Drawing.Point(0, 42);
            this.showdata_staff.Name = "showdata_staff";
            this.showdata_staff.RowTemplate.Height = 27;
            this.showdata_staff.Size = new System.Drawing.Size(671, 264);
            this.showdata_staff.TabIndex = 4;
            // 
            // panel_student
            // 
            this.panel_student.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_student.Controls.Add(this.showdata_student);
            this.panel_student.Controls.Add(this.lab_student);
            this.panel_student.Location = new System.Drawing.Point(263, 382);
            this.panel_student.Name = "panel_student";
            this.panel_student.Size = new System.Drawing.Size(671, 306);
            this.panel_student.TabIndex = 6;
            // 
            // showdata_student
            // 
            this.showdata_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showdata_student.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showdata_student.Location = new System.Drawing.Point(0, 42);
            this.showdata_student.Name = "showdata_student";
            this.showdata_student.RowTemplate.Height = 27;
            this.showdata_student.Size = new System.Drawing.Size(671, 264);
            this.showdata_student.TabIndex = 5;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.btn_search.Location = new System.Drawing.Point(8, 467);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(173, 60);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // lab_searchId
            // 
            this.lab_searchId.AutoSize = true;
            this.lab_searchId.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.lab_searchId.Location = new System.Drawing.Point(5, 356);
            this.lab_searchId.Name = "lab_searchId";
            this.lab_searchId.Size = new System.Drawing.Size(158, 42);
            this.lab_searchId.TabIndex = 3;
            this.lab_searchId.Text = "Search id:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.textBox1.Location = new System.Drawing.Point(8, 401);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 42);
            this.textBox1.TabIndex = 4;
            // 
            // MaintainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(946, 875);
            this.ControlBox = false;
            this.Controls.Add(this.panel_student);
            this.Controls.Add(this.panel_staff);
            this.Controls.Add(this.panel_chickType);
            this.Controls.Add(this.btn_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MaintainUser";
            this.Text = "MaintainUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MaintainUser_Load);
            this.panel_chickType.ResumeLayout(false);
            this.panel_chickType.PerformLayout();
            this.panel_staff.ResumeLayout(false);
            this.panel_staff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showdata_staff)).EndInit();
            this.panel_student.ResumeLayout(false);
            this.panel_student.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showdata_student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel_chickType;
        private System.Windows.Forms.CheckedListBox chk_type;
        private System.Windows.Forms.Label lab_type;
        private System.Windows.Forms.Label lab_staff;
        private System.Windows.Forms.Label lab_student;
        private System.Windows.Forms.Panel panel_staff;
        private System.Windows.Forms.Panel panel_student;
        private System.Windows.Forms.DataGridView showdata_staff;
        private System.Windows.Forms.DataGridView showdata_student;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lab_searchId;

    }
}