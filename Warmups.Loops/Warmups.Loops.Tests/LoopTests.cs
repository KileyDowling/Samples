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
        [TestCase("Ab", 3, "AbAbAb")] 
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

        [TestCase("hixxhi", 1)]
        [TestCase("xaxxaxaxx", 1)]
        [TestCase("axxxaaxx", 2)]
        public void CountLast2Test(string str, int expectedResult)
        {
            LoopWarmups loop7 = new LoopWarmups();
            int actualResult = loop7.CountLast2(str);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(new int[] { 1, 2, 9 }, 1)]
        [TestCase(new int[] { 1, 9, 9 }, 2)]
        [TestCase(new int[] { 1, 9, 9, 3, 9 }, 3)]
        public void Count9Test(int[] numbers, int expectedResult)
        {
            LoopWarmups loop8 = new LoopWarmups();
            int actualResult = loop8.Count9(numbers);
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestCase(new int[] { 1, 2, 9, 3, 4 }, true)]
        [TestCase(new int[] { 1, 2, 3, 4, 9 }, false)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, false)]
        [TestCase(new int[] { 1, 2, 9 }, true)]
        public void ArrayFront9(int[] numbers, bool expectedResult)
        {
            LoopWarmups loop9 = new LoopWarmups();
            bool actualResult = loop9.ArrayFront9(numbers);
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestCase(new int[] { 1, 1, 2, 3, 1 }, true)]
        [TestCase(new int[] { 1, 1, 2, 4, 1 }, false)]
        [TestCase(new int[] { 1, 1, 2, 1, 2, 3 }, true)]
        public void Array123(int[] numbers, bool expectedResult)
        {
            LoopWarmups loop10 = new LoopWarmups();
            bool actualResult = loop10.Array123(numbers);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase("xxcaazz", "xxbaaz", 3)]
        [TestCase("abc", "abc", 2)]
        [TestCase("abc", "axc",0)]
        public void SubStringMatchTest(string a, string b, int expectedResult)
        {
            LoopWarmups loop11 = new LoopWarmups();
            int actualResult = loop11.SubStringMatch(a, b);
            Assert.AreEqual(expectedResult,actualResult);
            
        }

        [TestCase("xxHxix", "xHix")]
        [TestCase("abxxxcd", "abcd")]
        [TestCase("xabxxxcdx","xabcdx")]
        public void StringXTest(string str, string expectedResult)
        {
            LoopWarmups loop12 = new LoopWarmups();
            string actualResult = loop12.StringX(str);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase("kitten", "kien")]
        [TestCase("Chocolate", "Chole")]
        [TestCase("CodingHorror", "Congrr")]
        public void AltPairs(string str, string expectedResult)
        {
            LoopWarmups loop13 = new LoopWarmups();
            string actualResult = loop13.AltPairs(str);
            Assert.AreEqual(expectedResult,actualResult);
        }

       [TestCase("yakpak", "pak")]
        [TestCase("pakyak", "pak")]
        [TestCase("yak123ya", "123ya")]
        public void DoNotYakeTest(string str, string expectedResult)
        {
            LoopWarmups loop14 = new LoopWarmups();
            string actualResult = loop14.DoNotYak(str);
            Assert.AreEqual(expectedResult,actualResult);
        } 

        [TestCase(new int[] { 6, 6, 2 }, 1)]
        [TestCase(new int[] { 6, 6, 2,6 }, 1)]
        [TestCase(new int[] { 6, 7, 2, 6 }, 1)]
        public void Array667Test(int[] numbers, int expectedResult)
        {
            LoopWarmups loop15 = new LoopWarmups();
            int actualResult = loop15.Array667(numbers);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] { 1, 1, 2, 2, 1 }, true)]
        [TestCase(new int[] { 1, 1, 2, 2, 2, 1 }, false)]
        [TestCase(new int[] { 1, 1, 1, 2, 2, 2, 1 }, false)]
        public void NoTriplesTest(int[] numbers, bool expectedResult)
        {
            LoopWarmups loop16 = new LoopWarmups();
            bool actualResult = loop16.NoTriples(numbers);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(new int[] { 1, 2, 7, 1 }, true)]
        [TestCase(new int[] { 1, 2, 8, 1 }, false)]
        [TestCase(new int[] { 2, 7, 1 }, true)]
        public void Pattern51Test(int[] numbers, bool expectedResult)
        {
            LoopWarmups loop17 = new LoopWarmups();
            bool actualResult = loop17.Pattern51(numbers);
            Assert.AreEqual(expectedResult,actualResult);

        }
    }

}
