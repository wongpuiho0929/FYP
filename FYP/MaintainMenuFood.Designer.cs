namespace Login
{
    partial class MaintainMenuFood
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
            this.chkedListBox_FoodType = new System.Windows.Forms.CheckedListBox();
            this.lab_FType = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkedListBox_FoodType
            // 
            this.chkedListBox_FoodType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkedListBox_FoodType.FormattingEnabled = true;
            this.chkedListBox_FoodType.IntegralHeight = false;
            this.chkedListBox_FoodType.Location = new System.Drawing.Point(0, 30);
            this.chkedListBox_FoodType.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkedListBox_FoodType.MultiColumn = true;
            this.chkedListBox_FoodType.Name = "chkedListBox_FoodType";
            this.chkedListBox_FoodType.Size = new System.Drawing.Size(1536, 968);
            this.chkedListBox_FoodType.TabIndex = 41;
            // 
            // lab_FType
            // 
            this.lab_FType.AutoSize = true;
            this.lab_FType.Dock = System.Windows.Forms.DockStyle.Top;
            this.lab_FType.Location = new System.Drawing.Point(0, 0);
            this.lab_FType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_FType.Name = "lab_FType";
            this.lab_FType.Size = new System.Drawing.Size(171, 30);
            this.lab_FType.TabIndex = 40;
            this.lab_FType.Text = "Set Food Type:";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Azure;
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Location = new System.Drawing.Point(0, 955);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(1536, 43);
            this.btn_Save.TabIndex = 42;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // MaintainMenuFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1536, 998);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.chkedListBox_FoodType);
            this.Controls.Add(this.lab_FType);
            this.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MaintainMenuFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MaintainMenuFood";
            this.Load += new System.EventHandler(this.MaintainMenuFood_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkedListBox_FoodType;
        private System.Windows.Forms.Label lab_FType;
        private System.Windows.Forms.Button btn_Save;
    }
}