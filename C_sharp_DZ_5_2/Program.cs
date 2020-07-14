using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2. Разработать класс Fraction, представляющий простую дробь.
В классе предусмотреть два поля: числитель и знаменатель дроби.
Выполнить перегрузку следующих операторов: +,-,*,/,==,!=,<,>, true и false.
Арифметические действия и сравнение выполняется в соответствии с правилами работы с дробями.
Оператор true возвращает true если дробь правильная (числитель меньше знаменателя),
оператор false возвращает true если дробь неправильная (числитель больше знаменателя).*/
namespace C_sharp_DZ_5_2
{
    class Fraction
    {
        int a, b;
        public Fraction()
        {
            b = 1;
        }
        public Fraction(int a, int b)
        {
            if (b == 0) { throw new DivideByZeroException("Знаменатель не может быть ноль"); }
            //if (b == 0)
            //{
            //    b = 1;
            //    Console.WriteLine("Знаменатель не может быть ноль");
            //}
            this.a = a;
            this.b = b;
        }
        public static Fraction operator +(Fraction z1, Fraction z2)
        {
            Fraction z = new Fraction();
            z.a = z1.a * z2.b + z2.a * z1.b;
            z.b = z1.b * z2.b;
            return z;
        }
        //public static Fraction operator +(Fraction z1, double d)
        //{
        //    Fraction temp = ToFraction(d);
        //    Initialize(temp.Numerator, temp.Denominator);
        //    Fraction z = new Fraction();
        //    z.a = z1.a + z1.b * d;
        //    z.b = z1.b;
        //    return z;
        //}

        public static Fraction operator -(Fraction z1, Fraction z2)
        {
            Fraction z = new Fraction();
            z.a = z1.a * z2.b - z2.a * z1.b;
            z.b = z1.b * z2.b;
            return z;
        }
        public static Fraction operator *(Fraction z1, Fraction z2)
        {
            Fraction z = new Fraction();
            z.a = z1.a * z2.a;
            z.b = z1.b * z2.b;
            return z;
        }
        public static Fraction operator *(Fraction z1, int n)
        {
            Fraction z = new Fraction();
            z.a = z1.a * n;
            z.b = z1.b;
            return z;
        }
        public static Fraction operator *(int n, Fraction z1)
        {
            Fraction z = new Fraction();
            z.a = z1.a * n;
            z.b = z1.b;
            return z;
        }
        public static Fraction operator /(Fraction z1, Fraction z2)
        {
            Fraction z = new Fraction();
            z.a = z1.a * z2.b;
            z.b = z1.b * z2.a;
            return z;
        }

        public static bool operator ==(Fraction z1, Fraction z2)
        {
            return z1.Equals(z2);
        }
        public static bool operator !=(Fraction z1, Fraction z2)
        {
            return !(z1 == z2);
        }

        public static bool operator >(Fraction z1, Fraction z2)
        {
            if (Convert.ToDouble(z1.a / z1.b) - Convert.ToDouble(z2.a / z2.b)>0) return true;
        }

        public static bool operator <(Fraction z1, Fraction z2)
        {
            if (Convert.ToDouble(z1.a / z1.b) - Convert.ToDouble(z2.a / z2.b) > 0) return true;
        }

        public static bool operator true(Fraction z1)
        {
            return z1.a < z1.b ? true : false;
        }
        public static bool operator false(Fraction z1)
        {
            return z1.a > z1.b ? true : false;
        }



        public override string ToString()
        {
            return $"{a}/{b}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction(3, 4);
            Console.WriteLine($"f={f}");
            int a = 10;
            Fraction f1 = f * a;
            Console.WriteLine($"f1={f1}");
            Fraction f2 = a * f;
            Console.WriteLine($"f2={f2}");
            double d = 1.5;
            //Fraction f3 = f + d;


            //Fraction f = new Fraction(3, 0);
            //Console.WriteLine($"f={f}");
            //Fraction r = new Fraction();
            //Console.WriteLine($"r={r}");




            Console.ReadKey();
        }
    }
}