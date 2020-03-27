using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            // var
            double starting_Value;
            double ending_Value;
            double increments;
            double fahrenheit;

            // input
            Console.Write("Please enter a starting celsius value: ");
            starting_Value = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter an ending celsius value: ");
            ending_Value = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the increments between celsius values: ");
            increments = Convert.ToDouble(Console.ReadLine());

            // output
            Console.WriteLine("\nCelsius\t\tFahrenheit");

            // for loop
            for (double i = starting_Value; i <= ending_Value; i += increments)
            {
                fahrenheit = ((9.1 / 5.0) * i) + 32;
                Console.WriteLine(i + "\t\t" + Math.Round(fahrenheit, 0));
            }

            Console.WriteLine("\n");
        }
    }
}
