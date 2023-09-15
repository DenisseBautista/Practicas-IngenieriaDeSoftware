using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void pBword_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WINWORD.EXE");
        }

        private void pBpower_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("POWERPNT.EXE");
        }

        private void pBexcel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("EXCEL.EXE");
        }

        private void pBone_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ONENOTE.EXE");
        }

        private void pBreloj_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ms-clock:");
        }

        private void pBchr_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe");
        }

        private void pBadmin_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe");
        }

        private void pBcorreo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("OUTLOOK.EXE");
        }

        private void pBMedia_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("wmplayer.exe");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
