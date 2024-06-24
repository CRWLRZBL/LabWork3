using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LabWorkFunctions.Tests
{
    [TestClass()]
    public class FunctionsTests
    {
        [TestMethod()]
        [DataTestMethod()]
        [DataRow(0, 1)]
        [DataRow(1, 1)]
        [DataRow(5, 120)]
        public void FactorialTest_CorrectValues(int n, int expected)
        {
            Assert.AreEqual(expected, Functions.GetFactorial(n));
        }

        [TestMethod()]
        public void FactorialTest_IncorrectValues(int n, int expected)
        {
            Assert.AreEqual(0, Functions.GetFactorial(-1));
        }

        [TestMethod()]
        [DataTestMethod()]
        [DataRow(1.5, 2, 2.25)]
        [DataRow(2, -4, 0.063)]
        public void PowerTest_PositivePower(double x, int n, double expected)
        {
            Assert.AreEqual(expected, Functions.GetPower(x, n), 0.001);
        }

        [TestMethod()]
        [DataTestMethod()]
        public void PowerTest_NegativePower(double x, int n, double expected)
        {
            Assert.AreEqual(expected, Functions.GetPower(x, n), 0.001);
        }
    }
}