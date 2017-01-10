using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveDaysOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            InputValidator input = new InputValidator();
            int dayOfChristmas = input.GetInput();

            GiftCalculator calculator = new GiftCalculator();
            var totalGifts = calculator.CalculateGiftCount(dayOfChristmas, 0);

            Console.WriteLine(string.Format("That is a whopping total of {0} gifts. Lucky you.", totalGifts));
            Console.ReadLine();
        }
    }
}
