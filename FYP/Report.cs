using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

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

        private void button1_Click(object sender, EventArgs e)
        {
          //* try
            //{
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("wongpuiho0929@gmail.com");
                mail.To.Add("wongpuiho@gmail.com");
                mail.Subject = "Test Mail";
                mail.Body = "This is for testing SMTP mail from GMAIL";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("wongpuiho0929@gmail.com", "tommy985");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            //}
           /* catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }*/
        }
        
    }
}
