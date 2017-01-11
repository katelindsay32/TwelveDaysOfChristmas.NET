using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
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
        private Mock<IConsole> console;

        [TestInitialize]
        public void Setup()
        {
            console = new Mock<IConsole>();
            inputValidator = new InputValidator(console.Object);
        }

        [TestMethod]
        public void TestNonNumericInput()
        {
            var result = inputValidator.IsValid("2kdkl");
            Assert.IsFalse(result);
            console.Verify(f => f.WriteLine(Constants.Error_PleaseEnterNumber), Times.Once());
        }

        [TestMethod]
        public void TestDayRangeInput()
        {
            var result = inputValidator.IsValid("555");
            Assert.IsFalse(result);
            console.Verify(f => f.WriteLine(Constants.Error_PleaseEnterRange), Times.Once());
        }

        [TestMethod]
        public void PositiveInputTest()
        {
            var result = inputValidator.IsValid("5");
            Assert.IsTrue(result);
        }
    }
}
