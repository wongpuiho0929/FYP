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
    public partial class Main : Form
    {
        private Login login;
        public Database db;
        private int numOfOrder = 0;
        private Form[] frm ;
        private List<CheckBox> CheckBoxes = new List<CheckBox>();

        public Main(Login login)
        {
            InitializeComponent();
            this.login = login;
            this.db = login.database;
            this.KeyPreview = true;
            AddValue addValue = new AddValue(this);
            MaintainMenu mMenu = new MaintainMenu(this);
            MaintainMenu_v2 mMenu_v2 = new MaintainMenu_v2(this);
            MaintainUser mUser = new MaintainUser(this);
            ViewOrder viewOrder = new ViewOrder(this);
            kitchenView kcv = new kitchenView(login);
            Report report = new Report(this);
            Form[] temp = { addValue, mMenu_v2, mUser, kcv, report };
            frm = temp;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Screen screen = System.Windows.Forms.Screen.PrimaryScreen;
            var y = screen.WorkingArea.Width;
            listBox1.Width = y / 2;
            grp_takeOrder.Width = y / 2;
            dataGridView1.Width = y / 2;
            grp_StudentInfo.Width = y / 2;
            grp_order.Width = y / 2;
            y = y / 5;
            var x = btn_AddValue.Size.Height;
            grp_order.Height = x*2;
            Button[] btn = { btn_AddValue, btn_Menu, btn_Staff, btn_ViewOrder,btn_Report};
            for (int i = 0; i < btn.Length; i++) {
                btn[i].Size = new Size(y, x);
            }
            for (int i = 1; i < btn.Length; i++)
            {
                x = btn[i-1].Location.X + btn[i].Size.Width;
                btn[i].Location = new Point(x,3);
            }
            timer1.Start();
            timer2.Start();
            lab_username.Text+=login.userName;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            this.time.Text = DateTime.Now.ToString();
            if (DateTime.Now.Hour > 8 && DateTime.Now.Hour < 15)
            {
                lab_status.BackColor = Color.Red;
                lab_status.Text = "System is Running!!";
            }
            else {
                lab_status.BackColor = Color.Chartreuse;
                lab_status.Text = "Out of service";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DataTable db_orders = db.getDb("orders where status not in('finish')");

            for (int i = numOfOrder; i < db_orders.Rows.Count; i++)
            {   
                String s = db_orders.Rows[i]["stuid"].ToString();
                String oid = db_orders.Rows[i]["orderId"].ToString();
                s += "  " + oid;
                s += "  at  " + db_orders.Rows[i]["oTakeTime"].ToString();
                s += ": order ";
                
                DataTable db_orderFood = db.getDb("orderfood where orderid = '"+oid+"'");
                if (db_orderFood.Rows.Count > 1)
                {
                    for (int k = 0; k < db_orderFood.Rows.Count; k++)
                    {
                        String fid = db_orderFood.Rows[k]["foodId"].ToString();
                        DataTable db_food = db.getDb("food where foodid='" + fid + "'");
                        s += "  "+db_food.Rows[0]["shortname"];
                    }
                }
                else {
                    String fid = db_orderFood.Rows[0]["foodId"].ToString();
                    DataTable db_food = db.getDb("food where foodid='" + fid + "'");
                    s += "  " +db_food.Rows[0]["shortname"];
                }
              
                listBox1.Items.Insert(0,s);
                numOfOrder++;
            }
            DataTable dt_TakeTime = db.query("Select oTaketime from orders where status not in ('finish') group by oTaketime");
            int numberOfTime = dt_TakeTime.Rows.Count;
            if (combo_time.Items.Count != numberOfTime)
            {
                combo_time.Items.Clear();
                for (int i = 0; i < dt_TakeTime.Rows.Count; i++)
                {
                    combo_time.Items.Add(dt_TakeTime.Rows[i][0].ToString());
                }
                
            }
            /* ---generate total refund student money------
             DataTable dt_History = db.getDb("stuhistory ");
           
            int totalMoney = 0;
            for (int i = 0; i < dt_History.Rows.Count; i++)
            {
                totalMoney += Convert.ToInt32(dt_History.Rows[i]["balance"].ToString());
            }
           
            lab_TotalMoney.Text = "Total of Student Money:  " + totalMoney;
             ----------------------------------------------------------------*/
        }





        //--------------------------Close Action ----------------------------//
        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.txt_password.Text = "";
            login.Show();
            
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            login.txt_password.Text = "";
            login.Show();
        }

        private void Close_MouseHover(object sender, EventArgs e)
        {
            Close.BackColor = Color.CadetBlue;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.BackColor = SystemColors.Control;
        }
        //-------------------------------------------------------------------//

        private void btn_AddValue_Click(object sender, EventArgs e)
        {
            showForm(0);
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            showForm(1);
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            showForm(2);
        }

        private void btn_ViewOrder_Click(object sender, EventArgs e)
        {
            Screen[] sc; 
            sc = Screen.AllScreens;
            frm[3].Left = sc[0].Bounds.Left;
            frm[3].Top = sc[0].Bounds.Top;
            frm[3].StartPosition = FormStartPosition.Manual;
            try
            {
                frm[3].Show();
            } catch{
                frm[3] = new kitchenView(login);
                frm[3].Show();
            }
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            showForm(4);
        }

        private void showForm(int i) {
            frm[i].ShowDialog();
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            showForm(5);
        }

        private void combo_time_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataTable dt_order = db.query("SELECT orders.orderid,orders.stuid,orderfood.foodid,food.name from food,orders,orderfood where orders.orderid = orderfood.orderid and orderfood.foodid = food.foodid and orders.oTakeTime='" + combo_time.SelectedItem.ToString()+"'");
            try
            {
                DataTable dt_order = db.query("SELECT orderid,stuid,status from orders where oTakeTime='" + combo_time.SelectedItem.ToString() + "'");
                dataGridView1.DataSource = dt_order;
            }catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btn_take_Click(object sender, EventArgs e)
        {
            grp_order.Visible = true;
            txt_studid.Enabled = false;
            DataTable dt_order = db.query("SELECT orderid from orders where stuid='" + txt_studid.Text + "' and status='ready'");
            int intialLeft = 30;
            
            for (int i = 0; i < dt_order.Rows.Count; i++) {
                CheckBox chk = new CheckBox();
                chk.Left = intialLeft;
                chk.Top = 30;
                chk.Text = dt_order.Rows[i][0].ToString();
                chk.Name = "chk_" + chk.Text;
                chk.AutoSize = true;
                intialLeft += 30+chk.Size.Width;
                grp_order.Controls.Add(chk);
                CheckBoxes.Add(chk);
                
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CheckBoxes.Count; i++) {
                if (CheckBoxes[i].Checked) {
                    String s = "Update orders set status ='finish' where orderid='" + CheckBoxes[i].Text + "'";
                    db.queny(s);
                }
                grp_order.Controls.Remove(CheckBoxes[i]);
            }
            
            CheckBoxes.Clear();
            grp_order.Visible = false;
            txt_studid.Text = "";
            txt_studid.Enabled = true;
            combo_time_SelectedIndexChanged(sender, e);
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.F5) {
                listBox1.Items.Clear();
                numOfOrder = 0;
                DataTable db_orders = db.getDb("orders where status not in('finish')");

                for (int i = numOfOrder; i < db_orders.Rows.Count; i++)
                {
                    String s = db_orders.Rows[i]["stuid"].ToString();
                    String oid = db_orders.Rows[i]["orderId"].ToString();
                    s += "  " + oid;
                    s += "  at  " + db_orders.Rows[i]["oTakeTime"].ToString();
                    s += ": order ";

                    DataTable db_orderFood = db.getDb("orderfood where orderid = '" + oid + "'");
                    if (db_orderFood.Rows.Count > 1)
                    {
                        for (int k = 0; k < db_orderFood.Rows.Count; k++)
                        {
                            String fid = db_orderFood.Rows[k]["foodId"].ToString();
                            DataTable db_food = db.getDb("food where foodid='" + fid + "'");
                            s += "  " + db_food.Rows[0]["shortname"];
                        }
                    }
                    else
                    {
                        String fid = db_orderFood.Rows[0]["foodId"].ToString();
                        DataTable db_food = db.getDb("food where foodid='" + fid + "'");
                        s += "  " + db_food.Rows[0]["shortname"];
                    }

                    listBox1.Items.Insert(0, s);
                    numOfOrder++;
                }

            }
        }

    }
}
