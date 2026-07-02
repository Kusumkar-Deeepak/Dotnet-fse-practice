using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Init()
        {
            calculator = new Calculator();
        }

        [TearDown]
        public void Cleanup()
        {
            calculator = null;
        }

        [Test]
        [TestCase(10, 20, 30)]
        [TestCase(5, 5, 10)]
        [TestCase(100, 200, 300)]
        [TestCase(-5, 5, 0)]
        public void Add_WhenCalled_ReturnsExpectedResult(
            int a, int b, int expected)
        {
            int actual = calculator.Add(a, b);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}