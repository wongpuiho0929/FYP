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

        public Main(Login login)
        {
            InitializeComponent();
            this.login = login;
            this.db = login.database;
            AddValue addValue = new AddValue(this);
            MaintainMenu mMenu = new MaintainMenu(this);
            MaintainUser mUser = new MaintainUser(this);
            ViewOrder viewOrder = new ViewOrder(this);
            kitchenView kcv = new kitchenView();
            Report report = new Report(this);
            Form[] temp = { addValue, mMenu, mUser, kcv, report};
            frm = temp;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Screen screen = System.Windows.Forms.Screen.PrimaryScreen;
            var y = screen.WorkingArea.Width;
           
            y = y / 5;
            var x = btn_AddValue.Size.Height;
            Button[] btn = { btn_AddValue, btn_Menu, btn_Staff, btn_ViewOrder, btn_Report};
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
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DataTable db_orders = db.getDb("orders");

            for (int i = numOfOrder; i < db_orders.Rows.Count; i++)
            {
                String s = db_orders.Rows[i]["stuid"].ToString();
                s += ": order ";
                String oid = db_orders.Rows[i]["orderId"].ToString();
                DataTable db_orderFood = db.getDb("orderfood where orderid = '"+oid+"'");
                if (db_orderFood.Rows.Count > 1)
                {
                    for (int k = 0; k < db_orderFood.Rows.Count; k++)
                    {
                        String fid = db_orderFood.Rows[k]["foodId"].ToString();
                        DataTable db_food = db.getDb("food where foodid='" + fid + "'");
                        s += db_food.Rows[0]["name"];
                    }
                }
                else {
                    String fid = db_orderFood.Rows[0]["foodId"].ToString();
                    DataTable db_food = db.getDb("food where foodid='" + fid + "'");
                    s += db_food.Rows[0]["name"];
                }
                listBox1.Items.Insert(0,s);
                numOfOrder++;
            }
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
            showForm(3);
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

    }
}
