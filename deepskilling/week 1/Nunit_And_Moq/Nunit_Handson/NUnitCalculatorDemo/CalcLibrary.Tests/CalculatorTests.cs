using NUnit.Framework;
using NUnit.Framework.Legacy;
using CalcLibrary;
using System;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        // Parameterized Test - Subtraction

        [Test]
        [TestCase(10, 5, 5)]
        [TestCase(20, 10, 10)]
        [TestCase(15, 7, 8)]
        [TestCase(-5, -5, 0)]
        public void TestSubtract(int num1, int num2, int expected)
        {
            int actual = calculator.Subtract(num1, num2);

            ClassicAssert.AreEqual(expected, actual);
        }

        // Parameterized Test - Multiplication

        [Test]
        [TestCase(2, 3, 6)]
        [TestCase(5, 4, 20)]
        [TestCase(7, 0, 0)]
        [TestCase(-2, 5, -10)]
        public void TestMultiply(int num1, int num2, int expected)
        {
            int actual = calculator.Multiply(num1, num2);

            ClassicAssert.AreEqual(expected, actual);
        }

        // Parameterized Test - Division

        [Test]
        [TestCase(10, 2, 5)]
        [TestCase(20, 5, 4)]
        [TestCase(100, 10, 10)]
        public void TestDivide(int num1, int num2, int expected)
        {
            int actual = calculator.Divide(num1, num2);

            ClassicAssert.AreEqual(expected, actual);
        }

        // Exception Test

        [Test]
        public void TestDivideByZero()
        {
            try
            {
                calculator.Divide(10, 0);

                Assert.Fail("Division by zero");
            }
            catch (ArgumentException ex)
            {
                ClassicAssert.AreEqual(
                    "Division by zero",
                    ex.Message);

                ClassicAssert.AreEqual(
                    typeof(ArgumentException),
                    ex.GetType());
            }
        }

        // Testing Void Method

        [Test]
        public void TestAddAndClear()
        {
            int actual = calculator.Add(10, 20);

            ClassicAssert.AreEqual(30, actual);

            calculator.AllClear();

            ClassicAssert.AreEqual(
                0,
                calculator.GetResult);
        }

        // Demonstrating AssertionException

        [Test]
        public void TestAssertionException()
        {
            try
            {
                ClassicAssert.AreEqual(10, 20);
            }
            catch (AssertionException ex)
            {
                ClassicAssert.IsNotNull(ex);
            }
        }
    }
}