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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lab_username = new System.Windows.Forms.Label();
            this.lab_status = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 328);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 94);
            this.panel1.TabIndex = 0;
            // 
            // btn_Report
            // 
            this.btn_Report.Location = new System.Drawing.Point(640, 3);
            this.btn_Report.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(154, 89);
            this.btn_Report.TabIndex = 9;
            this.btn_Report.Text = "Report";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // btn_ViewOrder
            // 
            this.btn_ViewOrder.Location = new System.Drawing.Point(482, 3);
            this.btn_ViewOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ViewOrder.Name = "btn_ViewOrder";
            this.btn_ViewOrder.Size = new System.Drawing.Size(154, 89);
            this.btn_ViewOrder.TabIndex = 8;
            this.btn_ViewOrder.Text = "View Order";
            this.btn_ViewOrder.UseVisualStyleBackColor = true;
            this.btn_ViewOrder.Click += new System.EventHandler(this.btn_ViewOrder_Click);
            // 
            // btn_Staff
            // 
            this.btn_Staff.Location = new System.Drawing.Point(324, 3);
            this.btn_Staff.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.Size = new System.Drawing.Size(154, 89);
            this.btn_Staff.TabIndex = 7;
            this.btn_Staff.Text = "Staff";
            this.btn_Staff.UseVisualStyleBackColor = true;
            this.btn_Staff.Click += new System.EventHandler(this.btn_Staff_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(166, 2);
            this.btn_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(154, 89);
            this.btn_Menu.TabIndex = 6;
            this.btn_Menu.Text = "Menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_AddValue
            // 
            this.btn_AddValue.Location = new System.Drawing.Point(8, 2);
            this.btn_AddValue.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddValue.Name = "btn_AddValue";
            this.btn_AddValue.Size = new System.Drawing.Size(154, 89);
            this.btn_AddValue.TabIndex = 5;
            this.btn_AddValue.Text = "Add value";
            this.btn_AddValue.UseVisualStyleBackColor = true;
            this.btn_AddValue.Click += new System.EventHandler(this.btn_AddValue_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(8, 44);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(630, 268);
            this.listBox1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.panel2.CausesValidation = false;
            this.panel2.Controls.Add(this.lab_username);
            this.panel2.Controls.Add(this.lab_status);
            this.panel2.Controls.Add(this.Close);
            this.panel2.Controls.Add(this.time);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 39);
            this.panel2.TabIndex = 2;
            // 
            // lab_username
            // 
            this.lab_username.AutoSize = true;
            this.lab_username.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lab_username.Location = new System.Drawing.Point(306, 7);
            this.lab_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_username.Name = "lab_username";
            this.lab_username.Size = new System.Drawing.Size(90, 23);
            this.lab_username.TabIndex = 3;
            this.lab_username.Text = "UserName:";
            // 
            // lab_status
            // 
            this.lab_status.AutoSize = true;
            this.lab_status.BackColor = System.Drawing.Color.Chartreuse;
            this.lab_status.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lab_status.Location = new System.Drawing.Point(9, 7);
            this.lab_status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_status.Name = "lab_status";
            this.lab_status.Size = new System.Drawing.Size(116, 23);
            this.lab_status.TabIndex = 2;
            this.lab_status.Text = "Out of service";
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.AutoSize = true;
            this.Close.BackColor = System.Drawing.SystemColors.Control;
            this.Close.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Close.Location = new System.Drawing.Point(881, 7);
            this.Close.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(22, 23);
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
            this.time.Location = new System.Drawing.Point(649, 7);
            this.time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(46, 23);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(910, 422);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_AddValue;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_ViewOrder;
        private System.Windows.Forms.Button btn_Staff;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Label lab_status;
        private System.Windows.Forms.Label lab_username;
        private System.Windows.Forms.Timer timer2;

    }
}