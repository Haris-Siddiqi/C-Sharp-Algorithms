using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    class Program
    {
        // prime checking function
        public static bool PrimeCheck(Int32 num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            // var
            Int32 num1;

            // input
            Console.WriteLine("*****Prime Checker Program*****\n");
            Console.Write("Please enter an integer: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            // output
            if (PrimeCheck(num1) == true)
            {
                Console.WriteLine($"{num1} is prime.");
            }
            else
            {
                Console.WriteLine($"{num1} is not prime.");
            }
        }
    }
}
