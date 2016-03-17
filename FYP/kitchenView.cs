using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Login
{
    public partial class kitchenView : Form
    {
        private int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        private int screenHeight = Screen.PrimaryScreen.Bounds.Height;
        private orderView ov;
        private ListBox lb;
        private Login login;
        private Thread thread;
        private CheckBoxEx[] time;
        private int x = 0;
        public kitchenView(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void kitchenView_Load(object sender, EventArgs e)
        {
            this.Width = screenWidth;
            this.Height = screenHeight;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.FLP1.Width = screenWidth - 225;
            this.FLP1.Height = screenHeight;
            this.gb1.Location = new Point(screenWidth - 200, 10);
            this.gb1.Width = 400;
            this.gb1.Height = screenHeight;
            gb_location();
            gb_width();
            ov = new orderView();
            
            addGBFoodType();
            addTakeTime();
            orderView();
            thread = new Thread(() =>
            {
                while (++x  > 0) ;
            });
            thread.Start();
             System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Tick += new EventHandler(t_tick);
            t.Interval = 5000;
            t.Start();
            
        }
        private void t_tick(object sender, EventArgs e)
        {
            orderView();
        }
        private void gb_width()
        {
            this.gbFunction.Width = this.gb1.Width;
            this.gb_Information.Width = this.gb1.Width;
            this.gb_foobType.Width = this.gb1.Width;
            this.gb_OrderStatus.Width = this.gb1.Width;
        }
        private void gb_location()
        {
            int y = 7;
            this.gb_Information.Location = new Point(y, 19);
            this.gbFunction.Location = new Point(y, this.gb_Information.Location.Y+this.gb_Information.Height + 10);
            this.gb_foobType.Location = new Point(y, this.gbFunction.Location.Y +this.gbFunction.Height+ 10);
            this.gb_OrderStatus.Location = new Point(y, this.gb_foobType.Location.Y+this.gb_foobType.Height+ 10);
        }
       
        private void orderView()
        {

            while (FLP1.Controls.Count> 0)
            {
                FLP1.Controls.RemoveAt(0);
            }
           
            ov.setAllDt();
            DataTable AllDt = ov.getAllDt();
            for (int i = 0; i < AllDt.Rows.Count; i++)
            /*{
                lb = new ListBox();
                lb.Name = AllDt.Rows[i]["orderid"].ToString();
                lb.Font = new System.Drawing.Font("Microsoft JhengHei", 30, System.Drawing.FontStyle.Bold);
                lb.ForeColor = Color.Black;
                lb.Height = screenHeight / 3;
                lb.Width = (screenWidth - 250) / 3;
                lb.HorizontalScrollbar = true;
                ov.setAllDt(lb.Name.ToString());
                DataTable orderDetail = ov.getAllDt();
                lb.Items.Add("Order ID:" + lb.Name.ToString());
                for (int j = 0; j < orderDetail.Rows.Count; j++)
                {
                    lb.Items.Add(orderDetail.Rows[j]["shortname"]);
                }
                lb.Items.Add(AllDt.Rows[i]["otaketime"]);
                    FLP1.Controls.Add(lb);}*/
            {
                Label lb = new Label();
                lb.Height = screenHeight / 3;
                lb.Width = (screenWidth - 250) / 3;
                lb.Name = AllDt.Rows[i]["orderid"].ToString();
                lb.BackColor = System.Drawing.ColorTranslator.FromHtml("#CFF3FF");
                lb.BorderStyle = BorderStyle.FixedSingle;
                lb.Font = new System.Drawing.Font("Microsoft JhengHei", 30, System.Drawing.FontStyle.Bold);
                ov.setAllDt(lb.Name.ToString());
                DataTable orderDetail = ov.getAllDt();
                String s = "";
                s += lb.Name.ToString()+"\r";
                for (int j = 0; j < orderDetail.Rows.Count; j++)
                {
                    s+=orderDetail.Rows[j]["shortname"]+"\r";
                }
                s += "Take Time:"+AllDt.Rows[i]["otaketime"];
                lb.Text = s;
                lb.Tag = AllDt.Rows[i]["otaketime"].ToString().Substring(0,5);
                lb.Click += new EventHandler(orderObject_click);
                FLP1.Controls.Add(lb);
                lbl_tov.Text = "Total Order Value:" + orderDetail.Rows.Count.ToString();
            }
            checkTime();
        }
        private void orderObject_click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            viewOrderDetail vod = new viewOrderDetail(lb);
            vod.Deactivate += delegate
            {
                vod.Close();
            };
            vod.Show();
        }
        private void addGBFoodType()
        {
            ov.setDt("foodType");
            DataTable dt = ov.getDt();
            int high = 15;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CheckBoxEx cb = new CheckBoxEx();
                cb.Location = new Point(10, high);
                high += 30;
                cb.ClientSize = new Size(30, 30);
                cb.Font = new System.Drawing.Font("Microsoft JhengHei", 12, System.Drawing.FontStyle.Bold);
                cb.Name = "cb_foodType_"+dt.Rows[i].ToString();
                cb.Text = dt.Rows[i]["name"].ToString();
                gb_foobType.Controls.Add(cb);
                cb.CheckedChanged += new EventHandler(CheckBox1_CheckedChanged);
            } 
        }
        private void CheckBox1_CheckedChanged(Object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked == true)
            {
                MessageBox.Show(cb.Text);
            }
        }
        private void addTakeTime()
        {
            int hour = 10;
            int min = 0;
            int high = 15;
            time = new CheckBoxEx[7];
            for (int i = 0; i < 7; i++)
            {
                CheckBoxEx cb = new CheckBoxEx();
                cb.ClientSize = new Size(30, 30);
                cb.Location = new Point(10, high);
                cb.Font = new System.Drawing.Font("Microsoft JhengHei", 18, System.Drawing.FontStyle.Bold);
                
                if (min == 0)
                {
                    hour ++;
                    String temp = "0" + min.ToString();
                    cb.Text = hour.ToString() + ":" +temp;
                }
                else
                {
                    cb.Text = hour.ToString() + ":" + min.ToString();
                }
                high += 30;
                min = (min + 30) % 60;
                cb.Name = "cb_TakeTime_" + i;
                time[i] = cb;
                
                cb.CheckedChanged += new EventHandler(CheckBoxTime_CheckedChanged);
                gbFunction.Controls.Add(cb);
                
            }
        }

        private List<String> timeList = new List<string>();

        private void CheckBoxTime_CheckedChanged(Object Sender, EventArgs e)
        {

            checkTime();
        }
        private void checkTime()
        {
            timeList = new List<string>();
            for (int i = 0; i < time.Length; i++)
            {
                if (time[i].Checked == true)
                {
                    timeList.Add(time[i].Text);
                }
            }
            if (timeList.Count == 0 || timeList.Count == time.Length)
            {
                foreach (Control c in FLP1.Controls)
                {
                    Label lb = (Label)c;
                    lb.Show();
                }
                return;
            }
                
            foreach (Control c in FLP1.Controls)
            {
                Label lb = (Label)c;
                if (timeList.Contains(lb.Tag.ToString()))
                {
                    
                    lb.Show();
                }
                else
                {
                    lb.Hide();
                }
            }
        }
    }
}
