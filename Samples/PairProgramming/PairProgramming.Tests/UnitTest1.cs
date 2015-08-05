using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PairProgramming.BLL;

namespace PairProgramming.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldAddNumbersAndReturnSum()
        {
            Calculator target = new Calculator();
            int actual = target.Add("1,2");
            int expected = 3;
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void ShouldHandleN_NumbersAndReturnSum()
        {
            Calculator target = new Calculator();
            int actual = target.Add("1,2,3,4");
            int expected = 10;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ShouldHandleNewLinesAndCommas()
        {
            Calculator target = new Calculator();
            int actual = target.Add("1\n2,3");
            int expected = 6;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ShouldAllowUsertoChangeDefaultDelim()
        {
            Calculator target = new Calculator();
            int actual = target.Add("//;\n1;2");
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }
    }
}
