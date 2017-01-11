using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TwelveDaysOfChristmas
{
    [TestClass]
    public class GiftCalculatorTest
    {
        private GiftCalculator giftCalculator;
        private Mock<IConsole> console;

        [TestInitialize]
        public void Setup()
        {
            console = new Mock<IConsole>();
            giftCalculator = new GiftCalculator(console.Object);
        }

        [TestMethod]
        public void FirstDayTest()
        {
            int gifts = giftCalculator.CalculateGiftCount(1, 0);
            Assert.AreEqual(1, gifts);
            console.Verify(f => f.WriteLine(It.IsAny<string>()), Times.Exactly(2));
            console.Verify(f => f.WriteLine(It.Is<string>(r => r.Contains("my true love gave to me"))), Times.Once());
        }

        [TestMethod]
        public void SecondDayTest()
        {
            int gifts = giftCalculator.CalculateGiftCount(2, 0);
            Assert.AreEqual(4, gifts);
            console.Verify(f => f.WriteLine(It.IsAny<string>()), Times.Exactly(4));
        }

        [TestMethod]
        public void ThirdDayTest()
        {
            int gifts = giftCalculator.CalculateGiftCount(3, 0);
            Assert.AreEqual(10, gifts);
        }

        [TestMethod]
        public void FourthDayTest()
        {
            int gifts = giftCalculator.CalculateGiftCount(4, 0);
            Assert.AreEqual(20, gifts);
        }

        [TestMethod]
        public void FifthDayTest()
        {
            int gifts = giftCalculator.CalculateGiftCount(5, 0);
            Assert.AreEqual(35, gifts);
        }

        [TestMethod]
        public void SixthDayTest()
        {
            int gifts = giftCalculator.CalculateGiftCount(6, 0);
            Assert.AreEqual(56, gifts);
        }

        [TestMethod]
        public void SeventhDayTest()
        {
            int gifts = giftCalculator.CalculateGiftCount(7, 0);
            Assert.AreEqual(84, gifts);
        }

        [TestMethod]
        public void EigthDayTest()
        {
            int gifts = giftCalculator.CalculateGiftCount(8, 0);
            Assert.AreEqual(120, gifts);
        }

        [TestMethod]
        public void NinthDayTest()
        {
            int gifts = giftCalculator.CalculateGiftCount(9, 0);
            Assert.AreEqual(165, gifts);
        }

        [TestMethod]
        public void TenthDayTest()
        {
            int gifts = giftCalculator.CalculateGiftCount(10, 0);
            Assert.AreEqual(220, gifts);
        }

        [TestMethod]
        public void EleventhDayTest()
        {
            int gifts = giftCalculator.CalculateGiftCount(11, 0);
            Assert.AreEqual(286, gifts);
        }

        [TestMethod]
        public void TwelthDayTest()
        {
            int gifts = giftCalculator.CalculateGiftCount(12, 0);
            Assert.AreEqual(364, gifts);
        }
    }
}
