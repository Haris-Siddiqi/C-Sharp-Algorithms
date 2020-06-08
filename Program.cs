using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_1
{
    class Rational
    {
        public Int32 Numerator { get; private set; } // set/get on private var
        public Int32 Denominator { get; private set; }

        public Rational(Int32 num = 0, Int32 den = 1)
        {
            Numerator = num;
            Denominator = den;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public void IncreaseBy(Rational other)
        {
            Numerator = ((Numerator * other.Denominator) + (other.Numerator * Denominator));
            Denominator = Denominator * other.Denominator;
        }

        public void DecreaseBy(Rational other)
        {
            Numerator = ((Numerator * other.Denominator) - (other.Numerator * Denominator));
            Denominator = Denominator * other.Denominator;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rational a = new Rational();
            Rational b = new Rational(6);
            Rational c = new Rational(6, 2);
            Rational d = new Rational(5, 9);

            Console.WriteLine("We have created 4 rational objects.\n");
            Console.WriteLine($"a: {a}, b: {b}, c: {c}, d: {d}\n");

            a.IncreaseBy(c);
            Console.WriteLine($"The result of adding a and c is {a}.\n");

            b.DecreaseBy(d);
            Console.WriteLine($"The result of subtracting d from b is {b}.\n");
        }
    }
}
