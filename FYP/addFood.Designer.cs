namespace Login
{
    partial class addFood
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
            this.button1 = new System.Windows.Forms.Button();
            this.combo_ISShow = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_category = new System.Windows.Forms.Button();
            this.combo_FoodType = new System.Windows.Forms.ComboBox();
            this.num_price = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.num_SPrice = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_shortName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.num_DQTY = new System.Windows.Forms.NumericUpDown();
            this.num_QTY = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_SPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_DQTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_QTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.button1.Location = new System.Drawing.Point(468, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 40);
            this.button1.TabIndex = 41;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // combo_ISShow
            // 
            this.combo_ISShow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_ISShow.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.combo_ISShow.FormattingEnabled = true;
            this.combo_ISShow.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.combo_ISShow.Location = new System.Drawing.Point(218, 496);
            this.combo_ISShow.Name = "combo_ISShow";
            this.combo_ISShow.Size = new System.Drawing.Size(51, 36);
            this.combo_ISShow.TabIndex = 39;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btn_cancel.Location = new System.Drawing.Point(427, 544);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(141, 35);
            this.btn_cancel.TabIndex = 38;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btn_save.Location = new System.Drawing.Point(218, 544);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(141, 35);
            this.btn_save.TabIndex = 37;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_category
            // 
            this.btn_category.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.btn_category.Location = new System.Drawing.Point(468, 442);
            this.btn_category.Name = "btn_category";
            this.btn_category.Size = new System.Drawing.Size(141, 35);
            this.btn_category.TabIndex = 36;
            this.btn_category.Text = "Food Type";
            this.btn_category.UseVisualStyleBackColor = true;
            // 
            // combo_FoodType
            // 
            this.combo_FoodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_FoodType.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.combo_FoodType.FormattingEnabled = true;
            this.combo_FoodType.Location = new System.Drawing.Point(218, 441);
            this.combo_FoodType.Name = "combo_FoodType";
            this.combo_FoodType.Size = new System.Drawing.Size(211, 36);
            this.combo_FoodType.TabIndex = 35;
            // 
            // num_price
            // 
            this.num_price.DecimalPlaces = 1;
            this.num_price.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.num_price.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_price.Location = new System.Drawing.Point(224, 249);
            this.num_price.Name = "num_price";
            this.num_price.Size = new System.Drawing.Size(68, 35);
            this.num_price.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label8.Location = new System.Drawing.Point(26, 504);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 28);
            this.label8.TabIndex = 32;
            this.label8.Text = "Is Show:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label7.Location = new System.Drawing.Point(26, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 28);
            this.label7.TabIndex = 31;
            this.label7.Text = "Food Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label6.Location = new System.Drawing.Point(26, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 28);
            this.label6.TabIndex = 30;
            this.label6.Text = "Food Img:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label4.Location = new System.Drawing.Point(32, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "Food Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label2.Location = new System.Drawing.Point(24, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 30);
            this.label2.TabIndex = 26;
            this.label2.Text = "Food Info:";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txt_id.Location = new System.Drawing.Point(224, 67);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(444, 35);
            this.txt_id.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label3.Location = new System.Drawing.Point(32, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "Food ID:";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txt_Name.Location = new System.Drawing.Point(224, 124);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(444, 35);
            this.txt_Name.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label1.Location = new System.Drawing.Point(32, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Food Name:";
            // 
            // num_SPrice
            // 
            this.num_SPrice.DecimalPlaces = 1;
            this.num_SPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.num_SPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_SPrice.Location = new System.Drawing.Point(500, 249);
            this.num_SPrice.Name = "num_SPrice";
            this.num_SPrice.Size = new System.Drawing.Size(68, 35);
            this.num_SPrice.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label9.Location = new System.Drawing.Point(332, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 28);
            this.label9.TabIndex = 43;
            this.label9.Text = "Food Set Price:";
            // 
            // txt_shortName
            // 
            this.txt_shortName.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txt_shortName.Location = new System.Drawing.Point(224, 190);
            this.txt_shortName.Name = "txt_shortName";
            this.txt_shortName.Size = new System.Drawing.Size(444, 35);
            this.txt_shortName.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label5.Location = new System.Drawing.Point(32, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 28);
            this.label5.TabIndex = 44;
            this.label5.Text = "Food Short Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label10.Location = new System.Drawing.Point(332, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 28);
            this.label10.TabIndex = 49;
            this.label10.Text = "Default QTY";
            // 
            // num_DQTY
            // 
            this.num_DQTY.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.num_DQTY.Location = new System.Drawing.Point(500, 302);
            this.num_DQTY.Name = "num_DQTY";
            this.num_DQTY.Size = new System.Drawing.Size(68, 35);
            this.num_DQTY.TabIndex = 48;
            // 
            // num_QTY
            // 
            this.num_QTY.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.num_QTY.Location = new System.Drawing.Point(224, 302);
            this.num_QTY.Name = "num_QTY";
            this.num_QTY.Size = new System.Drawing.Size(68, 35);
            this.num_QTY.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label11.Location = new System.Drawing.Point(32, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 28);
            this.label11.TabIndex = 46;
            this.label11.Text = "QTY:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(211, 354);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 84);
            this.flowLayoutPanel1.TabIndex = 50;
            this.flowLayoutPanel1.Visible = false;
            this.flowLayoutPanel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pic_Img_DragDrop);
            this.flowLayoutPanel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pic_Img_DragEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(211, 354);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // addFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 596);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.num_DQTY);
            this.Controls.Add(this.num_QTY);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_shortName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.num_SPrice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.combo_ISShow);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_category);
            this.Controls.Add(this.combo_FoodType);
            this.Controls.Add(this.num_price);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label1);
            this.Name = "addFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addFood";
            this.Load += new System.EventHandler(this.addFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_SPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_DQTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_QTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox combo_ISShow;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_category;
        private System.Windows.Forms.ComboBox combo_FoodType;
        private System.Windows.Forms.NumericUpDown num_price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_SPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_shortName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown num_DQTY;
        private System.Windows.Forms.NumericUpDown num_QTY;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}