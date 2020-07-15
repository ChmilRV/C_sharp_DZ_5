using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1. Реализовать класс для хранения комплексного числа. Выполнить в нем перегрузку всех
необходимых операторов для успешной компиляции следующего фрагмента кода.*/
namespace C_sharp_DZ_5_1
{
    class Complex
    {
        double x, y;
        public int X { get; set; }
        public int Y { get; set; }
        public Complex() { }
        public Complex(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public static Complex operator +(Complex z1, Complex z2)
        {
            Complex z = new Complex
            {
                x = z1.x + z2.x,
                y = z1.y + z2.y
            };
            return z;
        }
        public static Complex operator -(Complex z1, Complex z2)
        {
            Complex z = new Complex
            {
                x = z1.x - z2.x,
                y = z1.y - z2.y
            };
            return z;

        }
        public static Complex operator -(Complex z1, double n)
        {
            Complex z = new Complex
            {
                x = z1.x - n,
                y = z1.y
            };
            return z;
        }
        public static Complex operator *(Complex z1, Complex z2)
        {
            Complex z = new Complex
            {
                x = z1.x * z2.x - z1.y * z2.y,
                y = z1.y * z2.x + z1.x * z2.y
            };
            return z;
        }
        public static Complex operator *(double n, Complex z2)
        {
            Complex z = new Complex
            {
                x = n * z2.x,
                y = n * z2.y
            };
            return z;
        }
        public static Complex operator /(Complex z1, Complex z2)
        {
            Complex z = new Complex
            {
                x = (z1.x * z2.x + z1.y * z2.y) / (Math.Pow(z2.x, 2) + Math.Pow(z2.y, 2)),
                y = (z1.y * z2.y - z1.x * z2.y) / (Math.Pow(z2.x, 2) + Math.Pow(z2.y, 2))
            };
            return z;
        }
        public override string ToString()
        {
            return $"{x:F3} + {y:F3}*i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex z = new Complex(1, 1);
            Complex z1;
            z1 = z - (z * z * z - 1) / (3 * z * z);
            Console.WriteLine("z1 = {0}", z1);
            Complex zz = new Complex(1, 0);
            Complex zz1 = zz - (zz * zz * zz - 1) / (3 * zz * zz);
            Console.WriteLine("zz1 = {0}", zz1);
            Complex f = new Complex(2, 2);
            Complex f1 = f * f;
            Console.WriteLine("f1 = {0}", f1);
            Console.ReadKey();
        }
    }
}
