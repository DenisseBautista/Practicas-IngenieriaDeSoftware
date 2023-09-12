using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantillaDeFormar_p5_110823
{
    internal class Calculadora
    {
        public Calculadora() { }
        public double Op(double x)
        {
            double r;
            r = Math.Exp(x);
            return r;
        }



        public double Se(double x)
        {
            double sen;
            sen = Math.Sin(x);
            return sen;
        }

        public double Co(double x)
        {
            double co;
            co = Math.Cos(x);
            return co;
        }
        public double Ta(double x)
        {
            double ta;
            ta = Math.Tan(x);
            return ta;
        }
        public double Senh(double x)
        {
            double senh;
            senh = Math.Sinh(x);
            return senh;
        }

        public double Se1(double x)
        {
            double sen1;
            sen1 = Math.Asin(x);
            return sen1;

        }
        public double Co1(double x)
        {
            double cos1;
            cos1 = Math.Acos(x);
            return cos1;

        }
        public double Ta1(double x)
        {
            double tan1;
            tan1 = Math.Atan(x);
            return tan1;

        }
        public double Cosh(double x)
        {
            double cosh;
            cosh = Math.Cosh(x);
            return cosh;
        }
        public double Tanh(double x)
        {
            double tanh;
            tanh = Math.Tanh(x);
            return tanh;
        }
        public double Lo(double x)
        {
            double lo;
            lo = Math.Log10(x);
            return lo;
        }
        public double Lon(double x)
        {
            double lon;
            lon = Math.Log(x);
            return lon;
        }
        public double Pot(double x, double y)
        {
            double pot;
            pot = Math.Pow(x, y);
            return pot;
        }
        public double Suma(double x, double y)
        {
            double suma;
            suma = (x + y);
            return suma;
        }
        public double Resta(double x, double y)
        {
            double resta;
            resta = (x - y);
            return resta;
        }

        public double Multi (double x, double y)
        {
            double multi;
            multi = (x * y);
            return multi;
        }
        public double Div(double x, double y)
        {
            double div;
            div = (x / y);
            return div;
        }
        public double Porcien(double x, double y)
        {
            double porcien;
            porcien = (x % y);
            return porcien;
        }

    }
}
