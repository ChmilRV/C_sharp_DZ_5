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
        int a;
        int b;
        public int A { get; set; }
        public int B
        {
            get { return b; }
            set
            {
                if (value != 0) b = value;
                else b=1;
            }
        }
        public Fraction() { }
        public Fraction(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static Fraction operator +(Fraction z1, Fraction z2)
        {
            Fraction z = new Fraction
            {
                a = z1.a * z2.b + z2.a * z1.b,
                b = z1.b * z2.b
            };
            return z;
        }
        public static Fraction operator +(Fraction z1, double d)
        {
            Fraction temp = DoubleToFraction(d);
            Fraction z = new Fraction
            {
                a = z1.a * temp.b + temp.a * z1.b,
                b = z1.b * temp.b
            };
            return z;
        }
        public static Fraction operator -(Fraction z1, Fraction z2)
        {
            Fraction z = new Fraction
            {
                a = z1.a * z2.b - z2.a * z1.b,
                b = z1.b * z2.b
            };
            return z;
        }
        public static Fraction operator *(Fraction z1, Fraction z2)
        {
            Fraction z = new Fraction
            {
                a = z1.a * z2.a,
                b = z1.b * z2.b
            };
            return z;
        }
        public static Fraction operator *(Fraction z1, int n)
        {
            Fraction z = new Fraction
            {
                a = z1.a * n,
                b = z1.b
            };
            return z;
        }
        public static Fraction operator *(int n, Fraction z1)
        {
            Fraction z = new Fraction
            {
                a = z1.a * n,
                b = z1.b
            };
            return z;
        }
        public static Fraction operator /(Fraction z1, Fraction z2)
        {
            Fraction z = new Fraction
            {
                a = z1.a * z2.b,
                b = z1.b * z2.a
            };
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
        public static bool operator true(Fraction z1)
        {
            return z1.a < z1.b;
        }
        public static bool operator false(Fraction z1)
        {
            return z1.a > z1.b;
        }
        public static bool operator >(Fraction z1, Fraction z2)
        {
            return (double)(z1.a / z1.b) > (double)(z2.a / z2.b);
        }
        public static bool operator <(Fraction z1, Fraction z2)
        {
            return (double)(z1.a / z1.b) < (double)(z2.a / z2.b);
        }
        public static Fraction DoubleToFraction(double d)
        {
            Fraction z;
            if (d % 1 == 0) z = new Fraction((int)d, 1);
            else
            {
                int i = 0;
                do
                {
                    d *= 10;
                    i++;
                }
                while (d % 1 != 0);
                z = new Fraction((int)d, i * 10);
            }
            return z;
        }
        public override bool Equals(object obj)
        {
            Fraction frac = (Fraction)obj;
            return (a == frac.a && b == frac.b);
        }
        public override int GetHashCode()
        {
            return (Convert.ToInt32((a ^ b) & 0xFFFFFFFF));
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
            Fraction f3 = f + d;
            Console.WriteLine($"f3={f3}");
            Fraction frac_d = Fraction.DoubleToFraction(d);
            Console.WriteLine($"frac_d={frac_d}");
            Console.ReadKey();
        }
    }
}