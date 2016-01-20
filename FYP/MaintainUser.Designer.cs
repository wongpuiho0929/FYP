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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rBtn_Student = new System.Windows.Forms.RadioButton();
            this.rBtn_Staff = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_Name = new System.Windows.Forms.Label();
            this.list_Name = new System.Windows.Forms.ListBox();
            this.lab_Search = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.lab_Search);
            this.splitContainer1.Panel1.Controls.Add(this.list_Name);
            this.splitContainer1.Panel1.Controls.Add(this.lab_Name);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(978, 700);
            this.splitContainer1.SplitterDistance = 326;
            this.splitContainer1.TabIndex = 0;
            // 
            // rBtn_Student
            // 
            this.rBtn_Student.AutoSize = true;
            this.rBtn_Student.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.rBtn_Student.Location = new System.Drawing.Point(6, 44);
            this.rBtn_Student.Name = "rBtn_Student";
            this.rBtn_Student.Size = new System.Drawing.Size(95, 28);
            this.rBtn_Student.TabIndex = 0;
            this.rBtn_Student.TabStop = true;
            this.rBtn_Student.Text = "Student";
            this.rBtn_Student.UseVisualStyleBackColor = true;
            // 
            // rBtn_Staff
            // 
            this.rBtn_Staff.AutoSize = true;
            this.rBtn_Staff.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.rBtn_Staff.Location = new System.Drawing.Point(6, 78);
            this.rBtn_Staff.Name = "rBtn_Staff";
            this.rBtn_Staff.Size = new System.Drawing.Size(75, 28);
            this.rBtn_Staff.TabIndex = 1;
            this.rBtn_Staff.TabStop = true;
            this.rBtn_Staff.Text = "Staff";
            this.rBtn_Staff.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rBtn_Student);
            this.groupBox1.Controls.Add(this.rBtn_Staff);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 127);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose User Type";
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.lab_Name.Location = new System.Drawing.Point(8, 164);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(166, 24);
            this.lab_Name.TabIndex = 3;
            this.lab_Name.Text = "Account Name/ID:";
            // 
            // list_Name
            // 
            this.list_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_Name.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.list_Name.FormattingEnabled = true;
            this.list_Name.ItemHeight = 24;
            this.list_Name.Location = new System.Drawing.Point(12, 301);
            this.list_Name.Name = "list_Name";
            this.list_Name.Size = new System.Drawing.Size(311, 244);
            this.list_Name.TabIndex = 4;
            // 
            // lab_Search
            // 
            this.lab_Search.AutoSize = true;
            this.lab_Search.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Underline);
            this.lab_Search.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lab_Search.Location = new System.Drawing.Point(199, 227);
            this.lab_Search.Name = "lab_Search";
            this.lab_Search.Size = new System.Drawing.Size(68, 24);
            this.lab_Search.TabIndex = 5;
            this.lab_Search.Text = "Search";
            this.lab_Search.Click += new System.EventHandler(this.lab_Search_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.textBox1.Location = new System.Drawing.Point(18, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 32);
            this.textBox1.TabIndex = 6;
            // 
            // MaintainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(978, 700);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MaintainUser";
            this.Text = "MaintainUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MaintainUser_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton rBtn_Staff;
        private System.Windows.Forms.RadioButton rBtn_Student;
        private System.Windows.Forms.ListBox list_Name;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lab_Search;
        private System.Windows.Forms.TextBox textBox1;


    }
}