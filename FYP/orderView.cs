﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Login
{
    public class orderView
    {
        private DataTable OrderAndOrderFoodDt, MenuAndOrderDt,AllDt;
        private Database database;
        public orderView()
        {
            database = new Database();
            database.Connection();
        }
        public void UpdateOrderAndOrderFoodDt()
        {
            OrderAndOrderFoodDt = database.getDb("orders", "orderfood", "orderId", "orderId");

        }
        public DataTable getOrderAndOrderFooddt()
        {
            return OrderAndOrderFoodDt;
        }
        public void UpdateMenuAndOrderDt()
        {
            OrderAndOrderFoodDt = database.getDb("menu","orders","menuId","menuId");
        }
        public DataTable getOrderAndOrderFoodDt()
        {
            return OrderAndOrderFoodDt;
        }
        public void setAllDt(){
            AllDt = database.getDb();
        }
        public DataTable getAllDt()
        {
            return AllDt;
        }
    }
}