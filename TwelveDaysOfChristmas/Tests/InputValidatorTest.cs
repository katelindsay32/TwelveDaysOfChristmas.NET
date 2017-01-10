using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveDaysOfChristmas
{
    [TestClass]
    public class InputValidatorTest
    {
        private InputValidator inputValidator;

        [TestInitialize]
        public void Setup()
        {
            inputValidator = new InputValidator();
        }

        [TestMethod]
        public void TestNonNumericInput()
        {

        }

        [TestMethod]
        public void TestDayRangeInput()
        {

        }
    }
}
