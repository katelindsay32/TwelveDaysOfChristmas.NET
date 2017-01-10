using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveDaysOfChristmas
{
    public class InputValidator
    {
        public int GetInput()
        {
            Console.WriteLine("What day is it?");
            bool isValidInput = false;
            string input = string.Empty;

            while (!isValidInput)
            {
                input = Console.ReadLine();
                isValidInput = IsValid(input);
            }

            return Convert.ToInt32(input);
        }

        public bool IsValid(string input)
        {
            int dayOfChristmas = 0;

            bool canParse = Int32.TryParse(input, out dayOfChristmas);

            if(!canParse)
            {
                Console.WriteLine("Please enter a number");
                return canParse;
            }

            if (dayOfChristmas  < 1 || dayOfChristmas > 12)
            {
                Console.WriteLine("Please enter a number between 1 and 12");
                return false;
            }

            return true;
        }
    }
}
