namespace Login
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_ViewOrder = new System.Windows.Forms.Button();
            this.btn_Staff = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_AddValue = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lab_username = new System.Windows.Forms.Label();
            this.lab_status = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.grp_takeOrder = new System.Windows.Forms.GroupBox();
            this.grp_order = new System.Windows.Forms.GroupBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.grp_StudentInfo = new System.Windows.Forms.GroupBox();
            this.txt_studid = new System.Windows.Forms.TextBox();
            this.btn_take = new System.Windows.Forms.Button();
            this.lab_studentID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lab_TakeTime = new System.Windows.Forms.Label();
            this.combo_time = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grp_takeOrder.SuspendLayout();
            this.grp_order.SuspendLayout();
            this.grp_StudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Report);
            this.panel1.Controls.Add(this.btn_ViewOrder);
            this.panel1.Controls.Add(this.btn_Staff);
            this.panel1.Controls.Add(this.btn_Menu);
            this.panel1.Controls.Add(this.btn_AddValue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 670);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 118);
            this.panel1.TabIndex = 0;
            // 
            // btn_Report
            // 
            this.btn_Report.Location = new System.Drawing.Point(853, 3);
            this.btn_Report.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(205, 111);
            this.btn_Report.TabIndex = 9;
            this.btn_Report.Text = "Report";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Visible = false;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // btn_ViewOrder
            // 
            this.btn_ViewOrder.Location = new System.Drawing.Point(643, 3);
            this.btn_ViewOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ViewOrder.Name = "btn_ViewOrder";
            this.btn_ViewOrder.Size = new System.Drawing.Size(205, 111);
            this.btn_ViewOrder.TabIndex = 8;
            this.btn_ViewOrder.Text = "View Order";
            this.btn_ViewOrder.UseVisualStyleBackColor = true;
            this.btn_ViewOrder.Click += new System.EventHandler(this.btn_ViewOrder_Click);
            // 
            // btn_Staff
            // 
            this.btn_Staff.Location = new System.Drawing.Point(432, 3);
            this.btn_Staff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.Size = new System.Drawing.Size(205, 111);
            this.btn_Staff.TabIndex = 7;
            this.btn_Staff.Text = "Staff";
            this.btn_Staff.UseVisualStyleBackColor = true;
            this.btn_Staff.Click += new System.EventHandler(this.btn_Staff_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(221, 2);
            this.btn_Menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(205, 111);
            this.btn_Menu.TabIndex = 6;
            this.btn_Menu.Text = "Menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_AddValue
            // 
            this.btn_AddValue.Location = new System.Drawing.Point(11, 2);
            this.btn_AddValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddValue.Name = "btn_AddValue";
            this.btn_AddValue.Size = new System.Drawing.Size(205, 111);
            this.btn_AddValue.TabIndex = 5;
            this.btn_AddValue.Text = "Add value";
            this.btn_AddValue.UseVisualStyleBackColor = true;
            this.btn_AddValue.Click += new System.EventHandler(this.btn_AddValue_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.panel2.CausesValidation = false;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lab_username);
            this.panel2.Controls.Add(this.lab_status);
            this.panel2.Controls.Add(this.Close);
            this.panel2.Controls.Add(this.time);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1151, 48);
            this.panel2.TabIndex = 2;
            // 
            // lab_username
            // 
            this.lab_username.AutoSize = true;
            this.lab_username.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lab_username.Location = new System.Drawing.Point(408, 9);
            this.lab_username.Name = "lab_username";
            this.lab_username.Size = new System.Drawing.Size(116, 28);
            this.lab_username.TabIndex = 3;
            this.lab_username.Text = "UserName:";
            // 
            // lab_status
            // 
            this.lab_status.AutoSize = true;
            this.lab_status.BackColor = System.Drawing.Color.Chartreuse;
            this.lab_status.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lab_status.Location = new System.Drawing.Point(12, 9);
            this.lab_status.Name = "lab_status";
            this.lab_status.Size = new System.Drawing.Size(147, 28);
            this.lab_status.TabIndex = 2;
            this.lab_status.Text = "Out of service";
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.AutoSize = true;
            this.Close.BackColor = System.Drawing.SystemColors.Control;
            this.Close.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Close.Location = new System.Drawing.Point(1113, 9);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(26, 28);
            this.Close.TabIndex = 1;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            this.Close.MouseHover += new System.EventHandler(this.Close_MouseHover);
            // 
            // time
            // 
            this.time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.time.Location = new System.Drawing.Point(803, 9);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(60, 29);
            this.time.TabIndex = 0;
            this.time.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // grp_takeOrder
            // 
            this.grp_takeOrder.Controls.Add(this.grp_order);
            this.grp_takeOrder.Controls.Add(this.grp_StudentInfo);
            this.grp_takeOrder.Controls.Add(this.dataGridView1);
            this.grp_takeOrder.Controls.Add(this.lab_TakeTime);
            this.grp_takeOrder.Controls.Add(this.combo_time);
            this.grp_takeOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.grp_takeOrder.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.grp_takeOrder.Location = new System.Drawing.Point(567, 48);
            this.grp_takeOrder.Name = "grp_takeOrder";
            this.grp_takeOrder.Size = new System.Drawing.Size(584, 622);
            this.grp_takeOrder.TabIndex = 5;
            this.grp_takeOrder.TabStop = false;
            this.grp_takeOrder.Text = "Take Order";
            // 
            // grp_order
            // 
            this.grp_order.Controls.Add(this.btn_Confirm);
            this.grp_order.Location = new System.Drawing.Point(13, 563);
            this.grp_order.Name = "grp_order";
            this.grp_order.Size = new System.Drawing.Size(263, 257);
            this.grp_order.TabIndex = 7;
            this.grp_order.TabStop = false;
            this.grp_order.Text = "Order";
            this.grp_order.Visible = false;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Confirm.Location = new System.Drawing.Point(3, 209);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(257, 45);
            this.btn_Confirm.TabIndex = 0;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // grp_StudentInfo
            // 
            this.grp_StudentInfo.Controls.Add(this.txt_studid);
            this.grp_StudentInfo.Controls.Add(this.btn_take);
            this.grp_StudentInfo.Controls.Add(this.lab_studentID);
            this.grp_StudentInfo.Location = new System.Drawing.Point(13, 373);
            this.grp_StudentInfo.Name = "grp_StudentInfo";
            this.grp_StudentInfo.Size = new System.Drawing.Size(264, 183);
            this.grp_StudentInfo.TabIndex = 6;
            this.grp_StudentInfo.TabStop = false;
            // 
            // txt_studid
            // 
            this.txt_studid.Location = new System.Drawing.Point(5, 77);
            this.txt_studid.Name = "txt_studid";
            this.txt_studid.Size = new System.Drawing.Size(223, 35);
            this.txt_studid.TabIndex = 4;
            // 
            // btn_take
            // 
            this.btn_take.Location = new System.Drawing.Point(5, 133);
            this.btn_take.Name = "btn_take";
            this.btn_take.Size = new System.Drawing.Size(223, 45);
            this.btn_take.TabIndex = 5;
            this.btn_take.Text = "Search";
            this.btn_take.UseVisualStyleBackColor = true;
            this.btn_take.Click += new System.EventHandler(this.btn_take_Click);
            // 
            // lab_studentID
            // 
            this.lab_studentID.AutoSize = true;
            this.lab_studentID.Location = new System.Drawing.Point(1, 43);
            this.lab_studentID.Name = "lab_studentID";
            this.lab_studentID.Size = new System.Drawing.Size(122, 28);
            this.lab_studentID.TabIndex = 3;
            this.lab_studentID.Text = "Student ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(259, 286);
            this.dataGridView1.TabIndex = 2;
            // 
            // lab_TakeTime
            // 
            this.lab_TakeTime.AutoSize = true;
            this.lab_TakeTime.Location = new System.Drawing.Point(9, 42);
            this.lab_TakeTime.Name = "lab_TakeTime";
            this.lab_TakeTime.Size = new System.Drawing.Size(116, 28);
            this.lab_TakeTime.TabIndex = 1;
            this.lab_TakeTime.Text = "Take Time:";
            // 
            // combo_time
            // 
            this.combo_time.FormattingEnabled = true;
            this.combo_time.Location = new System.Drawing.Point(131, 39);
            this.combo_time.Name = "combo_time";
            this.combo_time.Size = new System.Drawing.Size(136, 36);
            this.combo_time.TabIndex = 0;
            this.combo_time.SelectedIndexChanged += new System.EventHandler(this.combo_time_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Location = new System.Drawing.Point(0, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(357, 622);
            this.listBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label1.Location = new System.Drawing.Point(1087, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "-";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1151, 788);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.grp_takeOrder);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grp_takeOrder.ResumeLayout(false);
            this.grp_takeOrder.PerformLayout();
            this.grp_order.ResumeLayout(false);
            this.grp_StudentInfo.ResumeLayout(false);
            this.grp_StudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_AddValue;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_ViewOrder;
        private System.Windows.Forms.Button btn_Staff;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Label lab_status;
        private System.Windows.Forms.Label lab_username;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox grp_takeOrder;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lab_TakeTime;
        private System.Windows.Forms.ComboBox combo_time;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_take;
        private System.Windows.Forms.TextBox txt_studid;
        private System.Windows.Forms.Label lab_studentID;
        private System.Windows.Forms.GroupBox grp_StudentInfo;
        private System.Windows.Forms.GroupBox grp_order;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Label label1;

    }
}