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
        private Boolean chick = false;


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

             //------------------------Menu------------------------------//
            DataTable dt_menu = db.getDb("menu");
            DataTable dt_menuCategory = db.getDb("menuCategory");
            combo_MenuName.Items.Clear();
            combo_MenuCategory.Items.Clear();
            for (int i = 0; i < dt_menu.Rows.Count; i++)
            {
                combo_MenuName.Items.Add(dt_menu.Rows[i]["name"].ToString());
            }
            for (int i = 0; i < dt_menuCategory.Rows.Count; i++) {
                combo_MenuCategory.Items.Add(dt_menuCategory.Rows[i]["name"].ToString());
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


        //---------------------Menu----------------------------------------------//
        private void combo_Mame_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt_menu = db.getDb("menu");
            DataTable dt_menuCategory = db.getDb("menuCategory");
            for(int i =0;i<dt_menu.Rows.Count;i++){
                if(combo_MenuName.Text.Equals(dt_menu.Rows[i]["name"]))
                {
                    txt_MenuID.Text = dt_menu.Rows[i]["menuId"].ToString();
                    txt_menuName.Text = dt_menu.Rows[i]["name"].ToString();
                    for (int k = 0; k < dt_menuCategory.Rows.Count; k++)
                    {
                        if (dt_menuCategory.Rows[k]["mCateid"].Equals(dt_menu.Rows[i]["mCateid"]))
                        {
                            combo_MenuCategory.SelectedIndex = combo_MenuCategory.Items.IndexOf(dt_menuCategory.Rows[k]["name"].ToString());
                            break;
                        }
                    }
                    if (dt_menu.Rows[i]["price"].ToString().Equals(""))
                    {
                        num_Mprice.Value = 0;
                        chk_Null.Checked = true;
                    }
                    else
                    {
                        chk_Null.Checked = false;
                        num_Mprice.Value = Convert.ToDecimal(dt_menu.Rows[i]["price"].ToString());
                    }
                    combo_MisShow.SelectedIndex = combo_isShow.Items.IndexOf(dt_menu.Rows[i]["isshow"].ToString());

                }   
          
            }
        }

        private void chk_Null_CheckedChanged(object sender, EventArgs e)
        {
            if (chick)
            {
                if (chk_Null.Checked)
                {
                    num_Mprice.Enabled = false;
                }
                else
                {
                    num_Mprice.Enabled = true;
                }
            }
        }

        private void btn_MMaintain_Click(object sender, EventArgs e)
        {
            chick = true;
            btn_MAdd.Enabled = false;
            MenuEnable(true);
            combo_MenuName.Enabled = false;
            btn_MSave.Visible = true;
        }

        private void btn_MAdd_Click(object sender, EventArgs e)
        {
            chick = true;
            btn_MMaintain.Enabled = false;
            MenuEnable(true);
            DataTable dt_Menu = db.getDb("Menu order by menuId  ASC");
            String MID = dt_Menu.Rows[dt_Menu.Rows.Count - 1]["menuId"].ToString();
            String str = "" + (Convert.ToInt32(MID.Substring(1)) + 1);
            String pad = "00000000";
            String ans = pad.Substring(0, pad.Length - str.Length) + str;
            String MIDnum = "M" + ans;
            txt_MenuID.Text = MIDnum;
            txt_menuName.Text = "";
            num_Mprice.Value = 0;
            chk_Null.Checked = true;
            combo_MenuCategory.SelectedIndex = 0;
            btn_MAddSave.Visible = true;

            
        }


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            chick = false;
            btn_MAdd.Enabled = true;
            btn_MMaintain.Enabled = true;
            MenuEnable(false);
            combo_MenuName.Enabled = true;
            btn_MAddSave.Visible = false;
            btn_MSave.Visible = false;
        }

        private void MenuEnable(Boolean s) {
            txt_MenuID.Enabled = s;
            txt_menuName.Enabled = s;
            num_Mprice.Enabled = s;
            combo_MenuCategory.Enabled = s;
            combo_MisShow.Enabled = s;
            chk_Null.Enabled = s;
            btn_Cancel.Visible = s;
        }

        private void btn_MSave_Click(object sender, EventArgs e)
        {
            UpdateMenu();
            chick = false;
            btn_MMaintain.Enabled = true;
            btn_MAdd.Enabled = true;
            MenuEnable(false);
            combo_MenuName.Enabled = true;
            btn_MSave.Visible = false;
            MaintainMenuFood MF = new MaintainMenuFood(this);
            MF.ShowDialog();
        }

        private void btn_MAddSave_Click(object sender, EventArgs e)
        {
            MAddSave();
            btn_MMaintain.Enabled = true;
            btn_MAdd.Enabled = true;
            MenuEnable(false);
            combo_MenuName.Enabled = true;
            btn_MAddSave.Visible = false;
            MaintainMenuFood MF = new MaintainMenuFood(this);
            MF.ShowDialog();
        }

        private void MAddSave() {
            String mId = txt_MenuID.Text;
            String menuName = txt_menuName.Text;
            Double mPrice = Convert.ToDouble(num_Mprice.Value);
            String MenuCategory = combo_MenuCategory.SelectedItem.ToString();
            DataTable dt_menuCategory = db.getDb("menuCategory");
            for (int i = 0; i < dt_menuCategory.Rows.Count; i++)
            {
                if (dt_menuCategory.Rows[i]["name"].Equals(MenuCategory))
                {
                    MenuCategory = dt_menuCategory.Rows[i]["mCateId"].ToString();
                    break;
                }
            }
            String MisShow = combo_MisShow.SelectedItem.ToString();
            if (!chk_Null.Checked)
            {
                String s = "INSERT INTO `menu`(`menuId`, `name`, `price`, `mCateId`, `isShow`) VALUES ('"+mId+"','"+menuName+"',"+mPrice+",'"+MenuCategory+"','"+MisShow+"')";
                db.queny(s);
                
            }
            else
            {
                String s = "INSERT INTO `menu`(`menuId`, `name`, `price`, `mCateId`, `isShow`) VALUES ('" + mId + "','" + menuName + "',null,'" + MenuCategory + "','" + MisShow + "')";
                db.queny(s);
            }
        }

        private void UpdateMenu() {
            String mId = txt_MenuID.Text;
            String menuName = txt_menuName.Text;
            Double mPrice = Convert.ToDouble(num_Mprice.Value);
            String MenuCategory = combo_MenuCategory.SelectedItem.ToString();
            DataTable dt_menuCategory = db.getDb("menuCategory");
            for (int i = 0; i < dt_menuCategory.Rows.Count; i++)
            {
                if (dt_menuCategory.Rows[i]["name"].Equals(MenuCategory))
                {
                    MenuCategory = dt_menuCategory.Rows[i]["mCateId"].ToString();
                    break;
                }
            }
            String MisShow = combo_MisShow.SelectedItem.ToString();
            if (!chk_Null.Checked)
            {
                String s = "UPDATE `menu` SET `name`='" + menuName + "',`price`=" + mPrice + ",`mCateId`='" + MenuCategory + "',`isShow`='" + MisShow + "' WHERE menuID='" + mId + "';";
                db.queny(s);
            }
            else
            {
                String s = "UPDATE `menu` SET `name`='" + menuName + "',`price`=null" + ",`mCateId`='" + MenuCategory + "',`isShow`='" + MisShow + "' WHERE menuID='" + mId + "';";
                db.queny(s);
            }
            
        }

        private void btn_MenuCategory_Click(object sender, EventArgs e)
        {
            MaintainCategory MC = new MaintainCategory(this);
            MC.ShowDialog();
        }

     
 
    }
}
