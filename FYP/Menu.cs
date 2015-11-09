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
    public partial class Menu : Form
    {
        private Form login,maintainUser;
        public Database database;
        public DataTable dt_account;


        public Menu(Form login)
        {
            InitializeComponent();
            this.login = login;
            lab_welcome.Text += ((Login)login).userName;
            this.database =((Login)login).database;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
           
            maintainUser = new MaintainUser(this);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void btn_maintainUser_Click(object sender, EventArgs e)
        {
            maintainUser.Show();
            this.Hide();
        }
    }
}
