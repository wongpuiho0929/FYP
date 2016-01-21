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
    public partial class kitchenView : Form
    {
        private int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        private Database database;
        private int screenHeight = Screen.PrimaryScreen.Bounds.Height;
        private DataTable Odbt;
        private int btnV=0;
        public kitchenView()
        {
            InitializeComponent();
        }

        private void kitchenView_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Screen screen = System.Windows.Forms.Screen.PrimaryScreen;
            this.Width = screenWidth;
            this.Height = screenHeight;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.FLP1.Width = screenWidth - 200;
            this.FLP1.Height = screenHeight;
            this.gb1.Location = new Point(screenWidth - 200, 10);
            this.gb1.Width = 400;
            this.gb1.Height = screenHeight;
            database = new Database();
            database.Connection();
            Odbt = database.getDb("orders");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ListBox lb = new ListBox();
            lb.Font = new System.Drawing.Font("Arial", 30, System.Drawing.FontStyle.Italic);
            lb.ForeColor = Color.Black;
            lb.Height = screenHeight / 4;
            lb.Width = (screenWidth - 250) / 5;
            lb.Items.Add("id:001");
            lb.Items.Add("food:叉燒");
            lb.Enabled = false;
            FLP1.Controls.Add(lb);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(FLP1.Controls.Count.ToString());
            FLP1.Controls.RemoveAt(0);
        }

        private void btn_del2_Click(object sender, EventArgs e)
        {
                FLP1.Controls.RemoveByKey(txtId.Text);
        }

        

    }
}
