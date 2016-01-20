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
    public partial class FoodType : Form
    {
        MaintainMenu menu;
        Database db;


        public FoodType(MaintainMenu menu)
        {
            InitializeComponent();
            this.menu = menu;
            db = menu.db;
        }

        private void FoodType_Load(object sender, EventArgs e)
        {
            DataTable dt_FoodType = db.getDb("Foodtype");
            dataGridView1.DataSource = dt_FoodType;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                txt_FtID.Text = row.Cells[0].Value.ToString();
                txt_FtName.Text = row.Cells[1].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void btn_maintain_Click(object sender, EventArgs e)
        {
            TrueFalse(true);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveChanging();
            TrueFalse(false);
        }

        private void TrueFalse(Boolean s)
        {
            txt_FtName.Enabled = s;
            btn_Save.Visible = s;
           
        }


        private void SaveChanging()
        {
            String FtName = txt_FtName.Text;
            String FtID = txt_FtID.Text;
            String s = "UPDATE `foodtype` SET `name`='" + FtName + "'WHERE fTypeId='" + FtID + "';";
            db.queny(s);
            DataTable dt_FoodType = db.getDb("Foodtype");
            dataGridView1.DataSource = dt_FoodType;
        }

        private void FoodType_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.CheckBoxes.Clear();
            menu.sql = "";
            menu.combo_foodType.Items.Clear();
            menu.groupBox1.Controls.Clear();
            menu.MaintainMenu_Load(sender, e);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DataTable dt_FoodType = db.getDb("Foodtype order by ftypeid ASC");
            String FtID = dt_FoodType.Rows[dt_FoodType.Rows.Count - 1]["ftypeid"].ToString();
            String str = ""+(Convert.ToInt32(FtID.Substring(2))+1);
            String pad = "00000000";
            String ans = pad.Substring(0, pad.Length - str.Length) + str;
            String FtIDnum = "FT"+ans ;
            txt_FtID.Text = FtIDnum;
            txt_FtName.Text = "";
            txt_FtName.Enabled = true;
            btn_addSave.Visible = true;
            btn_maintain.Enabled = false;
        }

        private void btn_addSave_Click(object sender, EventArgs e)
        {
            if (!txt_FtName.Text.Equals(""))
            {
                String s = "INSERT INTO `foodtype`(`fTypeId`, `name`) VALUES ('" + txt_FtID.Text + "','" + txt_FtName.Text + "')";
                db.queny(s);
                txt_FtName.Enabled = false;
                btn_addSave.Visible = false;
                btn_maintain.Enabled = true;
                FoodType_Load(sender, e);
            }
            else { 
                MessageBox.Show("Enter Food Type Name.");
            }
        }


    }
}
