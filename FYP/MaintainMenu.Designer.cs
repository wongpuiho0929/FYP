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
            this.foodName = new System.Windows.Forms.CheckedListBox();
            this.panel_left = new System.Windows.Forms.Panel();
            this.lab_food = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.lab_drink = new System.Windows.Forms.Label();
            this.drinkName = new System.Windows.Forms.CheckedListBox();
            this.panel_left.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // foodName
            // 
            this.foodName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.foodName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodName.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.foodName.FormattingEnabled = true;
            this.foodName.Location = new System.Drawing.Point(0, 47);
            this.foodName.Name = "foodName";
            this.foodName.Size = new System.Drawing.Size(310, 389);
            this.foodName.TabIndex = 0;
            // 
            // panel_left
            // 
            this.panel_left.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_left.Controls.Add(this.foodName);
            this.panel_left.Controls.Add(this.lab_food);
            this.panel_left.Location = new System.Drawing.Point(12, 12);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(310, 436);
            this.panel_left.TabIndex = 1;
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
            // panel_top
            // 
            this.panel_top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_top.Controls.Add(this.drinkName);
            this.panel_top.Controls.Add(this.lab_drink);
            this.panel_top.Location = new System.Drawing.Point(400, 12);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(310, 436);
            this.panel_top.TabIndex = 2;
            // 
            // lab_drink
            // 
            this.lab_drink.AutoSize = true;
            this.lab_drink.Dock = System.Windows.Forms.DockStyle.Top;
            this.lab_drink.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.lab_drink.Location = new System.Drawing.Point(0, 0);
            this.lab_drink.Name = "lab_drink";
            this.lab_drink.Size = new System.Drawing.Size(107, 47);
            this.lab_drink.TabIndex = 2;
            this.lab_drink.Text = "Drink";
            // 
            // drinkName
            // 
            this.drinkName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.drinkName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drinkName.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.drinkName.FormattingEnabled = true;
            this.drinkName.Location = new System.Drawing.Point(0, 47);
            this.drinkName.Name = "drinkName";
            this.drinkName.Size = new System.Drawing.Size(310, 389);
            this.drinkName.TabIndex = 3;
            // 
            // MaintainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 460);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_left);
            this.Name = "MaintainMenu";
            this.Text = "MaintainMenu";
            this.Load += new System.EventHandler(this.MaintainMenu_Load);
            this.panel_left.ResumeLayout(false);
            this.panel_left.PerformLayout();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox foodName;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Label lab_food;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.CheckedListBox drinkName;
        private System.Windows.Forms.Label lab_drink;


    }
}