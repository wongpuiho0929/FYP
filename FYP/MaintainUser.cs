using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class MaintainUser : Form
    {
        private Menu menu;
        private Database database;

        public MaintainUser(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
            this.database = menu.database;
        }

        private void MaintainUser_Load(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.ShowDialog();
        }

        private void checkType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Boolean[] chk = new Boolean[3];
            DataTable db = database.getDb("account");
            for (int i = 0; i < checkType.Items.Count; i++)
            {
                checkType.SetItemChecked(checkType.SelectedIndex,true);
                 chk[i] =checkType.GetItemChecked(i);
            }
            if (chk[0]) {
                showData.DataSource = db;
                menu.dt_account = database.insertDb("INSERT INTO account VALUES ('tommy','tommy','staff'); ");
            }

        }
    }
}
