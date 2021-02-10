using System;
using NUnit.Framework;
using HandTestingCalculator;
using NuGet.Frameworks;

namespace Calculator_UnitTest
{
    public class CalculatorTest
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            //Arrange
            uut = new Calculator();
        }

        [TestCase(2.2, 2.3,4.5)]
        [TestCase(5.7, 9.1, 14.8)]
        [TestCase(3.1, 4.9, 8)]
        [TestCase(106.9, 365.5, 472.4)]
        [TestCase(0, 0, 0)]
        public void Add_AddAAndB_ExpectResult(double a, double b, double expectedResult)
        {
            //Act
            double result = uut.Add(a, b);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestCase(2.2, 2.3, -0.1)]
        [TestCase(9.1, 5.7,  3.4)]
        [TestCase(3.1, 4.9, -1.8)]
        [TestCase(106.9, 365.5, -258.6)]
        [TestCase(0, 0, 0)]
        public void Substract_AddAAndB_ExpectResult(double a, double b, double expectedResult)
        {
            //Act
            double result = uut.Substract(a, b);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult).Within(0.001));
        }

        [TestCase(2.2, 2.3, 5.06)]
        [TestCase(5.7, 9.1, 51.87)]
        [TestCase(3.1, 4.9, 15.19)]
        [TestCase(106.9, 365.5, 39071.95)]
        [TestCase(0, 0, 0)]
        public void Multiply_AddAAndB_ExpectResult(double a, double b, double expectedResult)
        {
            //Act
            double result = uut.Multiply(a, b);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult).Within(0.001));
        }

        [TestCase(2.2, 2.3, 6.131)]
        [TestCase(5.7, 9.1, 7558945.022)]
        [TestCase(3.1, 4.9, 255.666)]
        public void Power_AddxAndexp_ExpectResult(double x, double exp, double expectedResult)
        {
            //Act
            double result = uut.Power(x,exp);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult).Within(0.001));
        }

        [TestCase(2.2, 2.3, 0.96)]
        [TestCase(5.7, 9.1, 0.63)]
        [TestCase(3.1, 4.9, 0.63)]
        [TestCase(106.9, 365.5, 0.29)]
        public void Divide_AddDevidendAndDevisor_ExpectResult(double devidend, double devisor, double expectedResult)
        {
            //Act
            double result = uut.Divide(devidend, devisor);
            

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult).Within(0.01));
        }

       
    }
}