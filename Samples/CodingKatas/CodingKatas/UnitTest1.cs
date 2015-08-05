using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataChallenges;

namespace CodingKatas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FilterString()
        {
            Assert.AreEqual(123, Katas.FilterString("123"));
            Assert.AreEqual(123, Katas.FilterString("a1b2c3"));
            Assert.AreEqual(123, Katas.FilterString("aa1bb2cc3dd"));
        }

        [TestMethod]
        public void Factorial()
        {

            Assert.AreEqual(120, Katas.Factorial(5));
            Assert.AreEqual(1, Katas.Factorial(0));
            Assert.AreEqual(1, Katas.Factorial(1));
            Assert.AreEqual(2, Katas.Factorial(2));
            Assert.AreEqual(6, Katas.Factorial(3));


        }

        [TestMethod]
        public void Swap()
        {
            Assert.AreEqual("cODEwARS", Katas.Swap("CodeWars"));
        }

        [TestMethod]
        public void OddLadder()
        {
            Assert.AreEqual("1\n333\n55555\n7777777\n999999999", Katas.OddLadder(9));
            Assert.AreEqual("1\n333", Katas.OddLadder(4));
        }


    }
}
