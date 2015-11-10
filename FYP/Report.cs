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
    public partial class Report : Form
    {

        private Main main;

        public Report( Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }
    }
}
