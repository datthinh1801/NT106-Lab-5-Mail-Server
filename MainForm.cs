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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            new Bai1().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Bai2().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Bai3().Show();
        }
    }
}
