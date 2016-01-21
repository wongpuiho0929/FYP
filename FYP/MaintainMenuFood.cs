using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class MaintainMenuFood : Form
    {
        private MaintainMenu menu;
        private Database db;
        private List<Label> labels = new List<Label>();

        public MaintainMenuFood(MaintainMenu menu)
        {
            InitializeComponent();
            this.menu = menu;
            db = menu.db;
        }

        private void MaintainMenuFood_Load(object sender, EventArgs e)
        {
            DataTable dt_FoodType = db.getDb("FoodType");
            for (int i = 0; i < dt_FoodType.Rows.Count; i++)
            {
                chkedListBox_FoodType.Items.Add(dt_FoodType.Rows[i]["name"]);
            }
        }

        private void btn_NEXT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + chkedListBox_FoodType.CheckedItems[0]);
            int intialTop = 20;
            for(int i=0;i<chkedListBox_FoodType.CheckedItems.Count;i++){
                Label s = new Label();
                s.Left = 5;
                s.Top = intialTop;
                s.Name = "Label" + i;
                s.Text = chkedListBox_FoodType.CheckedItems[i].ToString();
                flowLayoutPanel1.Controls.Add(s);
                labels.Add(s);
                intialTop += 20;
            }
            lab_NumberOfIem.Visible = true;
            flowLayoutPanel1.Visible = true;
            
        }


    }
}
