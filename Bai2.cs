using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit;
using MimeKit;

namespace ANTN2019_Lab5_Nhom1_19520982
{
    public partial class Bai2 : Form
    {
        private IMailFolder inbox;
        public Bai2()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                MessageBox.Show("Invalid Email!");
                return;
            }

            if (password_text.Text == "")
            {
                MessageBox.Show("Invalid Password!");
                return;
            }

            var client = new ImapClient();
            client.Connect("127.0.0.1", 143, MailKit.Security.SecureSocketOptions.None);
            client.Authenticate(email_text.Text, password_text.Text);

            inbox = client.Inbox;

            inbox.Open(FolderAccess.ReadOnly);

            total_label.Text = inbox.Count.ToString();
            recent_label.Text = inbox.Recent.ToString();

            for (int i = 0; i < inbox.Count; i++)
            {
                var message = inbox.GetMessage(i);
                ListViewItem name = new ListViewItem(message.Subject);

                ListViewItem.ListViewSubItem from = new ListViewItem.ListViewSubItem(name, message.From.ToString());
                name.SubItems.Add(from);

                ListViewItem.ListViewSubItem date = new ListViewItem.ListViewSubItem(name, message.Date.Date.ToString());
                name.SubItems.Add(date);
                listView1.Items.Add(name);
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            for(int i =0;i<listView1.Items.Count;i++)
            {
                var rectangle = listView1.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    var message = inbox.GetMessage(i);
                    string from = "",subject ="",to = "",textbody = "";
                    if(message.From!=null)
                    {
                        from = message.From.ToString();
                    }

                    if(message.Subject!=null)
                    {
                        subject = message.Subject.ToString();
                    }

                    if(message.To!=null)
                    {
                        to = message.To.ToString();
                    }

                    if(message.TextBody!=null)
                    {
                        textbody = message.TextBody.ToString();
                    }

                    new Email_Content(from,subject,to,textbody).Show();
                    return;
                }
            }
        }
    }
}
