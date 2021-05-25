using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANTN2019_Lab5_Nhom1_19520982
{
    public partial class Email_Content : Form
    {
        public Email_Content(string from, string subject, string to, string data)
        {

            InitializeComponent();
            from_text.Text = from;
            subject_text.Text = subject;
            to_text.Text = to;
            body_text.Text = data;
        }

    }
}
