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
    public partial class kitchenView : Form
    {
        private int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        private int screenHeight = Screen.PrimaryScreen.Bounds.Height;
        private orderView ov;
        private ListBox lb;
        private Login login;
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
            this.FLP1.Width = screenWidth - 200;
            this.FLP1.Height = screenHeight;
            this.gb1.Location = new Point(screenWidth - 200, 10);
            this.gb1.Width = 400;
            this.gb1.Height = screenHeight;
            ov = new orderView();
            orderView();
        }
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            orderView();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(FLP1.Controls.Count.ToString());
            FLP1.Controls.RemoveAt(0);
        }

        private void btn_del2_Click(object sender, EventArgs e)
        {
                FLP1.Controls.RemoveByKey(txtId.Text);
        }

        private void orderView()
        {

            while (FLP1.Controls.Count> 0)
            {
                FLP1.Controls.RemoveAt(0);
            }
           
            ov.setAllDt();
            DataTable AllDt = ov.getAllDt();
            for (int i = 0; i < AllDt.Rows.Count; i ++)
            {
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
                    FLP1.Controls.Add(lb);
            }
        }
        
    }
}
