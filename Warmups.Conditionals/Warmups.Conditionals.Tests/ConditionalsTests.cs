using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warmups.Conditionals.BLL;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Warmups.Conditionals.Tests
{
    [TestFixture]
    public class ConditionalsTests
    {
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(true, true, true)]
        public void AreWeInTroubleTest(bool aSmile, bool bSmile, bool expectedResult)
        {
            ConditionalWarmsups conditional1 = new ConditionalWarmsups();
            bool actualResult = conditional1.AreWeInTrouble(aSmile, bSmile);
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, true)]
        public void CanSleepInTest(bool isWeekday, bool isVacation, bool expectedResult)
        {
            ConditionalWarmsups condition2 = new ConditionalWarmsups();
            bool actualResult = condition2.CanSleepIn(isWeekday, isVacation);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, 2, 3)]
        [TestCase(2, 3, 5)]
        [TestCase(2, 2, 8)]
        public void SumDoubleTest(int a, int b, int expectedResult)
        {
            ConditionalWarmsups condition3 = new ConditionalWarmsups();
            int actualResult = condition3.SumDouble(a, b);
            Assert.AreEqual(expectedResult, actualResult);
            ;
        }

        [TestCase(23, 4)]
        [TestCase(10, 11)]
        [TestCase(21, 0)]
        public void Diff21Test(int n, int expectedResult)
        {
            ConditionalWarmsups condition4 = new ConditionalWarmsups();
            int actualResult = condition4.Diff21(n);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(true, 6, true)]
        [TestCase(true, 7, false)]
        [TestCase(false, 6, false)]
        public void ParrotTroubleTest(bool isTalking, int hour, bool expectedResult)
        {
            ConditionalWarmsups condition5 = new ConditionalWarmsups();
            bool actualResult = condition5.ParrotTrouble(isTalking, hour);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(9, 10, true)]
        [TestCase(9, 9, false)]
        [TestCase(1, 9, true)]
        public void Makes10Test(int a, int b, bool expectedResult)
        {
            ConditionalWarmsups condition6 = new ConditionalWarmsups();
            bool actualResult = condition6.Makes10(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(103, true)]
        [TestCase(90, true)]
        [TestCase(80, false)]
        public void NearHundredTest(int n, bool expectedResult)
        {
            ConditionalWarmsups condition6 = new ConditionalWarmsups();
            bool actualResult = condition6.NearHundred(n);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, -1, false, true)]
        [TestCase(-1, 1, false, true)]
        [TestCase(-4, -5, true, true)]
        public void PosNegTest(int a, int b, bool negative, bool expectedResult)
        {
            ConditionalWarmsups condition8 = new ConditionalWarmsups();
            bool actualResult = condition8.PosNeg(a, b, negative);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("candy", "not candy")]
        [TestCase("x", "not x")]
        [TestCase("not bad", "not bad")]
        public void NotStringTest(string s, string expectedResult)
        {
            ConditionalWarmsups condition9 = new ConditionalWarmsups();
            string actualResult = condition9.NotString(s);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("kitten", 1, "ktten")]
        [TestCase("kitten", 0, "itten")]
        [TestCase("kitten", 4, "kittn")]
        public void MissingCharTest(string str, int n, string expectedResult)
        {
            ConditionalWarmsups condition10 = new ConditionalWarmsups();
            string actualResult = condition10.MissingChar(str, n);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("code", "eodc")]
        [TestCase("a", "a")]
        [TestCase("ab", "ba")]
        public void FrontBackTest(string str, string expectedResult)
        {
            ConditionalWarmsups condition11 = new ConditionalWarmsups();
            string actualResult = condition11.FrontBack(str);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("Microsoft", "MicMicMic")]
        [TestCase("Chocolate", "ChoChoCho")]
        [TestCase("at", "atatat")]
        public void Front3Test(string str, string expectedResult)
        {
            ConditionalWarmsups condition12 = new ConditionalWarmsups();
            string actualResult = condition12.Front3(str);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("cat", "tcatt")]
        [TestCase("Hello", "oHelloo")]
        [TestCase("a", "aaa")]
        public void BackAroundTest(string str, string expectedResult)
        {
            ConditionalWarmsups condition13 = new ConditionalWarmsups();
            string actualResult = condition13.BackAround(str);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(3, true)]
        [TestCase(10, true)]
        [TestCase(8, false)]
        public void Multiple3or5Test(int number, bool expectedResult)
        {
            ConditionalWarmsups condition14 = new ConditionalWarmsups();
            bool actualResult = condition14.Multiple3or5(number);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase("hi there", true)]
        [TestCase("hi", true)]
        [TestCase("high up", false)]
        public void StartHiTest(string str, bool expectedResult)
        {
            ConditionalWarmsups condition15 = new ConditionalWarmsups();
            bool actualResult = condition15.StartHi(str);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(120, -1, true)]
        [TestCase(-1, 120, true)]
        [TestCase(2, 120, false)]
        public void IcyHotTest(int temp1, int temp2, bool expectedResult)
        {
            ConditionalWarmsups condition16 = new ConditionalWarmsups();
            bool actualResult = condition16.IcyHot(temp1, temp2);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(12, 99, true)]
        [TestCase(21, 12, true)]
        [TestCase(8, 99, false)]
        public void Between10and20Test(int a, int b, bool expectedResult)
        {
            ConditionalWarmsups condition17 = new ConditionalWarmsups();
            bool actualResult = condition17.Between10and20(a, b);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(13, 20, 10, true)]
        [TestCase(20, 19, 10, true)]
        [TestCase(20, 10, 12, false)]
        public void HasTeenTest(int a, int b, int c, bool expectedResult)
        {
            ConditionalWarmsups condition18 = new ConditionalWarmsups();
            bool actualResult = condition18.HasTeen(a, b, c);
            Assert.AreEqual(expectedResult,actualResult);
        }


        [TestCase(13, 99, true)]
        [TestCase(21, 19, true)]
        [TestCase(13, 13, false)]
        public void SoAloneTest(int a, int b, bool expectedResult)
        {
            ConditionalWarmsups condition19 = new ConditionalWarmsups();
            bool actualResult = condition19.SoAlone(a, b);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase("adelbc", "abc")]
        [TestCase("adelHello", "aHello")]
        [TestCase("adedbc", "adedbc")]
        public void RemoveDelTest(string str, string expectedResult)
        {
            ConditionalWarmsups condition20 = new ConditionalWarmsups();
            string actualResult = condition20.RemoveDel(str);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase("mix snacks", true)]
        [TestCase("pix snacks", true)]
        [TestCase("piz snacks", false)]
        public void IxStartTest(string str, bool expectedResult)
        {
            ConditionalWarmsups condition21 = new ConditionalWarmsups();
            bool actualResult = condition21.IxStart(str);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase("ozymandias", "oz")]
        [TestCase("bzoo", "z")]
        [TestCase("oxx", "o")]
        public void StartOzTest(string str, string expectedResult)
        {
            ConditionalWarmsups condition22 = new ConditionalWarmsups();
            string actualResult = condition22.StartOz(str);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(1, 2, 3, 3)]
        [TestCase(1, 3, 2, 3)]
        [TestCase(3, 2, 1, 3)]
        public void MaxTest(int a, int b, int c, int expectedResult)
        {
            ConditionalWarmsups condition23 = new ConditionalWarmsups();
            int actualResult = condition23.Max(a, b, c);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(8, 13, 8)]
        [TestCase(13, 8, 8)]
        [TestCase(13, 7,0)]
        public void CloserTest(int a, int b, int expectedResult)
        {
            ConditionalWarmsups condition24 = new ConditionalWarmsups();
            int actualResult = condition24.Closer(a, b);
            Assert.AreEqual(expectedResult,actualResult);

        }

        [TestCase("Hello", true)]
        [TestCase("Heelle", true)]
        [TestCase("Heelele", false)]
        public void GotETest(string str, bool expectedResult)
        {
            ConditionalWarmsups condition25 = new ConditionalWarmsups();
            bool actualResult = condition25.GotE(str);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase("Hello", "HeLLO")]
        [TestCase("hi there", "hi thERE")]
        [TestCase("hi", "HI")]
        public void EndUpTest(string str, string expectedResult)
        {
            ConditionalWarmsups condition26 = new ConditionalWarmsups();
            string actualResult = condition26.EndUp(str);
            Assert.AreEqual(expectedResult,actualResult);
        }


        [TestCase("Miracle", 2, "Mrce")]
        [TestCase("abcdefg", 2, "aceg")]
        [TestCase("abcdefg", 3, "adg")]
        public void EveryNthTest(string str, int n, string expectedResult)
        {
            ConditionalWarmsups condition27 = new ConditionalWarmsups();
            string actualResult = condition27.EveryNth(str, n);
            Assert.AreEqual(expectedResult,actualResult);
        }


    }
}
