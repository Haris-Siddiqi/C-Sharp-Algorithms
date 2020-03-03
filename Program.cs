using System;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            // var
            double gpa;
            double score;

            // input
            Console.WriteLine("Please enter your GPA:");
            gpa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your admission score:");
            score = Convert.ToDouble(Console.ReadLine());

            // if statement
            if (gpa >= 3.0)
            {
                if (score >= 60)
                {
                    Console.WriteLine("Accept");
                }
            }
            else if (score >= 80)
            {
                Console.WriteLine("Accept");
            }
            else
            {
                Console.WriteLine("Reject");
            }
        }
    }
}
