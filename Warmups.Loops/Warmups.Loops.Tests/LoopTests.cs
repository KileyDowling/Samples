using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Warmups.Loops.BLL;

namespace Warmups.Loops.Tests
{
    [TestFixture]
    public class LoopTests
    {
        [TestCase("Hi", 2, "HiHi")]
        [TestCase("Hi", 3, "HiHiHi")]
        [TestCase("Hi", 1, "Hi")]
        [TestCase("Hi", 5, "HiHiHiHiHi")]
        public void StringTimesTest(string str, int n, string expectedResult)
        {
            //Arrange
            LoopWarmups loops = new LoopWarmups();
            //Act
            string actualResult = loops.StringTimes(str, n);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("Chocolate", 2, "ChoCho")]
        [TestCase("Chocolate", 3, "ChoChoCho")]
        [TestCase("Abc", 3, "AbcAbcAbc")]
//[TestCase("Ab", 3, "AbAbAb")] 
        public void FrontTimesTest(string str, int n, string expectedResult)
        {
            LoopWarmups loop2 = new LoopWarmups();
            string actualResult = loop2.FrontTimes(str, n);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase("abcxx", 1)]
        [TestCase("xxx", 2)]
        [TestCase("xxxx", 3)]
        public void CountXXTest(string str, int expectedResult)
        {
            LoopWarmups loop3 = new LoopWarmups();
            int actualResult = loop3.CountXX(str);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("axxbb", true)]
        [TestCase("axaxxax", false)]
        [TestCase("xxxxx", true)]
        public void DoubleXTest(string str, bool expectedResult)
        {
           LoopWarmups loop4 = new LoopWarmups();
            bool actualResult = loop4.DoubleX(str);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase("Hello", "Hlo")]
        [TestCase("Hi", "H")]
        [TestCase("Heeololeo", "Hello")]
        public void EveryOtherTest(string str, string expectedResult)
        {
            LoopWarmups loop5 = new LoopWarmups();
            string actualResult = loop5.EveryOther(str);
            Assert.AreEqual(expectedResult,actualResult);

        }

        [TestCase("Code", "CCoCodCode")]
        [TestCase("abc", "aababc")]
        [TestCase("ab", "aab")]
        public void StringSplosionTest(string str, string expectedResult)
        {
            LoopWarmups loop6 = new LoopWarmups();
            string actualResult = loop6.StringSplosion(str);
            Assert.AreEqual(expectedResult,actualResult);
      
        }
    }
}
