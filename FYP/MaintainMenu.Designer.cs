namespace Login
{
    partial class MaintainMenu
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
            this.panel_left = new System.Windows.Forms.Panel();
            this.foodName = new System.Windows.Forms.CheckedListBox();
            this.search_food = new System.Windows.Forms.GroupBox();
            this.txt_fPrice = new System.Windows.Forms.TextBox();
            this.txt_fID = new System.Windows.Forms.TextBox();
            this.lab_FoodPrice = new System.Windows.Forms.Label();
            this.lab_FoodID = new System.Windows.Forms.Label();
            this.btn_fSearch = new System.Windows.Forms.Button();
            this.lab_food = new System.Windows.Forms.Label();
            this.panel_mid = new System.Windows.Forms.Panel();
            this.drinkName = new System.Windows.Forms.CheckedListBox();
            this.search_drink = new System.Windows.Forms.GroupBox();
            this.txt_dID = new System.Windows.Forms.TextBox();
            this.txt_dPrice = new System.Windows.Forms.TextBox();
            this.lab_drinkPrice = new System.Windows.Forms.Label();
            this.lab_drinkID = new System.Windows.Forms.Label();
            this.btn_dSearch = new System.Windows.Forms.Button();
            this.lab_drink = new System.Windows.Forms.Label();
            this.panel_right = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_sPrice = new System.Windows.Forms.TextBox();
            this.lab_setsPrice = new System.Windows.Forms.Label();
            this.lab_showDrinkName = new System.Windows.Forms.Label();
            this.lab_showFoodName = new System.Windows.Forms.Label();
            this.lab_discountDName = new System.Windows.Forms.Label();
            this.lab_discountfName = new System.Windows.Forms.Label();
            this.lab_info = new System.Windows.Forms.Label();
            this.lab_discount = new System.Windows.Forms.Label();
            this.panel_showDetail = new System.Windows.Forms.Panel();
            this.panel_left.SuspendLayout();
            this.search_food.SuspendLayout();
            this.panel_mid.SuspendLayout();
            this.search_drink.SuspendLayout();
            this.panel_right.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_left.Controls.Add(this.foodName);
            this.panel_left.Controls.Add(this.search_food);
            this.panel_left.Controls.Add(this.lab_food);
            this.panel_left.Location = new System.Drawing.Point(12, 28);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(310, 682);
            this.panel_left.TabIndex = 1;
            // 
            // foodName
            // 
            this.foodName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.foodName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodName.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.foodName.FormattingEnabled = true;
            this.foodName.Location = new System.Drawing.Point(0, 47);
            this.foodName.Name = "foodName";
            this.foodName.Size = new System.Drawing.Size(310, 416);
            this.foodName.TabIndex = 6;
            this.foodName.ThreeDCheckBoxes = true;
            this.foodName.SelectedIndexChanged += new System.EventHandler(this.foodName_SelectedIndexChanged);
            // 
            // search_food
            // 
            this.search_food.Controls.Add(this.txt_fPrice);
            this.search_food.Controls.Add(this.txt_fID);
            this.search_food.Controls.Add(this.lab_FoodPrice);
            this.search_food.Controls.Add(this.lab_FoodID);
            this.search_food.Controls.Add(this.btn_fSearch);
            this.search_food.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.search_food.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.search_food.Location = new System.Drawing.Point(0, 463);
            this.search_food.Name = "search_food";
            this.search_food.Size = new System.Drawing.Size(310, 219);
            this.search_food.TabIndex = 5;
            this.search_food.TabStop = false;
            this.search_food.Text = "Search";
            // 
            // txt_fPrice
            // 
            this.txt_fPrice.Location = new System.Drawing.Point(119, 86);
            this.txt_fPrice.Name = "txt_fPrice";
            this.txt_fPrice.Size = new System.Drawing.Size(177, 42);
            this.txt_fPrice.TabIndex = 8;
            // 
            // txt_fID
            // 
            this.txt_fID.Location = new System.Drawing.Point(119, 35);
            this.txt_fID.Name = "txt_fID";
            this.txt_fID.Size = new System.Drawing.Size(177, 42);
            this.txt_fID.TabIndex = 7;
            // 
            // lab_FoodPrice
            // 
            this.lab_FoodPrice.AutoSize = true;
            this.lab_FoodPrice.Location = new System.Drawing.Point(10, 86);
            this.lab_FoodPrice.Name = "lab_FoodPrice";
            this.lab_FoodPrice.Size = new System.Drawing.Size(81, 34);
            this.lab_FoodPrice.TabIndex = 6;
            this.lab_FoodPrice.Text = "Price:";
            // 
            // lab_FoodID
            // 
            this.lab_FoodID.AutoSize = true;
            this.lab_FoodID.Location = new System.Drawing.Point(6, 38);
            this.lab_FoodID.Name = "lab_FoodID";
            this.lab_FoodID.Size = new System.Drawing.Size(107, 34);
            this.lab_FoodID.TabIndex = 5;
            this.lab_FoodID.Text = "Food id:";
            // 
            // btn_fSearch
            // 
            this.btn_fSearch.AutoSize = true;
            this.btn_fSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_fSearch.Location = new System.Drawing.Point(3, 172);
            this.btn_fSearch.Name = "btn_fSearch";
            this.btn_fSearch.Size = new System.Drawing.Size(304, 44);
            this.btn_fSearch.TabIndex = 2;
            this.btn_fSearch.Text = "Search";
            this.btn_fSearch.UseVisualStyleBackColor = true;
            // 
            // lab_food
            // 
            this.lab_food.AutoSize = true;
            this.lab_food.Dock = System.Windows.Forms.DockStyle.Top;
            this.lab_food.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.lab_food.Location = new System.Drawing.Point(0, 0);
            this.lab_food.Name = "lab_food";
            this.lab_food.Size = new System.Drawing.Size(97, 47);
            this.lab_food.TabIndex = 1;
            this.lab_food.Text = "Food";
            // 
            // panel_mid
            // 
            this.panel_mid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_mid.Controls.Add(this.drinkName);
            this.panel_mid.Controls.Add(this.search_drink);
            this.panel_mid.Controls.Add(this.lab_drink);
            this.panel_mid.Location = new System.Drawing.Point(400, 28);
            this.panel_mid.Name = "panel_mid";
            this.panel_mid.Size = new System.Drawing.Size(310, 682);
            this.panel_mid.TabIndex = 2;
            // 
            // drinkName
            // 
            this.drinkName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.drinkName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drinkName.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.drinkName.FormattingEnabled = true;
            this.drinkName.Location = new System.Drawing.Point(0, 47);
            this.drinkName.Name = "drinkName";
            this.drinkName.Size = new System.Drawing.Size(310, 416);
            this.drinkName.TabIndex = 8;
            this.drinkName.SelectedIndexChanged += new System.EventHandler(this.drinkName_SelectedIndexChanged);
            // 
            // search_drink
            // 
            this.search_drink.Controls.Add(this.txt_dID);
            this.search_drink.Controls.Add(this.txt_dPrice);
            this.search_drink.Controls.Add(this.lab_drinkPrice);
            this.search_drink.Controls.Add(this.lab_drinkID);
            this.search_drink.Controls.Add(this.btn_dSearch);
            this.search_drink.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.search_drink.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.search_drink.Location = new System.Drawing.Point(0, 463);
            this.search_drink.Name = "search_drink";
            this.search_drink.Size = new System.Drawing.Size(310, 219);
            this.search_drink.TabIndex = 7;
            this.search_drink.TabStop = false;
            this.search_drink.Text = "Search";
            // 
            // txt_dID
            // 
            this.txt_dID.Location = new System.Drawing.Point(127, 32);
            this.txt_dID.Name = "txt_dID";
            this.txt_dID.Size = new System.Drawing.Size(177, 42);
            this.txt_dID.TabIndex = 9;
            // 
            // txt_dPrice
            // 
            this.txt_dPrice.Location = new System.Drawing.Point(127, 80);
            this.txt_dPrice.Name = "txt_dPrice";
            this.txt_dPrice.Size = new System.Drawing.Size(177, 42);
            this.txt_dPrice.TabIndex = 10;
            // 
            // lab_drinkPrice
            // 
            this.lab_drinkPrice.AutoSize = true;
            this.lab_drinkPrice.Location = new System.Drawing.Point(10, 76);
            this.lab_drinkPrice.Name = "lab_drinkPrice";
            this.lab_drinkPrice.Size = new System.Drawing.Size(81, 34);
            this.lab_drinkPrice.TabIndex = 8;
            this.lab_drinkPrice.Text = "Price:";
            // 
            // lab_drinkID
            // 
            this.lab_drinkID.AutoSize = true;
            this.lab_drinkID.Location = new System.Drawing.Point(6, 32);
            this.lab_drinkID.Name = "lab_drinkID";
            this.lab_drinkID.Size = new System.Drawing.Size(115, 34);
            this.lab_drinkID.TabIndex = 7;
            this.lab_drinkID.Text = "Drink id:";
            // 
            // btn_dSearch
            // 
            this.btn_dSearch.AutoSize = true;
            this.btn_dSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_dSearch.Location = new System.Drawing.Point(3, 172);
            this.btn_dSearch.Name = "btn_dSearch";
            this.btn_dSearch.Size = new System.Drawing.Size(304, 44);
            this.btn_dSearch.TabIndex = 4;
            this.btn_dSearch.Text = "Search";
            this.btn_dSearch.UseVisualStyleBackColor = true;
            // 
            // lab_drink
            // 
            this.lab_drink.AutoSize = true;
            this.lab_drink.Dock = System.Windows.Forms.DockStyle.Top;
            this.lab_drink.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.lab_drink.Location = new System.Drawing.Point(0, 0);
            this.lab_drink.Name = "lab_drink";
            this.lab_drink.Size = new System.Drawing.Size(107, 47);
            this.lab_drink.TabIndex = 3;
            this.lab_drink.Text = "Drink";
            // 
            // panel_right
            // 
            this.panel_right.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_right.Controls.Add(this.btn_save);
            this.panel_right.Controls.Add(this.txt_sPrice);
            this.panel_right.Controls.Add(this.lab_setsPrice);
            this.panel_right.Controls.Add(this.lab_showDrinkName);
            this.panel_right.Controls.Add(this.lab_showFoodName);
            this.panel_right.Controls.Add(this.lab_discountDName);
            this.panel_right.Controls.Add(this.lab_discountfName);
            this.panel_right.Controls.Add(this.lab_info);
            this.panel_right.Controls.Add(this.lab_discount);
            this.panel_right.Location = new System.Drawing.Point(1143, 28);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(341, 679);
            this.panel_right.TabIndex = 4;
            // 
            // btn_save
            // 
            this.btn_save.AutoSize = true;
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_save.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.btn_save.Location = new System.Drawing.Point(0, 635);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(341, 44);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_sPrice
            // 
            this.txt_sPrice.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.txt_sPrice.Location = new System.Drawing.Point(226, 548);
            this.txt_sPrice.Name = "txt_sPrice";
            this.txt_sPrice.Size = new System.Drawing.Size(147, 42);
            this.txt_sPrice.TabIndex = 7;
            this.txt_sPrice.Text = "0";
            // 
            // lab_setsPrice
            // 
            this.lab_setsPrice.AutoSize = true;
            this.lab_setsPrice.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.lab_setsPrice.Location = new System.Drawing.Point(18, 545);
            this.lab_setsPrice.Name = "lab_setsPrice";
            this.lab_setsPrice.Size = new System.Drawing.Size(202, 42);
            this.lab_setsPrice.TabIndex = 6;
            this.lab_setsPrice.Text = "Special price:";
            // 
            // lab_showDrinkName
            // 
            this.lab_showDrinkName.AutoSize = true;
            this.lab_showDrinkName.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.lab_showDrinkName.Location = new System.Drawing.Point(19, 489);
            this.lab_showDrinkName.Name = "lab_showDrinkName";
            this.lab_showDrinkName.Size = new System.Drawing.Size(135, 34);
            this.lab_showDrinkName.TabIndex = 5;
            this.lab_showDrinkName.Text = "drinkname";
            // 
            // lab_showFoodName
            // 
            this.lab_showFoodName.AutoSize = true;
            this.lab_showFoodName.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.lab_showFoodName.Location = new System.Drawing.Point(18, 410);
            this.lab_showFoodName.Name = "lab_showFoodName";
            this.lab_showFoodName.Size = new System.Drawing.Size(128, 34);
            this.lab_showFoodName.TabIndex = 4;
            this.lab_showFoodName.Text = "foodname";
            // 
            // lab_discountDName
            // 
            this.lab_discountDName.AutoSize = true;
            this.lab_discountDName.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.lab_discountDName.Location = new System.Drawing.Point(18, 447);
            this.lab_discountDName.Name = "lab_discountDName";
            this.lab_discountDName.Size = new System.Drawing.Size(189, 42);
            this.lab_discountDName.TabIndex = 3;
            this.lab_discountDName.Text = "Drink Name:";
            // 
            // lab_discountfName
            // 
            this.lab_discountfName.AutoSize = true;
            this.lab_discountfName.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.lab_discountfName.Location = new System.Drawing.Point(18, 368);
            this.lab_discountfName.Name = "lab_discountfName";
            this.lab_discountfName.Size = new System.Drawing.Size(181, 42);
            this.lab_discountfName.TabIndex = 2;
            this.lab_discountfName.Text = "Food Name:";
            // 
            // lab_info
            // 
            this.lab_info.AutoSize = true;
            this.lab_info.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.lab_info.Location = new System.Drawing.Point(17, 94);
            this.lab_info.Name = "lab_info";
            this.lab_info.Size = new System.Drawing.Size(709, 188);
            this.lab_info.TabIndex = 1;
            this.lab_info.Text = "1: Choose Food(s)\r\n2: Choose Drink(s)\r\n3: Set special price for diccount\r\n    (de" +
                "fault 0 and it will cast to \"Freedrink\")";
            // 
            // lab_discount
            // 
            this.lab_discount.AutoSize = true;
            this.lab_discount.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.lab_discount.Location = new System.Drawing.Point(17, 35);
            this.lab_discount.Name = "lab_discount";
            this.lab_discount.Size = new System.Drawing.Size(159, 47);
            this.lab_discount.TabIndex = 0;
            this.lab_discount.Text = "Discount";
            // 
            // panel_showDetail
            // 
            this.panel_showDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_showDetail.Location = new System.Drawing.Point(750, 28);
            this.panel_showDetail.Name = "panel_showDetail";
            this.panel_showDetail.Size = new System.Drawing.Size(365, 679);
            this.panel_showDetail.TabIndex = 3;
            // 
            // MaintainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 722);
            this.Controls.Add(this.panel_showDetail);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.panel_mid);
            this.Controls.Add(this.panel_left);
            this.Name = "MaintainMenu";
            this.Text = "MaintainMenu";
            this.Load += new System.EventHandler(this.MaintainMenu_Load);
            this.panel_left.ResumeLayout(false);
            this.panel_left.PerformLayout();
            this.search_food.ResumeLayout(false);
            this.search_food.PerformLayout();
            this.panel_mid.ResumeLayout(false);
            this.panel_mid.PerformLayout();
            this.search_drink.ResumeLayout(false);
            this.search_drink.PerformLayout();
            this.panel_right.ResumeLayout(false);
            this.panel_right.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Label lab_food;
        private System.Windows.Forms.Panel panel_mid;
        private System.Windows.Forms.Label lab_drink;
        private System.Windows.Forms.CheckedListBox foodName;
        private System.Windows.Forms.GroupBox search_food;
        private System.Windows.Forms.TextBox txt_fPrice;
        private System.Windows.Forms.TextBox txt_fID;
        private System.Windows.Forms.Label lab_FoodPrice;
        private System.Windows.Forms.Label lab_FoodID;
        private System.Windows.Forms.Button btn_fSearch;
        private System.Windows.Forms.CheckedListBox drinkName;
        private System.Windows.Forms.GroupBox search_drink;
        private System.Windows.Forms.TextBox txt_dID;
        private System.Windows.Forms.TextBox txt_dPrice;
        private System.Windows.Forms.Label lab_drinkPrice;
        private System.Windows.Forms.Label lab_drinkID;
        private System.Windows.Forms.Button btn_dSearch;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.Label lab_showFoodName;
        private System.Windows.Forms.Label lab_discountDName;
        private System.Windows.Forms.Label lab_discountfName;
        private System.Windows.Forms.Label lab_info;
        private System.Windows.Forms.Label lab_discount;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_sPrice;
        private System.Windows.Forms.Label lab_setsPrice;
        private System.Windows.Forms.Label lab_showDrinkName;
        private System.Windows.Forms.Panel panel_showDetail;


    }
}