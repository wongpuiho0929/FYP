﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Login
{
  
    public  class Database{
        private MySqlConnection cnn;
        private  static String server = "127.0.0.1";
        private  static String database = "fyp_db";
        private  static String uid = "root";
        private  static String password = "tommy985";
        //connetionString = "Server=" + server + ";Database=" + database + ";";

        public void changeConnection(String s,String u,String p) {
            server = s;
            uid = u;
            password = p;
        }
           public void Connection()
            {
                String connetionString = "Server=" + server + ";Database=" + database + ";UiD=" + uid + ";Pwd=" + password + "; Charset=utf8";
                cnn = new MySqlConnection(connetionString);
                
            }

           public DataTable getDb()
           {
               MySqlCommand command = cnn.CreateCommand();
               cnn.Open();
               String cmdText = "SELECT DISTINCT * FROM orders o INNER JOIN menu m ON o.menuId = m.menuId INNER JOIN orderfood of ON o.orderId = of.orderId AND of.orderId = o.orderId INNER JOIN food f ON f.foodId = of.foodId INNER JOIN foodtype ft ON ft.fTypeId = f.fTypeId INNER JOIN menufood mf ON mf.menuId= m.menuid WHERE of.orderDate = CURDATE() AND o.orderDate= CURDATE()  GROUP BY ft.name DESC";
               MySqlCommand cmd = new MySqlCommand(cmdText, cnn);
               MySqlDataAdapter da = new MySqlDataAdapter(cmdText, cnn);
               DataTable db = new DataTable();
               da.Fill(db);
               cnn.Close();
               return db;
           }
           public DataTable getDb(String dbName)
           {
               
                   MySqlCommand command = cnn.CreateCommand();
                   cnn.Open();
                   String cmdText = "SELECT * FROM " + dbName;
                   MySqlCommand cmd = new MySqlCommand(cmdText, cnn);
                   MySqlDataAdapter da = new MySqlDataAdapter(cmdText, cnn);
                   DataTable db = new DataTable();
                   da.Fill(db);
                   cnn.Close();
                   return db;

           }

           public DataTable getDb(String dbName, String columnName, String columunResult)
           {
               MySqlCommand command = cnn.CreateCommand();
               cnn.Open();
               String cmdText = "SELECT * FROM " + dbName + " WHERE " + columnName + "='" + columunResult + "'";
               MySqlCommand cmd = new MySqlCommand(cmdText, cnn);
               MySqlDataAdapter da = new MySqlDataAdapter(cmdText, cnn);
               DataTable db = new DataTable();
               da.Fill(db);
               cnn.Close();
               return db;
           }
           public DataTable getDb(String dbName, String dbName2, String columnName, String columnName2)
           {
               MySqlCommand command = cnn.CreateCommand();
               cnn.Open();
               String cmdText = "SELECT * FROM " + dbName + " Left join " + dbName2 + " on " + dbName + "." + columnName + "=" + dbName2 + "." + columnName2;
               MySqlCommand cmd = new MySqlCommand(cmdText, cnn);
               MySqlDataAdapter da = new MySqlDataAdapter(cmdText, cnn);
               DataTable db = new DataTable();
               da.Fill(db);
               cnn.Close();
               return db;
           }


           public DataTable getDb2()
           {
               MySqlCommand command = cnn.CreateCommand();
               cnn.Open();
               String cmdText = "SELECT * FROM orders o where O.orderDate=CURDATE() AND o.status = 'processing'";
               MySqlCommand cmd = new MySqlCommand(cmdText, cnn);
               MySqlDataAdapter da = new MySqlDataAdapter(cmdText, cnn);
               DataTable db = new DataTable();
               da.Fill(db);
               cnn.Close();
               return db;
           }
           public DataTable getDb2(String oid)
           {
               MySqlCommand command = cnn.CreateCommand();
               cnn.Open();
               String cmdText = "SELECT o.orderId,o.oTakeTime,o.orderDate,f.shortName,ft.name FROM orders O, orderfood OF, food F, foodtype FT WHERE O.orderDate=OF.orderDate AND O.orderId=OF.orderId AND OF.foodId=F.foodId AND F.fTypeId=FT.fTypeId AND O.orderId='" + oid + "' AND O.orderDate=CURDATE()";
               MySqlCommand cmd = new MySqlCommand(cmdText, cnn);
               MySqlDataAdapter da = new MySqlDataAdapter(cmdText, cnn);
               DataTable db = new DataTable();
               da.Fill(db);
               cnn.Close();
               return db;
           }
           public void queny(String sql)
           {

               MySqlCommand command = cnn.CreateCommand();
               cnn.Open();
               MySqlCommand s = new MySqlCommand("set names utf8", cnn);
               s.ExecuteNonQuery();
               s.Dispose();
               String cmdText = sql;
               MySqlCommand cmd = new MySqlCommand(cmdText, cnn);
               MySqlDataAdapter da = new MySqlDataAdapter(cmdText, cnn);
               DataTable db = new DataTable();
               try
               {
                   da.Fill(db);
               }
               catch (Exception ex) {
                   MessageBox.Show("You are already INSERT this record!");
               }
               cnn.Close();
            
           }

           public DataTable query(String sql)
           {

               MySqlCommand command = cnn.CreateCommand();
               cnn.Open();
               MySqlCommand s = new MySqlCommand("set names utf8", cnn);
               s.ExecuteNonQuery();
               s.Dispose();
               String cmdText = sql;
               MySqlCommand cmd = new MySqlCommand(cmdText, cnn);
               MySqlDataAdapter da = new MySqlDataAdapter(cmdText, cnn);
               cnn.Close();
               DataTable db = new DataTable();
               try
               {
                   da.Fill(db);
               }
               catch (Exception ex)
               {
                   MessageBox.Show("SELECTED 0 record!");
               }
               return db;

           }
    }
}
