using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
namespace Sendemail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage email = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
 
                email.From = new MailAddress("fachryansyah123@gmail.com");
                email.To.Add(txtTo.Text);
                email.Subject = txtSubject.Text;
                email.Body = txtMessage.Text;
 
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("fachryansyah123@gmail.com","x454ya123");
                SmtpServer.EnableSsl = true;
 
                SmtpServer.Send(email);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}
