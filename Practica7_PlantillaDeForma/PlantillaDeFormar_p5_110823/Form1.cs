using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantillaDeFormar_p5_110823
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btoper_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(tBx.Text);
            r = Math.Exp(x);
            lBsalida.Items.Add(r);

        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Proyecto1.exe");

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, sen;
            x = double.Parse(tBx.Text);
            sen = Math.Sin(x);
            lBsalida.Items.Add("Sen:"+sen);
        }

        private void btoper3_Click(object sender, EventArgs e)
        {
            double x,co;
            x = double.Parse(tBx.Text);
            co=Math.Cos(x);
            lBsalida.Items.Add("Cos:"+co);
        }

        private void btoper4_Click(object sender, EventArgs e)
        {
            double x, ta;
            x=double.Parse(tBx.Text);
            ta=Math.Tan(x);
            lBsalida.Items.Add("Tan"+ta);
        }

        private void btoper5_Click(object sender, EventArgs e)
        {
            double x, senh;
            x = double.Parse(tBx.Text);
            senh = Math.Sinh(x);
            lBsalida.Items.Add("Senh:"+senh);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double x, sen1;
            x=double.Parse(tBx.Text);
            sen1 = Math.Asin(x);
            lBsalida.Items.Add("ASen:"+sen1);

        }

        private void btoper9_Click(object sender, EventArgs e)
        {
            double x, cos1;
            x = double.Parse(tBx.Text);
            cos1 = Math.Acos(x);
            lBsalida.Items.Add("ACos:"+cos1);
        }

        private void btoper10_Click(object sender, EventArgs e)
        {
            double x, tan1;
            x = double.Parse(tBx.Text);
            tan1 = Math.Atan(x);
            lBsalida.Items.Add("ATan:"+tan1);
        }

        private void btoper6_Click(object sender, EventArgs e)
        {
            double x, cosh;
            x = double.Parse(tBx.Text);
            cosh = Math.Cosh(x);
            lBsalida.Items.Add("Cosh:"+cosh);
        }

        private void btoper7_Click(object sender, EventArgs e)
        {
            double x, tanh;
            x = double.Parse(tBx.Text);
            tanh = Math.Tanh(x);
            lBsalida.Items.Add("Tanh:"+tanh);
        }

        private void btoper11_Click(object sender, EventArgs e)
        {
            double x, lo;
            x=double.Parse(tBx.Text); 
            lo = Math.Log10(x);
            lBsalida.Items.Add("Log(x):" + lo);

        }

        private void btoper12_Click(object sender, EventArgs e)
        {
            double x, lon;
            x=double.Parse(tBx.Text);
            lon = Math.Log(x);
        }

        private void btoper13_Click(object sender, EventArgs e)
        {
            double x, y, pot;
            x = double.Parse(tBx.Text);
            y=double.Parse(tBy.Text);
            pot = Math.Pow(x, y);
            lBsalida.Items.Add("Potencia:" + pot);
        }

        private void btSuma_Click(object sender, EventArgs e)
        {
            double x, y, r;
            x=double.Parse(tBx.Text);
            y= double.Parse(tBy.Text);
            r = (x + y);
            lBsalida.Items.Add("Suma:" + r);


        }

        private void btResta_Click(object sender, EventArgs e)
        {
            double x, y, r;
            x = double.Parse(tBx.Text);
            y = double.Parse(tBy.Text);
            r = (x - y);
            lBsalida.Items.Add("Resta:" + r);
        }

        private void btMulti_Click(object sender, EventArgs e)
        {
            double x, y, r;
            x = double.Parse(tBx.Text);
            y = double.Parse(tBy.Text);
            r = (x * y);
            lBsalida.Items.Add("Multiplicación:" + r);
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            double x, y, r;
            x = double.Parse(tBx.Text);
            y = double.Parse(tBy.Text);
            r = (x / y);
            lBsalida.Items.Add("División:" + r);
        }

        private void btMod_Click(object sender, EventArgs e)
        {
            double x, y, r;
            x = double.Parse(tBx.Text);
            y = double.Parse(tBy.Text);
            r = (x % y);
            lBsalida.Items.Add("Residuo:" + r);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
