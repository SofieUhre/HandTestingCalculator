using NUnit.Framework;
using HandTestingCalculator;

namespace Calculator_UnitTest
{
    public class CalculatorTest
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [TestCase(2.2, 2.3,4.5)]
        [TestCase(5.7, 9.1, 14.8)]
        [TestCase(3.1, 4.9, 8)]
        [TestCase(106.9, 365.5, 472.4)]
        [TestCase(0, 0, 0)]
        public void Add_AddAAndB_ExpectResult(double a, double b, double expectedResult)
        {
            double result = uut.Add(a, b);

            Assert.AreEqual(result, expectedResult);
        }

        [TestCase(2.2, 2.3, -0.1)]
        [TestCase(9.1, 5.7,  3.4)]
        [TestCase(3.1, 4.9, -1.8)]
        [TestCase(106.9, 365.5, -258.6)]
        [TestCase(0, 0, 0)]
        public void Substract_AddAAndB_ExpectResult(double a, double b, double expectedResult)
        {
            double result = uut.Substract(a, b);

            Assert.That(result, Is.EqualTo(expectedResult).Within(0.001));
        }

        [TestCase(2.2, 2.3, 5.06)]
        [TestCase(5.7, 9.1, 51.87)]
        [TestCase(3.1, 4.9, 15.19)]
        [TestCase(106.9, 365.5, 39071.95)]
        [TestCase(0, 0, 0)]
        public void Multiply_AddAAndB_ExpectResult(double a, double b, double expectedResult)
        {
            double result = uut.Multiply(a, b);

            Assert.That(result, Is.EqualTo(expectedResult).Within(0.001));
        }

        [TestCase(2.2, 2.3, 6.131)]
        [TestCase(5.7, 9.1, 7558945.022)]
        [TestCase(3.1, 4.9, 255.666)]
        public void power_AddxAndexp_ExpectResult(double x, double exp, double expectedResult)
        {
            double result = uut.Power(x,exp);

            Assert.That(result, Is.EqualTo(expectedResult).Within(0.001));
        }
    }
}