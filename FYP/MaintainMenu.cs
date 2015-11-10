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
    public partial class MaintainMenu : Form
    {
        private Main main;

        public MaintainMenu( Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void MaintainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
