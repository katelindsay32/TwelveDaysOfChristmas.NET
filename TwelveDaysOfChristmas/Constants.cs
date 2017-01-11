using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveDaysOfChristmas
{
    public class Constants
    {
        public static Dictionary<int, string> gifts = new Dictionary<int, string>()
        {
            { 1, "Partridge in a pear tree"},
            { 2, "Turtle Doves" },
            { 3, "French Hens" },
            { 4, "Calling Birds" },
            { 5, "Golden Rings" },
            { 6, "Geese-a-laying" },
            { 7, "Swans-a-swimming" },
            { 8, "Maids-a-Milkin'" },
            { 9, "Ladies Dancin'" },
            { 10, "Lords-a-leapin'" },
            { 11, "Pipers Piping" },
            { 12, "Drummers drumming" }
        };

        public static Dictionary<int, string> tense = new Dictionary<int, string>()
        {
            { 1, "st"},
            { 2, "nd" },
            { 3, "rd" },
            { 4, "th" },
            { 5, "th" },
            { 6, "th" },
            { 7, "th" },
            { 8, "th" },
            { 9, "th" },
            { 10, "th" },
            { 11, "th" },
            { 12, "th" }
        };

        public static string Error_PleaseEnterNumber = "Please enter a number";
        public static string Error_PleaseEnterRange = "Please enter a number between 1 and 12";
    }
}
