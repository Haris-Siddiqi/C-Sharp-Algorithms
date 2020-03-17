using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    class Program
    {
        // Calculates sum of each digit in a number
        public static Int32 SumOfDigits(Int32 num)
        {
            Int32 sum = 0;
            while (num != 0)
            {
                // gets the rightmost digit and adds it to sum
                sum += num % 10;
                // gets the rest of the number and updates num
                num = num / 10;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            // var
            Int32 number;

            // input
            Console.WriteLine("**   Digit Sum   **");
            Console.WriteLine("Only takes positive integers\n");
            Console.WriteLine("Please enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            // output
            Console.WriteLine("The sum of the digits is " + SumOfDigits(number) +".");
        }
    }
}
