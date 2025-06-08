using Unit_Testing_Proj;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace NUnit_testing;

public class Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            int result = _calculator.Add(5, 3);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Add_OneNegative_OnePositive_ReturnsCorrectSum()
        {
            int result = _calculator.Add(-5, 3);
            Assert.AreEqual(-2, result);
        }

        [Test]
        public void Subtract_TwoPositiveNumbers_ReturnsCorrectDifference()
        {
            int result = _calculator.Subtract(10, 6);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Multiply_TwoPositiveNumbers_ReturnsCorrectProduct()
        {
            int result = _calculator.Multiply(4, 7);
            Assert.AreEqual(28, result);
        }

        [Test]
        public void Divide_ValidDivision_ReturnsQuotient()
        {
            int result = _calculator.Divide(20, 5);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Divide_DivideByZero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        }

        [TestCase(2, 3, 5)]
        [TestCase(-1, -2, -3)]
        [TestCase(-5, 5, 0)]
        public void Add_WithTestCases_ReturnsExpectedResult(int a, int b, int expected)
        {
            var result = _calculator.Add(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase(10, 4, 6)]
        [TestCase(-2, -2, 0)]
        public void Subtract_WithTestCases_ReturnsExpectedResult(int a, int b, int expected)
        {
            var result = _calculator.Subtract(a, b);
            Assert.AreEqual(expected, result);
        }
    }
}