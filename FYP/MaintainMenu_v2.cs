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
    public partial class MaintainMenu_v2 : Form
    {
        private Main main;
        private CheckBox[] chkboxs;

        public MaintainMenu_v2(Main main)
        {
            InitializeComponent();
            this.main = main;
            CheckBox[] temp = { chk_Mon, chk_Tue, chk_Wed, chk_Thu, chk_Fri, chk_Sat, chk_Sun, chk_All };
            chkboxs = temp;
            
        }

        private void MaintainMenu_v2_Load(object sender, EventArgs e)
        {
           
           
            
        }



        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DataTable dt_meun = main.db.getDb("menu");
            List<GroupBox> listgrpbox = new List<GroupBox>();
            for (int i = 0; i < dt_meun.Rows.Count; i++)
            {
             
                Label lab = new Label();
                GroupBox grp = new GroupBox();
                grp.Name = "grp";
                lab.Text =  dt_meun.Rows[i]["name"].ToString();
                lab.AutoSize = true;
                lab.Font = new Font("Comic Sans MS", 15);
                grp.Size = new Size(1200,250);
                
                grp.Controls.Add(lab);
                DataTable dt_meunfood = main.db.getDb("menufood where menuid='"+ dt_meun.Rows[i]["menuid"]+"'");
                int y = 10;
                for (int t = 0; t < dt_meunfood.Rows.Count; t++)
                {
                    DataTable dt_food = main.db.getDb("food where ftypeid = '" + dt_meunfood.Rows[t]["ftypeid"] + "'");
                    for (int k = 0; k < dt_food.Rows.Count; k++)
                    {
                       
                        PictureBox pictureBox1 = new PictureBox();
                        Image img = Image.FromFile("C:\\xampp\\htdocs\\Fyp_php\\" + dt_food.Rows[k]["img"].ToString());
                        pictureBox1.Image = img;
                        pictureBox1.Size = new Size(100,100);
                        pictureBox1.Location = new Point(y, 30);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        y += 150;
                        grp.Controls.Add(pictureBox1);
                    }
                }
                listgrpbox.Add(grp);
                
            }

           
           
                foreach (GroupBox a in listgrpbox)
                {

                    flowLayoutPanel1.Controls.Add(a);
                }

        }

        private void chk_All_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_All.Checked)
            {
                foreach (CheckBox a in chkboxs)
                {
                    a.Checked = true;
                }
            }
            else
            {
                foreach (CheckBox a in chkboxs)
                {
                    a.Checked = false;
                }
            }
        }

        private void btn_foodlist_Click(object sender, EventArgs e)
        {
            MaintainMenu menu = new MaintainMenu(main);
            menu.ShowDialog();

        }
    }
}
