using Microsoft.VisualStudio.TestTools.UnitTesting;
using p25_euler;

namespace p25_euler_tests
{
    [TestClass]
    public class TestFibonacci
    {
        Fibonacci fibonacci = new Fibonacci();

        [TestMethod]
        public void TestFibonacciCalculationFirst12()
        {
            Assert.AreEqual(2, fibonacci.GetNextFibonacci());
            Assert.AreEqual(3, fibonacci.Index);

            Assert.AreEqual(3, fibonacci.GetNextFibonacci());
            Assert.AreEqual(4, fibonacci.Index);

            Assert.AreEqual(5, fibonacci.GetNextFibonacci());
            Assert.AreEqual(5, fibonacci.Index);

            Assert.AreEqual(8, fibonacci.GetNextFibonacci());
            Assert.AreEqual(6, fibonacci.Index);

            Assert.AreEqual(13, fibonacci.GetNextFibonacci());
            Assert.AreEqual(7, fibonacci.Index);

            Assert.AreEqual(21, fibonacci.GetNextFibonacci());
            Assert.AreEqual(8, fibonacci.Index);

            Assert.AreEqual(34, fibonacci.GetNextFibonacci());
            Assert.AreEqual(9, fibonacci.Index);

            Assert.AreEqual(55, fibonacci.GetNextFibonacci());
            Assert.AreEqual(10, fibonacci.Index);

            Assert.AreEqual(89, fibonacci.GetNextFibonacci());
            Assert.AreEqual(11, fibonacci.Index);

            Assert.AreEqual(144, fibonacci.GetNextFibonacci());
            Assert.AreEqual(12, fibonacci.Index);

        }
    }
}
