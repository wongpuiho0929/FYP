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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_left.SuspendLayout();
            this.search_food.SuspendLayout();
            this.panel_mid.SuspendLayout();
            this.search_drink.SuspendLayout();
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
            this.panel_left.Size = new System.Drawing.Size(321, 682);
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
            this.foodName.Size = new System.Drawing.Size(321, 416);
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
            this.search_food.Size = new System.Drawing.Size(321, 219);
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
            this.btn_fSearch.Size = new System.Drawing.Size(315, 44);
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
            this.panel_mid.Location = new System.Drawing.Point(762, 28);
            this.panel_mid.Name = "panel_mid";
            this.panel_mid.Size = new System.Drawing.Size(321, 682);
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
            this.drinkName.Size = new System.Drawing.Size(321, 416);
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
            this.search_drink.Size = new System.Drawing.Size(321, 219);
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
            this.btn_dSearch.Size = new System.Drawing.Size(315, 44);
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(358, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 679);
            this.panel1.TabIndex = 3;
            // 
            // MaintainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 722);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Panel panel1;


    }
}