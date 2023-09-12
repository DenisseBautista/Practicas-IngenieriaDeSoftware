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
        Calculadora lectura = new Calculadora();
        public Form1()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btoper_Click(object sender, EventArgs e)
        {

            double x, op;
            x = double.Parse(tBx.Text);
            op = lectura.Op(x);
            lBsalida.Items.Add("Exponente:" + op);
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
            double x, se;
            x = double.Parse(tBx.Text);
            se = lectura.Se(x);
            lBsalida.Items.Add("Sen:" + se);
        }

        private void btoper3_Click(object sender, EventArgs e)
        {
            double x, co;
            x = lectura.Co(double.Parse(tBx.Text));
            lBsalida.Items.Add("Cos:" + x);
        }

        private void btoper4_Click(object sender, EventArgs e)
        {
            double x, ta;
            x = lectura.Ta(double.Parse(tBx.Text));
            lBsalida.Items.Add("Tan:" + x);
        }

        private void btoper5_Click(object sender, EventArgs e)
        {
            double x, senh;
            x = lectura.Se(double.Parse(tBx.Text));

            lBsalida.Items.Add("Senh:" + x);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double x;
            x = lectura.Se1(double.Parse(tBx.Text));
            lBsalida.Items.Add("ASen:" + x);
        }

        private void btoper9_Click(object sender, EventArgs e)
        {
            double x;
            x = lectura.Co1(double.Parse(tBx.Text));
            lBsalida.Items.Add("ACos:" + x);
        }

        private void btoper10_Click(object sender, EventArgs e)
        {
            double x;
            x = lectura.Ta1(double.Parse(tBx.Text));
            lBsalida.Items.Add("ATan:" + x);
        }

        private void btoper6_Click(object sender, EventArgs e)
        {
            double x;
            x = lectura.Cosh(double.Parse(tBx.Text));

            lBsalida.Items.Add("Cosh:" + x);
        }

        private void btoper7_Click(object sender, EventArgs e)
        {
            double x, tanh;
            x = lectura.Tanh(double.Parse(tBx.Text));

            lBsalida.Items.Add("Tanh:" + x);
        }

        private void btoper11_Click(object sender, EventArgs e)
        {
            double x;
            x = lectura.Lo(double.Parse(tBx.Text));

            lBsalida.Items.Add("Log(x):" + x);

        }

        private void btoper12_Click(object sender, EventArgs e)
        {
            double x, lon;
            x=lectura.Lon(double.Parse(tBx.Text));
            lBsalida.Items.Add("Ln:" + x);
           
        }

        private void btoper13_Click(object sender, EventArgs e)
        {
            double x;
            x = lectura.Pot(double.Parse(tBx.Text),double.Parse(tBy.Text));
            lBsalida.Items.Add("Potencia:" + x);
        }

        private void btSuma_Click(object sender, EventArgs e)
        {
            double x, y, r;
            x=lectura.Suma(double.Parse(tBx.Text), double.Parse(tBy.Text));
            lBsalida.Items.Add("Suma:" + x);


        }

        private void btResta_Click(object sender, EventArgs e)
        {
            double x;
            x = lectura.Resta(double.Parse(tBx.Text),double.Parse(tBy.Text));
           
            lBsalida.Items.Add("Resta:" + x);
        }

        private void btMulti_Click(object sender, EventArgs e)
        {
            double x;
            x = lectura.Multi(double.Parse(tBx.Text), double.Parse(tBy.Text));
          
            lBsalida.Items.Add("Multiplicación:" + x);
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            double x, y, r;
            x = lectura.Div(double.Parse(tBx.Text), double.Parse(tBy.Text));
    
            lBsalida.Items.Add("División:" + x);
        }

        private void btMod_Click(object sender, EventArgs e)
        {
            double x, y, r;
            x = lectura.Porcien(double.Parse(tBx.Text), double.Parse(tBy.Text));
            lBsalida.Items.Add("Residuo:" + x);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
