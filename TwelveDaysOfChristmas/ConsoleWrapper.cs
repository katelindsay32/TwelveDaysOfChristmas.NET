using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveDaysOfChristmas
{
    public class ConsoleWrapper : IConsole
    {
        public string ReadLine()
        {
            var test = Console.ReadLine();
            return test;
        }

        public void WriteLine(string writeString)
        {
            Console.WriteLine(writeString);
        }
    }
}
