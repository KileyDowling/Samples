using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Warmups.Conditionals;

    
namespace Warmups.Conditionals.Tests
{
    [TestFixture]
    public class ConditionalTests
    {
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(true, true, true)]
        public void AreWeInTroubleTest(bool aSmile, bool bSmile, bool expectedResult)
        {
            ConditionalWarmsups conditional1 = new ConditionalWarmsups();
            bool actualResult = conditional1.AreWeInTrouble(aSmile, bSmile);
            Assert.AreEqual(expectedResult,actualResult);

        }

        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, true)]
        public void CanSleepInTest(bool isWeekday, bool isVacation, bool expectedResult)
        {
            ConditionalWarmsups condition2 = new ConditionalWarmsups();
            bool actualResult = condition2.CanSleepIn(isWeekday, isVacation);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(1, 2, 3)]
        [TestCase(2, 3, 5)]
        [TestCase(2, 2, 8)]
        public void SumDoubleTest(int a, int b, int expectedResult)
        {
           ConditionalWarmsups condition3 = new ConditionalWarmsups();
            int actualResult = condition3.SumDouble(a, b);
            Assert.AreEqual(expectedResult, actualResult);
;        }

        [TestCase(23, 4)]
        [TestCase(10, 11)]
        [TestCase(21, 0)]
        public void Diff21Test(int n, int expectedResult)
        {
            ConditionalWarmsups condition4 = new ConditionalWarmsups();
            int actualResult = condition4.Diff21(n);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(true, 6, true)]
        [TestCase(true, 7, false)]
        [TestCase(false, 6, false)]
        public void ParrotTroubleTest(bool isTalking, int hour, bool expectedResult)
        {
            ConditionalWarmsups condition5 = new ConditionalWarmsups();
            bool actualResult = condition5.ParrotTrouble(isTalking, hour);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(9, 10, true)]
        [TestCase(9, 9, false)]
        [TestCase(1, 9, true    )]
        public void Makes10Test(int a, int b, bool expectedResult)
        {
            ConditionalWarmsups condition6 = new ConditionalWarmsups();
            bool actualResult = condition6.Makes10(a, b);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(103, true)]
        [TestCase(90, true)]        
        [TestCase(80, false)]
        public void NearHundredTest(int n, bool expectedResult)
        {
            ConditionalWarmsups condition6 = new ConditionalWarmsups();
            bool actualResult = condition6.NearHundred(n);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(1, -1, false, true)]
        [TestCase(-1, 1, false, true)]
        [TestCase(-4, -5, true, true)]
        public void PosNegTest(int a, int b, bool negative, bool expectedResult)
        {
            ConditionalWarmsups condition8 = new ConditionalWarmsups();
            bool actualResult = condition8.PosNeg(a, b, negative);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase("candy", "not candy")]
        [TestCase("x", "not x")]
        [TestCase("not bad", "not bad")]
        public void NotStringTest(string s, string expectedResult)
        {
            ConditionalWarmsups condition9 = new ConditionalWarmsups();
            string actualResult = condition9.NotString(s);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase("kitten", 1, "ktten")]
        [TestCase("kitten", 0, "itten")]
        [TestCase("kitten", 4, "kittn")]
        public void MissingCharTest(string str, int n, string expectedResult)
        {
            ConditionalWarmsups condition10 = new ConditionalWarmsups();
            string actualResult = condition10.MissingChar(str, n);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase("code", "eodc")]
        [TestCase("a", "a")]
        [TestCase("ab", "ba")]
        public void FrontBackTest(string str, string expectedResult)
        {
            ConditionalWarmsups condition11 = new ConditionalWarmsups();
            string actualResult = condition11.FrontBack(str);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase("Microsoft", "MicMicMic")]
        public void Front3Test(string str, string expectedResult)
        {
            ConditionalWarmsups condition12 = new ConditionalWarmsups();
            string actualResult = condition12.
            Assert.AreEqual(expectedResult,actualResult);
        }



    }
}
