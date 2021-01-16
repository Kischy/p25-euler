using Microsoft.VisualStudio.TestTools.UnitTesting;
using p25_euler;



namespace p25_euler_tests
{
    [TestClass]
    public class TestDigitCounter
    {

        [TestMethod]
        public void TestGetNumberOfDigitsPosNum()
        {
            Assert.AreEqual(1, DigitCounter.GetNumberOfDigitsPosNum(1));
            Assert.AreEqual(2, DigitCounter.GetNumberOfDigitsPosNum(11));
            Assert.AreEqual(5, DigitCounter.GetNumberOfDigitsPosNum(54611));
            Assert.AreEqual(1, DigitCounter.GetNumberOfDigitsPosNum(1));
            Assert.AreEqual(8, DigitCounter.GetNumberOfDigitsPosNum(56145641));

        }
    }
}
