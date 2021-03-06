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
    public partial class Bai3 : Form
    {
        public Bai3()
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
            file_attach.Text = "";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string mailfrom = rtbFrom.Text.Trim();
            string mailto = rtbTo.Text.Trim();
            string password = rtbPassword.Text.Trim();
            string subject = rtbSubject.Text.Trim();
            string body = rtbBody.Text.Trim();

            SendGmail(subject, body, mailto, mailfrom, password);
        }

        private void SendGmail(string subject, string body, string mailto, string mailfrom, string password)
        {



            using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
            {
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(mailfrom, password);

                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(mailfrom);
                    message.From = fromAddress;
                    message.Subject = subject;
                    message.IsBodyHtml = true;
                    message.To.Add(mailto);
                    message.Body = body;

                    if (file_attach.Text != "")
                    {
                        Attachment attachment = new Attachment(file_attach.Text);
                        message.Attachments.Add(attachment);
                    }

                    try
                    {
                        smtpClient.Send(message);
                        MessageBox.Show("Send successfully!");
                        CleanUp();

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        CleanUp();
                    }
                }
            }

        }

        private void attach_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if(ofd.ShowDialog()== DialogResult.OK)
            {
                file_attach.Text = ofd.FileName;
            }
        }
    }
}
