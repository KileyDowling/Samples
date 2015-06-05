using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Warmups.Arrays.BLL;
namespace Warmups.Arrays.Tests
{
    [TestFixture]
    public class ArrayTests
    {
        [TestCase(new int[] {1, 2, 6}, true)]
        [TestCase(new int[] {6, 1, 2, 3}, true)]
        [TestCase(new int[] {13, 6, 1, 2, 3}, false)]
        public void FirstLast6Test(int[] numbers, bool expectedResult)
        {
            ArrayWarmups array1 = new ArrayWarmups();
            bool actualResult = array1.FirstLast6(numbers);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] {1, 2, 3}, false)]
        [TestCase(new int[] {1, 2, 3, 1}, true)]
        [TestCase(new int[] {1, 2, 1}, true)]
        public void SameFirstLastTest(int[] numbers, bool expectedResult)
        {
            ArrayWarmups array2 = new ArrayWarmups();
            bool actualResult = array2.SameFirstLast(numbers);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase((3), new int[] {3, 1, 4})]
        [TestCase((1), new int[] {3})]
        public void MakePiTest(int n, int[] expectedResult)
        {
            ArrayWarmups array3 = new ArrayWarmups();
            int[] actualResult = array3.MakePi(n);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] {1, 2, 3}, new int[] {7, 3}, true)]
        [TestCase(new int[] {1, 2, 3}, new int[] {7, 3, 2}, false)]
        [TestCase(new int[] {1, 2, 3}, new int[] {1, 3}, true)]
        public void CommonEndTest(int[] a, int[] b, bool expectedResult)
        {
            ArrayWarmups array4 = new ArrayWarmups();
            bool actualResult = array4.CommonEnd(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] {1, 2, 3}, 6)]
        [TestCase(new int[] {5, 11, 2}, 18)]
        [TestCase(new int[] {7, 0, 0}, 7)]
        public void SumTest(int[] numbers, int expetedResult)
        {
            ArrayWarmups array5 = new ArrayWarmups();
            int actualResult = array5.Sum(numbers);
            Assert.AreEqual(expetedResult, actualResult);
        }

        [TestCase(new int[] {1, 2, 3}, new int[] {2, 3, 1})]
        [TestCase(new int[] {5, 11, 9}, new int[] {11, 9, 5})]
        [TestCase(new int[] {7, 0, 0}, new int[] {0, 0, 7})]
        public void RotateLeft(int[] numbers, int[] expectedResult)
        {
            ArrayWarmups array6 = new ArrayWarmups();
            int[] actualResult = array6.RotateLeft(numbers);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        public void ReverseTest(int[] numbers, int[] expectedResults)
        {
            ArrayWarmups array7 = new ArrayWarmups();
            int[] actualResult = array7.Reverse(numbers);
            Assert.AreEqual(expectedResults,actualResult);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 3, 3 })]
        [TestCase(new int[] { 11, 5, 9 }, new int[] { 11, 11, 11 })]
        [TestCase(new int[] { 2, 11, 3 }, new int[] { 3,3,3 })]
        public void HigherWinsTest(int[] numbers, int[] expectedResults)
        {
            ArrayWarmups array8 = new ArrayWarmups();
            int[] actualResult = array8.HigherWins(numbers);
            Assert.AreEqual(expectedResults,actualResult);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 2, 5 })]
        [TestCase(new int[] { 7, 7, 7 }, new int[] { 3,8,0 }, new int[] { 7,8 })]
        [TestCase(new int[] {5,2,9 }, new int[] {1, 4, 5 }, new int[] { 2, 4})]
        public void GetMiddleTest(int[] a, int[] b, int[] expectedResult)
        {
            ArrayWarmups array9 = new ArrayWarmups();
            int[] actualResult = array9.GetMiddle(a, b);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(new int[] { 2, 5 }, true)]
        [TestCase(new int[] { 4,3 }, true)]
        [TestCase(new int[] { 7, 5 }, false)]
        public void HasEvenTest(int[] numbers, bool expectedResult)
        {
            ArrayWarmups array10 = new ArrayWarmups();
            bool actualResult = array10.HasEven(numbers);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(new int[] { 4, 5, 6 }, new int[] { 0, 0, 0, 0, 0, 6 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 0, 0, 0, 2 })]
        [TestCase(new int[] { 3 }, new int[] { 0,3 })]
        public void KeepLastTest(int[] numbers, int[] expectedResult)
        {
            ArrayWarmups array11 = new ArrayWarmups();
            int[] actualResult = array11.KeepLast(numbers);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(new int[] { 2, 2, 3 }, true)]
        [TestCase(new int[] { 3, 4, 5, 3 }, true)]
        [TestCase(new int[] { 2, 3, 2, 2 }, false)]
        public void Double23Test(int[] numbers, bool expectedResult)
        {
            ArrayWarmups array12 = new ArrayWarmups();
            bool actualResult = array12.Double23(numbers);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 0 })]
        [TestCase(new int[] { 2, 3, 5 }, new int[] {2, 0, 5})]
        [TestCase(new int[] { 1, 2, 1}, new int[] { 1, 2, 1})]
        public void Fix23Test(int[] numbers, int[] expectedResult)
        {
            ArrayWarmups array13 = new ArrayWarmups();
            int[] actualResult = array13.Fix23(numbers);
            Assert.AreEqual(expectedResult,actualResult);
        }


        [TestCase(new int[] { 1, 3, 4, 5 }, true)]
        [TestCase(new int[] { 2, 1, 3, 4, 5 }, true)]
        [TestCase(new int[] { 1,1,1 }, false)]
        public void Unlucky1Test(int[] numbers, bool expectedResult)
        {
            ArrayWarmups array14 = new ArrayWarmups();
            bool actualResult = array14.Unlucky1(numbers);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(new int[] { 4, 5 }, new int[] { 1, 2, 3 }, new int[] { 4, 5 })]
        [TestCase(new int[] { 4}, new int[] { 1, 2, 3 }, new int[] { 4, 1 })]
        [TestCase(new int[] { }, new int[] { 1, 2}, new int[] { 1,2 })]
        public void make2Test(int[] a, int[] b, int[] expectedResult)
        {
            ArrayWarmups array15 = new ArrayWarmups();
            int[] actualResult = array15.make2(a, b);
            Assert.AreEqual(expectedResult,actualResult);
        }







}
}
