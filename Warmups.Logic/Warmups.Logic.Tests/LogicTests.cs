using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Warmups.Logic.BLL;


namespace Warmups.Logic.Tests
{
    [TestFixture]
    public class LogicTests
    {
        [TestCase(30, false, false)]
        [TestCase(50, false, true)]
        [TestCase(70, true, true)]
        public void GreatPartyTest(int cigars, bool isWeekend, bool expectedResult)
        {
            LogicWarmups logic1 = new LogicWarmups();
            bool actualAnswer = logic1.GreatParty(cigars, isWeekend);
            Assert.AreEqual(expectedResult,actualAnswer);
        }

        [TestCase(5, 10, 2)]
        [TestCase(5, 2,0)]
        [TestCase(5, 5,1)]
        public void CanHazTableTest(int yourStyle, int dateStyle, int expectedResult)
        {
            LogicWarmups logic2 = new LogicWarmups();
            int actualResult = logic2.CanHazTable(yourStyle, dateStyle);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(70, false, true)]
        [TestCase(95, false, false)]
        [TestCase(95, true,true )]
        public void PlayOutsideTest(int temp, bool isSummer, bool expectedResult)
        {
            LogicWarmups logic3 = new LogicWarmups();
            bool actualResult = logic3.PlayOutside(temp, isSummer);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(60, false, 0)]
        [TestCase(65, false, 1)]
        [TestCase(65, true, 0)]
        public void CaughtSpeedingTest(int speed, bool isBirthday, int expectedResult)
        {
            LogicWarmups logic4 = new LogicWarmups();
            int actualResult = logic4.CaughtSpeeding(speed, isBirthday);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(3, 4, 7)]
        [TestCase(9, 4, 20)]
        [TestCase(10, 11, 21)]
        public void SkipSumTest(int a, int b, int expectedResult)
        {
            LogicWarmups logic5 = new LogicWarmups();
            int actualResult = logic5.SkipSum(a, b);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(1, false, "7:00")]
        [TestCase(5, false, "7:00")]
        [TestCase(0, false, "10:00")]
        public void AlarmClockTest(int day, bool vacation, string expectedResult)
        {
            LogicWarmups logic6 = new LogicWarmups();
            string actualResult = logic6.AlarmClock(day, vacation);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(6, 4, true)]
        [TestCase(4, 5, false)]
        [TestCase(1, 5, true)]
        public void LoveSixTest(int a, int b, bool expectedResult)
        {
            LogicWarmups logic7 = new LogicWarmups();
            bool actualResult = logic7.LoveSix(a, b);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(5, false, true)]
        [TestCase(11, false,false)]
        [TestCase(11, true, true)]
        public void InRangeTest(int n, bool outsideMode, bool expectedResult)
        {
            LogicWarmups logic8 = new LogicWarmups();
            bool actualResult = logic8.InRange(n, outsideMode);
            Assert.AreEqual(expectedResult,actualResult);
        }


        [TestCase(22, true)]
        [TestCase(23, true)]
        [TestCase(24, false)]
        public void SpecialElevenTest(int n, bool expectedResult)
        {
           LogicWarmups logic9 = new LogicWarmups();
            bool actualResult = logic9.SpecialEleven(n);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(20, false)]
        [TestCase(21, true)]
        [TestCase(22, true)]
        public void Mod20Test(int n, bool expectedResult)
        {
            LogicWarmups logic10 = new LogicWarmups();
            bool actualResult = logic10.Mod20(n);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(3, true)]
        [TestCase(10, true)]
        [TestCase(15, false)]
        public void Mod35Test(int n, bool expectedResult)
        {
            LogicWarmups logic11 = new LogicWarmups();
            bool actualResult = logic11.Mod35(n);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(false, false, false, true)]
        [TestCase(false, false, true, false)]
        [TestCase(true, false, false,false )]
        public void AnswerCellTest(bool isMorning, bool isMom, bool isAsleep, bool expectedResult)
        {
            LogicWarmups logic12 = new LogicWarmups();
            bool actualResult = logic12.AnswerCell(isMorning, isMom, isAsleep);
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestCase(1, 2, 3, true)]
        [TestCase(3, 1, 2, true)]
        [TestCase(3, 2, 2,false)]
        public void TwoIsOneTest(int a, int b, int c, bool expectedResult)
        {
            LogicWarmups logic13 = new LogicWarmups();
            bool actualResult = logic13.TwoIsOne(a, b, c);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, 2, 4, false, true)]
        [TestCase(1, 2, 1, false, false)]
        [TestCase(1, 1, 2, true,true)]
        public void AreInOrderTest(int a, int b, int c, bool bOk, bool expectedResult)
        {
            LogicWarmups logic14= new LogicWarmups();
            bool actualResult = logic14.AreInOrder(a,b,c,bOk);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(2, 5, 11, false, true)]
        [TestCase(5, 7, 6, false, false)]
        [TestCase(5, 5, 7, true, true)]
        public void InOrderEqualTest(int a, int b, int c, bool equalOk, bool expectedResult)
        {
            LogicWarmups logic15= new LogicWarmups();
            bool actualResult = logic15.InOrderEqual(a,b,c,equalOk);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(23, 19, 13, true)]
        [TestCase(23, 19, 12,false)]
        [TestCase(23, 19, 3,true)]
        public void LastDigitTest(int a, int b, int c, bool expectedResult)
        {
            LogicWarmups logic16 = new LogicWarmups();
            bool actualResult = logic16.LastDigit(a,b,c);
            Assert.AreEqual(expectedResult, actualResult); 
        }

        [TestCase(2, 3, true, 5)]
        [TestCase(3, 3, true, 7)]
        [TestCase(3, 3, false, 6 )]
        public void RollDiceTest(int die1, int die2, bool noDoubles, int expectedResult)
        {
            LogicWarmups logic17 = new LogicWarmups();
            int actualResult = logic17.RollDice(die1,die2,noDoubles);
            Assert.AreEqual(expectedResult, actualResult); 
            
        }


    }
}
