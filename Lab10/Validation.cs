using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Validation
    {
        //Prompts user to continue
        public static bool Continue()
        {
            Console.WriteLine("Do you want to continue? (y/n)");

            string input = Console.ReadLine();
            Console.Clear();

            if (input.ToLower() == "n")
            {
                return false;
            }
            else if (input.ToLower() == "y")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input");
                Continue();
                return true;
            }
        }

        
        //Validates that input is an integer
        public static int GetValidInteger()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please enter a valid input.");
            }

            return input;
        }
        //Validates that integer is within a given range
        public static int GetNumberInRange(int min, int max)
        {
            int input = GetValidInteger();
            while (input < min || input > max)
            {
                Console.WriteLine("Please enter an integer between {0} and {1}.", min, max);
                input = GetValidInteger();
            }
            return input;
        }

    }
}
