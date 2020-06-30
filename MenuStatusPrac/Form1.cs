using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStatusPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 새파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("새 파일 짠~");
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 배고파ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "배고파 ㅠㅠ";
            toolStripProgressBar1.Value = 10;
        }

        private void 보통ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "그냥저냥~ ㅇㅅㅇ";
            toolStripProgressBar1.Value = 60;
        }

        private void 배불러ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "배불러 >__<";
            toolStripProgressBar1.Value = 100;
        }
    }
}
