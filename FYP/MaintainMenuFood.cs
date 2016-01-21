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
    }
}
