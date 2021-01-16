using Microsoft.VisualStudio.TestTools.UnitTesting;
using p25_euler;



namespace p25_euler_tests
{
    [TestClass]
    public class TestDigitCounter
    {

        [TestMethod]
        public void TestGetNumberOfDigits()
        {
            Assert.AreEqual(1, DigitCounter.GetNumberOfDigits(1));
            Assert.AreEqual(2, DigitCounter.GetNumberOfDigits(-11));
            Assert.AreEqual(5, DigitCounter.GetNumberOfDigits(54611));
            Assert.AreEqual(1, DigitCounter.GetNumberOfDigits(-1));
            Assert.AreEqual(8, DigitCounter.GetNumberOfDigits(-56145641));

        }
    }
}
