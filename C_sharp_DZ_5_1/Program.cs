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
        public Complex() { }
        public Complex(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public static Complex operator +(Complex z1, Complex z2)
        {
            Complex z = new Complex();
            z.x = z1.x + z2.x;
            z.y = z1.y + z2.y;
            return z;
            //return new Complex(z1.x + z2.x, z1.y + z1.y);
        }
        public static Complex operator -(Complex z1, Complex z2)
        {
            Complex z = new Complex();
            z.x = z1.x - z2.x;
            z.y = z1.y - z2.y;
            return z;
            //return new Complex(z1.x - z2.x, z1.y - z1.y);
        }
        public static Complex operator -(Complex z1, double n)
        {
            Complex z = new Complex();
            z.x = z1.x - n;
            z.y = z1.y;
            return z;
            //return new Complex(z1.x - n, z1.y);
        }
        public static Complex operator *(Complex z1, Complex z2)
        {
            Complex z = new Complex();
            z.x = z1.x * z2.x - z1.y * z2.y;
            z.y = z1.y * z2.x + z1.x * z2.y;
            return z;
            //return new Complex(z1.x * z2.x - z1.y * z2.y, z1.y * z2.x + z1.x * z2.y);
        }
        public static Complex operator *(double n, Complex z2)
        {
            Complex z = new Complex();
            z.x = n * z2.x;
            z.y = n * z2.y;
            return z;
            //return new Complex(n * z2.x, n * z2.y);
        }
        public static Complex operator /(Complex z1, Complex z2)
        {
            Complex z = new Complex();
            z.x = (z1.x * z2.x + z1.y * z2.y) / (Math.Pow(z2.x, 2) + Math.Pow(z2.y, 2));
            z.y = (z1.y * z2.y - z1.x * z2.y) / (Math.Pow(z2.x, 2) + Math.Pow(z2.y, 2));
            return z;
        }
        public override string ToString()
        {
            return $"{x:F2} + {y:F2}*i";
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
            Console.ReadKey();
        }
    }
}
