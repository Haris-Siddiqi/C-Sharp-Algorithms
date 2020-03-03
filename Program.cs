using System;

namespace Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            // var
            Int32 randomNumber;
            Int32 guess;
            string message = "";

            // random number generator
            Random ranNumberGenerator = new Random();
            randomNumber = ranNumberGenerator.Next(1, 11);

            // input
            Console.WriteLine("I'm thinking of a number between 1 and 10...");
            Console.Write("Take a guess: ");
            guess = Convert.ToInt32(Console.ReadLine());

            // if statement
            if (guess == randomNumber)
            {
                message = "correct!";
            }
            else
            {
                if (guess < randomNumber)
                {
                    message = "too low...";
                }
                else
                {
                    message = "too high...";
                }
            }

            // output
            Console.WriteLine("\nMy number was " + randomNumber + "...");
            Console.WriteLine("Your guess was " + message);
        }
    }
}
