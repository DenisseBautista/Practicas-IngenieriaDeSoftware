using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipo int tamaño int: {0} Rango[{1},{2}]", sizeof(int), int.MinValue, int.MaxValue);
            Console.WriteLine("Tipo int tamaño float: {0} Rango[{1},{2}]", sizeof(float), float.MinValue, float.MaxValue);
            Console.WriteLine("Tipo int tamaño double: {0} Rango[{1},{2}]", sizeof(double), double.MinValue, double.MaxValue);
            Console.WriteLine("Tipo int tamaño INT16: {0} Rango[{1},{2}]", sizeof(Int16), Int16.MinValue, Int16.MaxValue);
            Console.WriteLine("Tipo int tamaño INT32: {0} Rango[{1},{2}]", sizeof(Int32), Int32.MinValue, Int32.MaxValue);
            Console.WriteLine("Tipo int tamaño Double: {0} Rango[{1},{2}]", sizeof(Double), Double.MinValue, Double.MaxValue);
            Console.WriteLine("Tipo int tamaño Boolean: {0} ", sizeof(Boolean));
            Console.WriteLine("Tipo int tamaño bool: {0} ", sizeof(bool));
            Console.WriteLine("Tipo int tamaño  char: {0} Rango[{1},{2}]", sizeof(char), char.MinValue, char.MaxValue);
    
        }
    }
}
