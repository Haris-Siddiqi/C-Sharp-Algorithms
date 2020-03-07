using System;

namespace Week3_excercise
{
    /*
     * Excercise 2
     */
    class ex2
    {
        static void Main(string[] args)
        {
            // Get user info
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("SIN: ");
            string sin = Console.ReadLine();

            Console.Write("Hourly pay rate: ");
            Int32 hourlyRate = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hours worked: ");
            Int32 hoursWorked = Convert.ToInt32(Console.ReadLine());

            // Display info
            Console.WriteLine("\nPayroll summary for " + name);
            Console.WriteLine("SIN: " + sin);
            Console.WriteLine("You worked " + hoursWorked + " hours at $" + hourlyRate + " per hour");

            // Calculations
            Int32 grossPay = hoursWorked * hourlyRate;
            double federalTax = grossPay * .15;
            double provincialTax = grossPay * .1;
            double netPay = grossPay - provincialTax - federalTax;

            // Table
            Console.WriteLine($"\nGross pay: {grossPay, 20:C}");
            Console.WriteLine($"Federal tax: {federalTax, 18:C}");
            Console.WriteLine($"Provincial tax: {provincialTax, 15:C}");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Net pay: {netPay, 22:C}");

            //string outpuy = $"s {a} other string {a, 8:C}";
        }
    }
}
