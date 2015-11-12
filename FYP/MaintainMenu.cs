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
    public partial class MaintainMenu : Form
    {
        private Main main;

        public MaintainMenu( Main main)
        {
            InitializeComponent();
            this.main = main;
            

            
               
        }

        private void MaintainMenu_Load(object sender, EventArgs e)
        {   
            DataTable dt_food = main.database.getDb("food where type = 'R'");
            DataTable dt_drink = main.database.getDb("food where type = 'D'");
            for (int i = 0; i < dt_food.Rows.Count; i++)
            {
                foodName.Items.Add(dt_food.Rows[i]["name"]);
            }
            for (int i = 0; i < dt_drink.Rows.Count; i++)
            {
                drinkName.Items.Add(dt_drink.Rows[i]["name"]);
            }
        }


    }
}
