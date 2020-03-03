using System;

namespace ex3b
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finish = false;
            // While loop for restarting program
            do
            {
                // Input
                Console.WriteLine("This program converts liters to gallons for you.");
                double gallons = 0;

                // Check input format
                bool format = false;
                do
                {
                    Console.Write("Enter the number of gallons: ");
                    string input = Console.ReadLine();

                    // See if input is a number
                    try
                    {
                        gallons = Convert.ToDouble(input);
                        format = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("This is not a number");
                    }
                } while (format == false);

                // Output
                Console.WriteLine(gallons + " gallons is " + Math.Round(gallons * 3.785, 2) + " liters.");

                // End program or restart
                Console.Write("Press y if you want to exit.");
                if (Console.ReadLine() == "y")
                {
                    finish = true;
                }
                // Add space if restarting the program
                else
                {
                    Console.WriteLine("\n");
                }
            } while (finish == false);
        }
    }
}
