using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveDaysOfChristmas
{
    public class GiftCalculator
    {
        public int CalculateGiftCount(int dayofChristmas, int currentGiftSum)
        {
            if (dayofChristmas == 0)
            {
                return currentGiftSum;
            }

            if (currentGiftSum == 0)
            {
                Console.WriteLine(string.Format("On the {0}{1} day of Christmas, my true love gave to me...", dayofChristmas, Constants.tense[dayofChristmas]));
            }

            for (int i = dayofChristmas; i > 0; i--)
            {
                Console.WriteLine(string.Format("{0} {1}", i, Constants.gifts[i]));
                currentGiftSum += i;
            }

            return CalculateGiftCount(dayofChristmas - 1, currentGiftSum);
        }
    }
}
