using NUnit.Framework;
using CalculatorProject; 
using System;

namespace CalculatorTests
{
    public class Tests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void TestAddition()
        {
            double result = calculator.Calculate(5, 3, '+');
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void TestSubtraction()
        {
            double result = calculator.Calculate(10, 4, '-');
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void TestMultiplication()
        {
            double result = calculator.Calculate(6, 7, '*');
            Assert.That(result, Is.EqualTo(42));
        }

        [Test]
        public void TestDivision()
        {
            double result = calculator.Calculate(20, 5, '/');
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void TestDivisionByZero()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Calculate(10, 0, '/'));
        }

        [Test]
        public void TestInvalidOperation()
        {
            Assert.Throws<ArgumentException>(() => calculator.Calculate(5, 5, '%'));
        }
    }
}
