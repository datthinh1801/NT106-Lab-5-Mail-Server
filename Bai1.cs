using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace ANTN2019_Lab5_Nhom1_19520982
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void CleanUp()
        {
            rtbFrom.Text = "";
            rtbTo.Text = "";
            rtbSubject.Text = "";
            rtbPassword.Text = "";
            rtbBody.Text = "";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            using (SmtpClient smtpClient = new SmtpClient("127.0.0.1"))
            {
                string mailfrom = rtbFrom.Text.Trim();
                string mailto = rtbTo.Text.Trim();
                string password = rtbPassword.Text.Trim();
                var basicCredential = new NetworkCredential(mailfrom, password);

                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(mailfrom);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;

                    message.From = fromAddress;
                    message.Subject = rtbSubject.Text.Trim();
                    message.IsBodyHtml = true;
                    message.Body = rtbBody.Text;
                    message.To.Add(mailto);

                    try
                    {
                        smtpClient.Send(message);
                        MessageBox.Show("Send successfully!");
                        CleanUp();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        CleanUp();
                    }
                }
            }
        }
    }
}
