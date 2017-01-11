using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveDaysOfChristmas
{
    public class GiftCalculator
    {
        private readonly IConsole console;

        public GiftCalculator(IConsole c)
        {
            console = c;
        }

        public int CalculateGiftCount(int dayofChristmas, int currentGiftSum)
        {
            if (dayofChristmas == 0)
            {
                return currentGiftSum;
            }

            if (currentGiftSum == 0)
            {
                console.WriteLine(string.Format("On the {0}{1} day of Christmas, my true love gave to me...", dayofChristmas, Constants.tense[dayofChristmas]));
            }

            for (int i = dayofChristmas; i > 0; i--)
            {
                console.WriteLine(string.Format("{0} {1}", i, Constants.gifts[i]));
                currentGiftSum += i;
            }

            return CalculateGiftCount(dayofChristmas - 1, currentGiftSum);
        }

        public int CalculateGiftCountNonRecursive(int dayOfChristmas, int whatever)
        {
            int giftSum = 0;

            while (dayOfChristmas > 0)
            {
                for (int i = dayOfChristmas; i > 0; i--)
                {
                    giftSum += i;
                }
                dayOfChristmas--;
            }

            return giftSum;
        }
    }
}
