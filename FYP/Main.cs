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
        private Login login;

        public Main(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Screen screen = System.Windows.Forms.Screen.PrimaryScreen;
            var y = screen.WorkingArea.Width;
           
            y = y / 5;
            var x = btn_AddValue.Size.Height;
            Button[] btn = { btn_AddValue, btn_Menu, btn_Staff, btn_ViewOrder, btn_Report };
            for (int i = 0; i < btn.Length; i++) {
                btn[i].Size = new Size(y, x);
            }
            for (int i = 1; i < btn.Length; i++)
            {
                listBox1.Items.Add(btn[i - 1].Location.X);
                x = btn[i-1].Location.X + btn[i].Size.Width;
                btn[i].Location = new Point(x,3);
            }
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            this.label1.Text = DateTime.Now.ToString();
        }


    }
}
