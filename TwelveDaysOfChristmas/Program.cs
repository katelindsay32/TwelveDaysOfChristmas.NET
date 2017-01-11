using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveDaysOfChristmas
{
    class Program
    {
        private static ConsoleWrapper console;

        static void Main(string[] args)
        {
            console = new ConsoleWrapper();
            console.WriteLine("What day is it?");

            string input = console.ReadLine();

            int dayOfChristmas = ValidateInput(input);

            GiftCalculator calculator = new GiftCalculator(console);
            var totalGifts = calculator.CalculateGiftCount(dayOfChristmas, 0);

            console.WriteLine(string.Format("That is a whopping total of {0} gifts. Lucky you.", totalGifts));
            console.ReadLine();
        }

        private static int ValidateInput(string input)
        {
            InputValidator inputValidator = new InputValidator(console);
            bool isValidInput = inputValidator.IsValid(input);

            while (!isValidInput)
            {
                input = console.ReadLine();
                isValidInput = inputValidator.IsValid(input);
            }

            return Convert.ToInt32(input);
        }
    }
}
