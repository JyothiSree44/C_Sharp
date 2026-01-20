using NUnit.Framework;
using CalculatorLibrary;
using System;

namespace CalculatorTests
{
    [TestFixture]
    public class UnitTest1
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Add_ValidNumbers_ReturnsCorrectResult()
        {
            Assert.That(calculator.Add(10, 5), Is.EqualTo(15));
        }

        [Test]
        public void Add_WithZero_ReturnsSameNumber()
        {
            Assert.That(calculator.Add(10, 0), Is.EqualTo(10));
        }

        [Test]
        public void Subtract_ValidNumbers_ReturnsCorrectResult()
        {
            Assert.That(calculator.Subtract(10, 5), Is.EqualTo(5));
        }

        [Test]
        public void Multiply_ValidNumbers_ReturnsCorrectResult()
        {
            Assert.That(calculator.Multiply(4, 5), Is.EqualTo(20));
        }

        [Test]
        public void Divide_ValidNumbers_ReturnsCorrectResult()
        {
            Assert.That(calculator.Divide(10, 2), Is.EqualTo(5));
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() =>
                calculator.Divide(10, 0));
        }
    }
}
