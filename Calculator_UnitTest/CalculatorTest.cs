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

        [Test]
        public void Clear_CallMethod_ExpectZero()
        {
            //Arrange
            uut.Add(10);

            //Act
            uut.Clear();

            //Assert

            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [TestCase(2.2, 2.3, 4.5)]
        [TestCase(5.7, 9.1, 14.8)]
        [TestCase(3.1, 4.9, 8)]
        [TestCase(106.9, 365.5, 472.4)]
        [TestCase(0, 0, 0)]
        public void Add_AddAAndB_ExpectResult(double a, double b, double expectedResult)
        {
            //Act
            double result = uut.Add(a, b);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual(result, expectedResult);
                Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.00001));
            });
        }

        [TestCase(2.3, 12.3)]
        [TestCase(9.1, 19.1)]
        [TestCase(4.9, 14.9)]
        [TestCase(365.5, 375.5)]
        [TestCase(0, 10)]
        public void Add_AddAdded_ExpectResult(double added, double expectedResult)
        {
            //Arrange 
            uut.Add(5, 5);

            //Act
            double result = uut.Add(added);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual(result, expectedResult);
                Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.00001));
            });

        }

        [TestCase(2.2, 2.3, -0.1)]
        [TestCase(9.1, 5.7, 3.4)]
        [TestCase(3.1, 4.9, -1.8)]
        [TestCase(106.9, 365.5, -258.6)]
        [TestCase(0, 0, 0)]
        public void Substract_AddAAndB_ExpectResult(double a, double b, double expectedResult)
        {
            //Act
            double result = uut.Subtract(a, b);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo(expectedResult).Within(0.1));
                Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.1));
            });

        }

        [TestCase(0, 10)]
        [TestCase(10, 0)]
        [TestCase(1.9, 8.1)]
        [TestCase(123.3, -113.3)]
        public void Substract_AddAToAccumulator_ExpectResult(double a, double expectedResult)
        {
            //Arrange
            uut.Add(10);

            //Act
            double result = uut.Subtract(a);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo(expectedResult).Within(0.01));
                Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
            });
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
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo(expectedResult).Within(0.00001));
                Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.00001));
            });
        }


        [TestCase(0, 0)]
        [TestCase(10, 100)]
        [TestCase(1.9, 19)]
        [TestCase(123.39, 1233.9)]
        public void Multiply_ATimesAccumulator_ExpectResult(double a, double expectedResult)
        {
            //Arrange
            uut.Add(10);

            //Act
            double result = uut.Multiply(a);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo(expectedResult).Within(0.001));
                Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.001));
            });
        }

        [TestCase(0,1 )]
        [TestCase(1,10 )]
        [TestCase(3,1000 )]
        [TestCase(4,10000)]
        public void Power_Add_ExpectResult(double a, double expectedResult)
        {
            //Arrange
            uut.Add(10);
            
            //Act
            double result = uut.Power(a);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo(expectedResult).Within(0.001));
                Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.001));
            });
        }

        [TestCase(2.2, 2.3, 6.131)]
        [TestCase(5.7, 9.1, 7558945.022)]
        [TestCase(3.1, 4.9, 255.666)]
        [TestCase(7.5, 0, 1)]
        public void Power_AddxAndexp_ExpectResult(double a, double exp, double expectedResult)
        {
            //Act
            double result = uut.Power(a, exp);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo(expectedResult).Within(0.001));
                Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.001));
            });
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

        [TestCase(1)]
        [TestCase(10)]
        [TestCase(0.9)]
        [TestCase(0)]
        [TestCase(137.57)]
        public void Divide_DevideVariableByzero_ThrowsException(double variable)
        {
            //Arrange
            uut.Add(10);

            //Act and Assert
            Assert.Multiple(() =>
           {
               Assert.Catch<DivideByZeroException>(() => uut.Divide(variable, 0));
               Assert.That(uut.Accumulator, Is.EqualTo(0));
           });

        }

        [TestCase(10, 1, 10)]
        [TestCase(10, 10, 1)]
        [TestCase(0, 7, 0)]
        [TestCase(7.5, 2, 3.75)]
        public void Divide_DivideYbyX_expectZ(double a, double b, double expectedResult)
        {
            //Arrange
            uut.Add(a);

            //Act
            double result = uut.Divide(b);


            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo(expectedResult).Within(0.00001));
                Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.00001));
            });


        }

        [TestCase(1)]
        [TestCase(10)]
        [TestCase(0.9)]
        [TestCase(0)]
        [TestCase(137.57)]
        public void Divide_DevideAccumulatorByzero_ThrowsException(double variable)
        {
            //Arrange
            uut.Add(variable);

            //Act & Assert
            Assert.Multiple(() =>
            {
                Assert.Catch<DivideByZeroException>(() => uut.Divide(0));
                Assert.That(uut.Accumulator, Is.EqualTo(0));
            });
        }


        [TestCase(2.2, 2.3, 6.131)]
        [TestCase(5.7, 9.1, 7558945.022)]
        [TestCase(3.1, 4.9, 255.666)]
        [TestCase(7.5, 0, 1)]
        public void Power_AddAccumulator_And_PowerByExp_ExpectResult(double Accumulator, double exp, double expectedResult)
        {

            //Arrange
            uut.Add(Accumulator);

            //Act
            double result = uut.Power(uut.Accumulator, exp);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo(expectedResult).Within(0.001));
                Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.001));
            });
        }




    }
}