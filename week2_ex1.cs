using System;

namespace Excercise1
{
    /*
     * Input:
     * 3 numbers
     * 
     * Output:
     * average
     * 
     * Process:
     * get 3 numbers
     * add them
     * display average
     *
     */
    class Excercise1
    {
        static void Main(string[] args)
        {
            // Create variables
            double num1;
            double num2;
            double num3;
            double average;

            // Get value of num
            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            num3 = Convert.ToDouble(Console.ReadLine());

            // Add them and average
            average = (num1 + num2 + num3) / 3;

            // Display average
            Console.WriteLine("The average is " + average);
        }
    }
}
