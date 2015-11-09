using System;
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
        private String server = "127.0.0.1";
        private String database = "fyp_db";
        private String uid="root";
        private String password;
        //connetionString = "Server=" + server + ";Database=" + database + ";";
           public void Connection()
            {
                String connetionString = "Server=" + server + ";Database=" + database + ";UiD=" + uid + ";";
                cnn = new MySqlConnection(connetionString);
            }
           public DataTable getDb(String dbName)
           {
               MySqlCommand command = cnn.CreateCommand();
               cnn.Open();
               String cmdText = "SELECT * FROM "+dbName;
               MySqlCommand cmd = new MySqlCommand(cmdText, cnn);
               MySqlDataAdapter da = new MySqlDataAdapter(cmdText, cnn);
               DataTable db = new DataTable();
               da.Fill(db); 
               cnn.Close();
               return db;
              
           }

           public DataTable insertDb(String sql)
           {

               MySqlCommand command = cnn.CreateCommand();
               cnn.Open();
               String cmdText = sql;
               MySqlCommand cmd = new MySqlCommand(cmdText, cnn);
               MySqlDataAdapter da = new MySqlDataAdapter(cmdText, cnn);
               cnn.Close();
               DataTable db = new DataTable();
               try
               {
                   da.Fill(db);
               }
               catch (Exception ex) {
                   MessageBox.Show("You are already INSERT this record!");
               }
               cnn.Close();
               return db;
           }



    }
}
