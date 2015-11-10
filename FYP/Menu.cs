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



        public Menu(Form login)
        {
            InitializeComponent();
            this.login = login;
            //lab_welcome.Text += ((Login)login).userName;
           
        }

        private void Menu_Load(object sender, EventArgs e)
        {
           
           
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

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maintainUser.Show();

        }

      
    }
}
