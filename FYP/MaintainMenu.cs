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
        private Boolean foodAddChick = false;


        public MaintainMenu(Main main)
        {
            InitializeComponent();
            this.main = main;
            db = main.db;
            
            
        }

        public  void MaintainMenu_Load(object sender, EventArgs e)
        {
            chkbox = db.getDb("Foodtype");
            DataTable dt_food = db.getDb("Food");
            

            int intialTop = 20;
            combo_foodType.Items.Clear();
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
            DGW_show.DataSource = dt_food;
            DGW_show.Rows[0].Selected = true;

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
            combo_MenuName.SelectedIndex = 0;
            int grp1_h = groupBox1.Location.Y + groupBox1.Height + 30;
            groupBox2.Location = new Point(groupBox2.Location.X,grp1_h);
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
                DataTable dt_food = db.getDb("Food");
                DGW_show.DataSource = dt_food;
            }
        }

        private void DGW_show_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = DGW_show.SelectedRows[0];
                txt_FID.Text = row.Cells[0].Value.ToString();
                txt_FName.Text = row.Cells[1].Value.ToString();
                txt_foodshortName.Text = row.Cells[2].Value.ToString();
                num_price.Value = Convert.ToDecimal(row.Cells[3].Value.ToString());
                num_SPrice.Value = Convert.ToDecimal(row.Cells[4].Value.ToString());
                Image img = Image.FromFile("C:\\xampp\\htdocs\\Fyp_php\\" + row.Cells[5].Value.ToString());
                pictureBox1.Image = img;
                button1.Text = "Change";
                txt_imgName.Text = row.Cells[5].Value.ToString();
                num_qty.Value = Convert.ToDecimal(row.Cells[6].Value.ToString());
                if (num_qty.Value <= 10)
                {
                    num_qty.BackColor = Color.Red;
                }
                else {
                    num_qty.BackColor = Color.White;
                }
                num_dQty.Value = Convert.ToDecimal(row.Cells[7].Value.ToString());
                for (int i = 0; i < chkbox.Rows.Count; i++)
                {
                    if (chkbox.Rows[i]["ftypeid"].Equals(row.Cells[8].Value.ToString()))
                    {

                        combo_foodType.SelectedIndex = combo_foodType.Items.IndexOf(chkbox.Rows[i]["name"].ToString());
                        break;
                    }
                }
                combo_isShow.SelectedIndex = combo_isShow.Items.IndexOf(row.Cells[9].Value.ToString());
            }
            catch (ArgumentOutOfRangeException ex)
            {

            }
            catch (System.IO.FileNotFoundException ex) {
                MessageBox.Show("Picture Not found");
            }
        }

        private void btn_maintain_Click(object sender, EventArgs e)
        {
            TrueFalse(true);
            DGW_show.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveChanging();
            TrueFalse(false);
            DGW_show.Enabled = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            foodAddChick = true;
            addFood();
            TrueFalse(true);
            DGW_show.Enabled = false;
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
            button1.Visible = s;
            txt_foodshortName.Enabled = s;
            btn_cancelFood.Visible = s;
        }

        private void addFood() {
            DataTable dt_food = db.getDb("food order by foodid ASC");
            String FID = dt_food.Rows[dt_food.Rows.Count - 1]["foodId"].ToString();
            String str = "" + (Convert.ToInt32(FID.Substring(1)) + 1);
            String pad = "00000000";
            String ans = pad.Substring(0, pad.Length - str.Length) + str;
            String FIDnum = "F" + ans;
            txt_FID.Text = FIDnum;
            txt_FName.Text = "";
            txt_foodshortName.Text = "";
            txt_imgName.Text = "image/"+txt_FID.Text+".jpg";
            pictureBox1.Image = null;
            button1.Text = "Upload";
        }

        private void SaveChanging() {
            String FName =txt_FName.Text;
            String FsName = txt_foodshortName.Text;
            String imgName = txt_imgName.Text;
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
           
            String FID  = txt_FID.Text;
            String s="";
            if (foodAddChick)
            {
                s = "INSERT INTO `food` (`foodId`, `name`,`shortname`,`img`, `price`, `sPrice`, `qty`, `dQty`, `fTypeId`) VALUES('" + FID + "', '" + FName + "','" + FsName + "','" + imgName+ "'," + price + "," + SPrice + "," + qty + "," + dqty + ", '" + Ftype + "')";
            }
            else {
                String isShow = combo_isShow.SelectedItem.ToString();
                s = "UPDATE `food` SET `name`='" + FName + "',`shortname`='" + FsName + "',`img`='" + imgName + "',`price`=" + price + ",`sPrice`=" + SPrice + ",`qty`=" + qty + ",`dQty`=" + dqty + ",`fTypeId`='" + Ftype + "',`isShow`='" + isShow + " 'WHERE foodid='" + FID + "';";
            }
           
            db.queny(s);
            foodAddChick = false;
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
                    txt_MenushortName.Text = dt_menu.Rows[i]["shortName"].ToString();
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
            DataTable dt_MenuFood = db.query("Select name,many from MenuFood,Foodtype where MenuFood.ftypeid=FoodType.ftypeid and menuid ='"+txt_MenuID.Text+"'");
            dataGridView1.DataSource = dt_MenuFood;
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
            txt_MenushortName.Text = "";
            num_Mprice.Value = 0;
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
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
            txt_MenushortName.Enabled = s;
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
            MaintainMenuFood MF = new MaintainMenuFood(this, txt_MenuID.Text);
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
            MaintainMenuFood MF = new MaintainMenuFood(this, txt_MenuID.Text);
            MF.ShowDialog();
        }

        private void MAddSave() {
            String mId = txt_MenuID.Text;
            String menuName = txt_menuName.Text;
            Double mPrice = Convert.ToDouble(num_Mprice.Value);
            String MenuCategory = combo_MenuCategory.SelectedItem.ToString();
            DataTable dt_menuCategory = db.getDb("menuCategory");
            String menuShortName = txt_MenushortName.Text;
            for (int i = 0; i < dt_menuCategory.Rows.Count; i++)
            {
                if (dt_menuCategory.Rows[i]["name"].Equals(MenuCategory))
                {
                    MenuCategory = dt_menuCategory.Rows[i]["mCateId"].ToString();
                    break;
                }
            }
            String MisShow = combo_MisShow.SelectedItem.ToString();
            try
            {
                if (!chk_Null.Checked)
                {
                    String s = "INSERT INTO `menu`(`menuId`, `name`,`shortname`, `price`, `mCateId`, `isShow`) VALUES ('" + mId + "','" + menuName + "','" + menuShortName + "'," + mPrice + ",'" + MenuCategory + "','" + MisShow + "')";
                    db.queny(s);

                }
                else
                {
                    String s = "INSERT INTO `menu`(`menuId`, `name`,`shortname`, `price`, `mCateId`, `isShow`) VALUES ('" + mId + "','" + menuName + "','" + menuShortName + "',null,'" + MenuCategory + "','" + MisShow + "')";
                    db.queny(s);
                }
                MessageBox.Show("Successful.");
                DataTable dt_menu = db.getDb("menu");
                dt_menuCategory = db.getDb("menuCategory");
                combo_MenuName.Items.Clear();
                combo_MenuCategory.Items.Clear();
                for (int i = 0; i < dt_menu.Rows.Count; i++)
                {
                    combo_MenuName.Items.Add(dt_menu.Rows[i]["name"].ToString());
                }
                for (int i = 0; i < dt_menuCategory.Rows.Count; i++)
                {
                    combo_MenuCategory.Items.Add(dt_menuCategory.Rows[i]["name"].ToString());
                }
                combo_MenuName.SelectedIndex = dt_menu.Rows.Count - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check the data.");
            }
        }

        private void UpdateMenu() {
            String mId = txt_MenuID.Text;
            String menuName = txt_menuName.Text;
            Double mPrice = Convert.ToDouble(num_Mprice.Value);
            String MenuCategory = combo_MenuCategory.SelectedItem.ToString();
            DataTable dt_menuCategory = db.getDb("menuCategory");
            String menuShortName = txt_MenushortName.Text;
            for (int i = 0; i < dt_menuCategory.Rows.Count; i++)
            {
                if (dt_menuCategory.Rows[i]["name"].Equals(MenuCategory))
                {
                    MenuCategory = dt_menuCategory.Rows[i]["mCateId"].ToString();
                    break;
                }
            }
            String MisShow = combo_MisShow.SelectedItem.ToString();
            try
            {
                if (!chk_Null.Checked)
                {
                    String s = "UPDATE `menu` SET `name`='" + menuName + "',`shortName`='" + menuShortName + "',`price`=" + mPrice + ",`mCateId`='" + MenuCategory + "',`isShow`='" + MisShow + "' WHERE menuID='" + mId + "';";
                    db.queny(s);
                }
                else
                {
                    String s = "UPDATE `menu` SET `name`='" + menuName + "',`shortName`='" + menuShortName + "',`price`=null" + ",`mCateId`='" + MenuCategory + "',`isShow`='" + MisShow + "' WHERE menuID='" + mId + "';";
                    db.queny(s);
                }
                MessageBox.Show("Successful.");
                DataTable dt_menu = db.getDb("menu");
                dt_menuCategory = db.getDb("menuCategory");
                combo_MenuName.Items.Clear();
                combo_MenuCategory.Items.Clear();
                for (int i = 0; i < dt_menu.Rows.Count; i++)
                {
                    combo_MenuName.Items.Add(dt_menu.Rows[i]["name"].ToString());
                }
                for (int i = 0; i < dt_menuCategory.Rows.Count; i++)
                {
                    combo_MenuCategory.Items.Add(dt_menuCategory.Rows[i]["name"].ToString());
                }
                combo_MenuName.SelectedIndex = dt_menu.Rows.Count - 1;
            }catch(Exception ex){
                MessageBox.Show("Please check the data.");
            }
            
        }

        private void btn_MenuCategory_Click(object sender, EventArgs e)
        {
            MaintainCategory MC = new MaintainCategory(this);
            MC.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (System.IO.File.Exists("C:\\xampp\\htdocs\\Fyp_php\\image\\" + txt_FID.Text + ".jpg"))
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                    System.IO.File.Delete("C:\\xampp\\htdocs\\Fyp_php\\image\\" + txt_FID.Text + ".jpg");
                    button1.Text = "Upload";

                }
            }
            else
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    Image img = Image.FromFile(open.FileName);
                    pictureBox1.Image = img;
                    String path = "C:\\xampp\\htdocs\\Fyp_php\\image\\" + txt_FID.Text + ".jpg";
                    pictureBox1.Image.Save(path);
                    open.Dispose();

                }
            }
        }

        private void btn_cancelFood_Click(object sender, EventArgs e)
        {
            TrueFalse(false);
        }

        

        

      

     
 
    }
}
