﻿namespace Login
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
            this.gb_OrderStatus = new System.Windows.Forms.GroupBox();
            this.gbFunction = new System.Windows.Forms.GroupBox();
            this.gb_foobType = new System.Windows.Forms.GroupBox();
            this.gb_Information = new System.Windows.Forms.GroupBox();
            this.lbl_tov = new System.Windows.Forms.Label();
            this.FLP1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gb1.SuspendLayout();
            this.gb_Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.gb_OrderStatus);
            this.gb1.Controls.Add(this.gbFunction);
            this.gb1.Controls.Add(this.gb_foobType);
            this.gb1.Controls.Add(this.gb_Information);
            this.gb1.Location = new System.Drawing.Point(1206, 13);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(170, 660);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
            this.gb1.Text = "filter";
            // 
            // gb_OrderStatus
            // 
            this.gb_OrderStatus.Location = new System.Drawing.Point(7, 528);
            this.gb_OrderStatus.Name = "gb_OrderStatus";
            this.gb_OrderStatus.Size = new System.Drawing.Size(200, 100);
            this.gb_OrderStatus.TabIndex = 5;
            this.gb_OrderStatus.TabStop = false;
            this.gb_OrderStatus.Text = "Order Status";
            // 
            // gbFunction
            // 
            this.gbFunction.Location = new System.Drawing.Point(7, 140);
            this.gbFunction.Name = "gbFunction";
            this.gbFunction.Size = new System.Drawing.Size(138, 242);
            this.gbFunction.TabIndex = 1;
            this.gbFunction.TabStop = false;
            this.gbFunction.Text = "Take Time";
            // 
            // gb_foobType
            // 
            this.gb_foobType.Location = new System.Drawing.Point(17, 388);
            this.gb_foobType.Name = "gb_foobType";
            this.gb_foobType.Size = new System.Drawing.Size(137, 145);
            this.gb_foobType.TabIndex = 4;
            this.gb_foobType.TabStop = false;
            this.gb_foobType.Text = "Food Type";
            // 
            // gb_Information
            // 
            this.gb_Information.Controls.Add(this.lbl_tov);
            this.gb_Information.Location = new System.Drawing.Point(7, 19);
            this.gb_Information.Name = "gb_Information";
            this.gb_Information.Size = new System.Drawing.Size(137, 104);
            this.gb_Information.TabIndex = 3;
            this.gb_Information.TabStop = false;
            this.gb_Information.Text = "Information";
            
            // 
            // lbl_tov
            // 
            this.lbl_tov.AutoSize = true;
            this.lbl_tov.Location = new System.Drawing.Point(7, 20);
            this.lbl_tov.Name = "lbl_tov";
            this.lbl_tov.Size = new System.Drawing.Size(93, 13);
            this.lbl_tov.TabIndex = 0;
            this.lbl_tov.Text = "Total Order Value:";
            // 
            // FLP1
            // 
            this.FLP1.AutoScroll = true;
            this.FLP1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FLP1.Location = new System.Drawing.Point(12, 13);
            this.FLP1.Name = "FLP1";
            this.FLP1.Size = new System.Drawing.Size(735, 489);
            this.FLP1.TabIndex = 2;
            // 
            // kitchenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 796);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.FLP1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kitchenView";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.kitchenView_Load);
            this.gb1.ResumeLayout(false);
            this.gb_Information.ResumeLayout(false);
            this.gb_Information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.FlowLayoutPanel FLP1;
        private System.Windows.Forms.GroupBox gb_Information;
        private System.Windows.Forms.Label lbl_tov;
        private System.Windows.Forms.GroupBox gb_foobType;
        private System.Windows.Forms.GroupBox gb_OrderStatus;
        private System.Windows.Forms.GroupBox gbFunction;
    }
}