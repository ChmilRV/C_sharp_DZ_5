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
            if (b == 0) { throw new DivideByZeroException("В знаменателе не может быть нуля"); }
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
        //    Fraction z = new Fraction();
        //    z.a = z1.a + z1.b * d;
        //    z.b = z1.b;
        //    return z;
        //}


        public override string ToString()
        {
            return $"{a}/{b}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Fraction f = new Fraction(3, 4);
            //int a = 10;
            //Fraction f1 = f * a;
            //Fraction f2 = a * f;
            //double d = 1.5;
            //Fraction f3 = f + d;


            Fraction f = new Fraction(3, 4);
            Console.WriteLine($"f={f}");
            Fraction r = new Fraction();
            Console.WriteLine($"r={r}");




            Console.ReadKey();
        }
    }
}
