using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StringCalculatorKata.BLL;

namespace StringCalculatorKata.Tests
{
    [TestFixture]
    class CalculatorTests
    {
        [Test]
        public void EmptyStringReturnsZero()
        {
            Calculator calc = new Calculator();
            int result = calc.Add("");

            Assert.AreEqual(0, result);
        }

        [Test]
        public void SingleNumberReturnsSum()
        {
            Calculator calc = new Calculator();
            int result = calc.Add("3");

            Assert.AreEqual(3, result);
        }

        [TestCase("2,3", 5)]
        [TestCase("2,3,3", 8)]
        public void TwoNumbersReturnsSum(string input, int expectedResult)
        {
            //Arrange
            Calculator calc = new Calculator();

            //Act
            int result = calc.Add(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void NewLinesBetweenNums()
        {
            Calculator calc = new Calculator();
            int result = calc.Add("1\n2,3");
            Assert.AreEqual(6, result);
        }
    }
}
