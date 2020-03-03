using System;

namespace Ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            // var
            Int32 num1;
            Int32 num2;
            Int32 num3;
            string num;
            Int32 guess1;
            Int32 guess2;
            Int32 guess3;
            string guess;
            Int32 matches = 0;
            Int32 award;
            bool order = false;

            // generate ran num
            Random ranNumberGenerator = new Random();
            num1 = ranNumberGenerator.Next(1, 5);
            num2 = ranNumberGenerator.Next(1, 5);
            num3 = ranNumberGenerator.Next(1, 5);

            // input
            Console.WriteLine("Enter your first guess:");
            guess1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second guess:");
            guess2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your third guess:");
            guess3 = Convert.ToInt32(Console.ReadLine());

            // amalgamate numbers
            num = Convert.ToString(num1) + Convert.ToString(num2) + Convert.ToString(num3);
            guess = Convert.ToString(guess1) + Convert.ToString(guess2) + Convert.ToString(guess3);

            // guessed all three numbers in correct order
            if (num == guess)
            {
                order = true;
            }
            else
            {
                // compare each guess to each num
                for (int i = 0; i < 3; i++)
                {
                    for (int k = 0; i < 3; k++)
                    {
                        if (guess[i] == num[k])
                        {
                            matches += 1;
                        }
                    }
                }
            }

            // matches
            if (order == true)
            {
                award = 10000;
            }
            else
            {
                if (matches == 1)
                {
                    award = 10;
                }
                else if(matches == 2)
                {
                    award = 100;
                }
                else
                {
                    award = 1000;
                }
            }

            // output
            Console.WriteLine($"Your award is {award, 0:C}.");
        }
    }
}
