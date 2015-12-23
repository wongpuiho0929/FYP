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
        public  Database db;
        public  List<CheckBox> CheckBoxes = new List<CheckBox>();
        private DataTable chkbox ;
        public  String sql="";


        public MaintainMenu(Main main)
        {
            InitializeComponent();
            this.main = main;
            db = main.db;
            
        }

        public  void MaintainMenu_Load(object sender, EventArgs e)
        {
            int intialTop = 50;
            chkbox = db.getDb("Foodtype");
            for (int i = 0; i < chkbox.Rows.Count; i++)
            {
                CheckBox chk = new CheckBox();
                chk.Left = 5;
                chk.Top = intialTop;
                chk.Text = chkbox.Rows[i]["name"].ToString();
                chk.Name = "chk_"+chk.Text;
                chk.Click += new EventHandler(checkBoxA_Click);
                groupBox1.Controls.Add(chk);
                CheckBoxes.Add(chk);
                intialTop += 20;
                combo_foodType.Items.Add(chkbox.Rows[i]["name"].ToString());
            }
            

        }
        private void checkBoxA_Click(object sender, EventArgs e)
        {
            String temp = ((CheckBox)sender).Text;
            for (int i = 0; i < CheckBoxes.Count; i++) {
                if (CheckBoxes[i].Text.Equals(temp)) {
                    for (int k = 0; k < chkbox.Rows.Count; k++)
                    {
                        if (chkbox.Rows[k]["name"].Equals(temp))
                        {
                            temp = chkbox.Rows[k]["ftypeid"].ToString();
                        }
                    }
                    if (CheckBoxes[i].Checked)
                    {
                        query("ftypeid='" + temp + "'");
                    }
                    else {
                        query1("ftypeid='" + temp + "'");
                    }
                }
            }
            
        }

        private void chk_N_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_N.Checked)
            {
                query("isShow='N'");
            }
            else {
                query1("isShow='N'");
            }
        }

        private void chk_Y_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Y.Checked)
            {
                query("isShow='Y'");
            }
            else {
                query1("isShow='Y'");
            }
        }

        private void query(String s) {
            if (sql != "")
            {
                sql += " OR " + s;
            }
            else {
                sql = s;
            }
            SearchByChk(sql);
        }
        private void query1(String s)
        {
            if (sql.Contains("OR"))
            {
                sql = sql.Replace(" OR "+s,"");
                sql = sql.Replace(s+" OR ", "");
            }
            else
            {
                sql = "";
            }
            SearchByChk(sql);
        }
        
        private void SearchByChk(String s) {
            if (s != "")
            {
                DataTable food = db.getDb("Food where " + s);
                DGW_show.DataSource = food;
            }
            else {
                DGW_show.DataSource = null;
            }
        }

        private void DGW_show_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = DGW_show.SelectedRows[0];
                txt_FID.Text = row.Cells[0].Value.ToString();
                txt_FName.Text = row.Cells[1].Value.ToString();
                num_price.Value = Convert.ToDecimal(row.Cells[2].Value.ToString());
                num_SPrice.Value = Convert.ToDecimal(row.Cells[3].Value.ToString());
                num_qty.Value = Convert.ToDecimal(row.Cells[5].Value.ToString());
                num_dQty.Value = Convert.ToDecimal(row.Cells[6].Value.ToString());
                for (int i = 0; i < chkbox.Rows.Count; i++)
                {
                    if (chkbox.Rows[i]["ftypeid"].Equals(row.Cells[7].Value.ToString()))
                    {
                        combo_foodType.SelectedIndex = combo_foodType.Items.IndexOf(chkbox.Rows[i]["name"].ToString());
                        break;
                    }
                }
                combo_isShow.SelectedIndex = combo_isShow.Items.IndexOf(row.Cells[8].Value.ToString());
            }catch(Exception){
            }
        }

        private void btn_maintain_Click(object sender, EventArgs e)
        {
            TrueFalse(true);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveChanging();
            TrueFalse(false);
        }

        private void TrueFalse(Boolean s) {
            txt_FName.Enabled = s;
            num_price.Enabled = s;
            num_qty.Enabled = s;
            num_SPrice.Enabled = s;
            num_dQty.Enabled = s;
            combo_foodType.Enabled = s;
            combo_isShow.Enabled = s;
            btn_save.Visible = s;
        }

        private void SaveChanging() {
            String FName =txt_FName.Text;
            Double price = Convert.ToDouble(num_price.Value);
            Double SPrice = Convert.ToDouble(num_SPrice.Value);
            int qty = Convert.ToInt32(num_qty.Value);
            int dqty = Convert.ToInt32(num_dQty.Value);
            String Ftype = combo_foodType.SelectedItem.ToString();
             for (int i = 0; i < chkbox.Rows.Count; i++)
                {
                    if (chkbox.Rows[i]["name"].Equals(Ftype))
                    {
                         Ftype = chkbox.Rows[i]["ftypeid"].ToString();
                        break;
                    }
                }
            String isShow = combo_isShow.SelectedItem.ToString();
            String FID  = txt_FID.Text;
            String s = "UPDATE `food` SET `name`='" + FName + "',`price`=" + price + ",`sPrice`=" + SPrice + ",`qty`=" + qty + ",`dQty`=" + dqty + ",`fTypeId`='" + Ftype + "',`isShow`='" + isShow + " 'WHERE foodid='" + FID + "';";
            db.queny(s);
            
            SearchByChk(sql);
        }



        private void btn_FoodType_Click_1(object sender, EventArgs e)
        {
            FoodType ft = new FoodType(this);
            ft.ShowDialog();
        }
       
        

      

       
        
    }
}
