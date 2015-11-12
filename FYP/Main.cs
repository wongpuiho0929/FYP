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
        private Login lg;
        private static Form menu,maintainUser,maintainMenu,addValue,viewOrder,report;
        public Database database;
        

        public Main(Login lg)
        {
            InitializeComponent();
            this.lg =lg;
          
            this.database = ((Login)lg).database;
            setFrom();

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void mrnuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void setFrom() { 
            menu = new Menu(this);
            maintainUser = new MaintainUser(this);
            maintainMenu = new MaintainMenu(this);
            addValue = new AddValue(this);
            viewOrder = new ViewOrder(this);
            report = new Report(this);
            Form [] fm = {menu,maintainUser,maintainMenu,addValue,viewOrder,report};
            for (int i = 0; i < fm.Length; i++) {
                fm[i].MdiParent = this;
                fm[i].FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                fm[i].Dock = DockStyle.Fill;

            }
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            lg.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maintainMenu.Show();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maintainUser.Show();
         

        }

    
    }
}
