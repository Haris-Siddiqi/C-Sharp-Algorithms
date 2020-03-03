using System;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            // var
            const string ontario = "ON";
            const string quebec = "PQ";
            string province;
            double cost = 0;

            // input
            Console.WriteLine("Please enter the province's 2 letter code:");
            province = Console.ReadLine();
            province = province.ToUpper();
            Console.WriteLine("Please enter the cost of the item:");
            cost = Convert.ToDouble(Console.ReadLine());
            double tax = 0;

            // if
            if (province == ontario)
            {
                tax = 0.14;
            }
            else if (province == quebec)
            {
                tax = 0.13;
            }

            // output
            Console.WriteLine("Your tax rate is " + Math.Round(tax*100, 0) + "%.");
            Console.WriteLine($"The cost of the item without tax is {cost, 0:C}.");
            Console.WriteLine($"Your total cost with tax is {(cost + (cost*tax)), 0:C}.");
        }
    }
}
