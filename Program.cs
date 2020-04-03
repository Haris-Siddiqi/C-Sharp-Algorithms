using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week9_excercises
{
    class Program
    {
        // Returns if all the factors of a number sum to the number 
        public static bool IsPerfect(Int32 num)
        {
            Int32 sum = 0;
            // get all factors of a number and sum them
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            // if sum = num then its perfect
            if (sum == num)
            {
                return true;
            }
            return false;
        }

        public static Int32 GetNumber()
        {
            bool flag = false;
            Int32 userNum = 0;
            // ask user to input number until it is perfect
            while (flag == false)
            {
                Console.Write("Please enter a number: ");
                userNum = Convert.ToInt32(Console.ReadLine());
                if (IsPerfect(userNum) == true)
                {
                    flag = true;
                }
            }
            // return perfect number
            return userNum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("A perfect number is a number whose factors (exc itself) sum to itself.");
            Console.WriteLine("This program will keep asking you to input a number until it is perfect.");
            Console.WriteLine("****************************************************************************\n");
            Int32 perfectNum = GetNumber();
            Console.WriteLine($"The perfect number is {perfectNum}.");
        }
    }
}
