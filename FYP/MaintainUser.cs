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
    public partial class MaintainUser : Form
    {
        private Main main;

        public MaintainUser(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MaintainUser_Load(object sender, EventArgs e)
        {

        }

        private void panel_staff_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
