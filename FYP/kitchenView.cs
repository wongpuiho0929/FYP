﻿using System;
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
        private Database database;
        private DataTable Orderdt, Menudt, OrderFooddt, Fooddt;

        public kitchenView()
        {
            InitializeComponent();
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
            database = new Database();
            database.Connection();
            reFreshOrder();
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
            for (int i = 0; i < Orderdt.Rows.Count; i+=2)
            {
                ListBox lb = new ListBox();
                lb.Name = "c"+i;
                lb.Font = new System.Drawing.Font("Microsoft JhengHei", 30, System.Drawing.FontStyle.Bold);
                lb.ForeColor = Color.Black;
                lb.Height = screenHeight / 4;
                lb.Width = (screenWidth - 250) / 4;
                lb.HorizontalScrollbar = true;
                //lb.Enabled = false;

                reFreshOrder();
                lb.Items.Add("ID:" + Orderdt.Rows[i]["orderId"]);
                getFoodDb(Orderdt.Rows[0]["foodId"].ToString());
                lb.Items.Add("Food:" + Fooddt.Rows[0]["shortName"]);
                getFoodDb(Orderdt.Rows[1]["foodId"].ToString());
                lb.Items.Add("Drink:" + Fooddt.Rows[0]["shortName"]);
                lb.Items.Add("Take Out Time:");
                lb.Items.Add(Orderdt.Rows[0]["oTakeTime"].ToString());
                FLP1.Controls.Add(lb);
            }
        }
        private void reFreshOrder()
        {
            Orderdt = database.getDb("orders", "orderfood","orderId","orderId");
            Menudt = database.getDb("menu");
        }
        private void getFoodDb(String foodId)
        {
            Fooddt = database.getDb("food","foodId",foodId);
        }
       
    }
}
