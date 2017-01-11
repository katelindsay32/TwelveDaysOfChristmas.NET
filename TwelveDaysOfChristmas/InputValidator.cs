using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveDaysOfChristmas
{
    public class InputValidator
    {
        private readonly IConsole console;
        public InputValidator(IConsole c)
        {
            console = c;
        }

        public bool IsValid(string input)
        {
            int dayOfChristmas = 0;

            bool canParse = Int32.TryParse(input, out dayOfChristmas);

            if(!canParse)
            {
                console.WriteLine(Constants.Error_PleaseEnterNumber);
                return canParse;
            }

            if (dayOfChristmas  < 1 || dayOfChristmas > 12)
            {
                console.WriteLine(Constants.Error_PleaseEnterRange);
                return false;
            }

            return true;
        }
    }
}
