using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Warmups.Strings.BLL;

namespace Warmups.Strings.Tests
{
    [TestFixture]
    public class StringWarmupsTests
    {
        [TestCase("Bob", "Hi, Bob!")]
        [TestCase("Alice", "Hi, Alice!")]
        [TestCase("X", "Hi, X!")]
        public void SayHiTest(string name, string expectedResult)
        {
            StringWarmups string1 = new StringWarmups();
            string actualResult = string1.SayHi(name);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase("Hi", "Bye", "HiByeByeHi")]
        [TestCase("Yo", "Alice","YoAliceAliceYo")]
        [TestCase("What", "Up","WhatUpUpWhat")]
        public void AbbaTest(string a, string b, string expectedResult)
        {
            StringWarmups string2 = new StringWarmups();
            string actualResult = string2.Abba(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("i", "Yay", "<i>Yay</i>")]
        [TestCase("i", "Hello","<i>Hello</i>")]
        [TestCase("cite", "Yay", "<cite>Yay</cite>")]
        public void MakeTagsTest(string tag, string content, string expectedResult)
        {
            StringWarmups string3 = new StringWarmups();
            string actualResult = string3.MakeTags(tag,content);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("<<>>", "Yay", "<<Yay>>")]
        [TestCase("<<>>", "WooHoo", "<<WooHoo>>")]
        [TestCase("[[]]", "word","[[word]]")]
        public void insertTheWordTest(string container, string word, string expectedResult)
        {
            StringWarmups string4 = new StringWarmups();
            string actualResult = string4.insertTheWord(container, word);
            Assert.AreEqual(expectedResult, actualResult);
            
        }

        [TestCase("Hello", "lololo")]
        [TestCase("ab", "ababab")]
        [TestCase("Hi","HiHiHi")]
        public void MultEndTest(string str, string expectedResult)
        {
            StringWarmups string5 = new StringWarmups();
            string actualResult = string5.MultEnd(str);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("WooHoo", "Woo")]
        [TestCase("HelloThere", "Hello")]
        [TestCase("abcdef", "abc")]
        public void FirstHalfTest(string str, string expectedResult)
        {
            StringWarmups string6 = new StringWarmups();
            string actualResult = string6.FirstHalf(str);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("Hello", "ell")]
        [TestCase("java", "av")]
        [TestCase("coding", "odin")]
        public void TrimOneTest(string str, string expectedResult)
        {
            StringWarmups string7 = new StringWarmups();
            string actualResult = string7.TrimOne(str);
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestCase("Hello", "hi", "hiHellohi")]
        [TestCase("hi", "Hello", "hiHellohi")]
        [TestCase("aaa", "b", "baaab")]
        public void LongInMid(string a, string b, string expectedResult)
        {
            StringWarmups string8 = new StringWarmups();
            string actualResult = string8.LongInMid(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("Hello", "lloHe")]
        [TestCase("java","vaja")]
        [TestCase("Hi","Hi")]
        public void Rotateleft2Test(string str, string expectedResult)
        {
            StringWarmups string9 = new StringWarmups();
            string actualResult = string9.Rotateleft2(str);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("Hello", "loHel")]
        [TestCase("java", "vaja")]
        [TestCase("Hi", "Hi")]
        public void RotateRight2Test(string str, string expectedResult)
        {
            StringWarmups string10 = new StringWarmups();
            string actualResult = string10.RotateRight2(str);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase("Hello", true, "H")]
        [TestCase("Hello", false, "o")]
        [TestCase("oh", true, "o")]
        public void TakeOneTest(string str, bool fromFront, string expectedResult)
        {
            StringWarmups string11 = new StringWarmups();
            string actualResult = string11.TakeOne(str,fromFront);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("string", "ri")]
        [TestCase("code","od")]
        [TestCase("Practice", "ct")]
        public void MiddleTwoTest(string str, string expectedResult)
        {
            StringWarmups string12 = new StringWarmups();
            string actualResult = string12.MiddleTwo(str);
            Assert.AreEqual(expectedResult,actualResult);
        }


        [TestCase("oddly", true)]
        [TestCase("y", false)]
        [TestCase("oddy", false)]
        public void EndsWithLyTest(string str, bool expectedResult)
        {
            StringWarmups string13 = new StringWarmups();
            bool actualResult = string13.EndsWithLy(str);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase("Hello", 2, "Helo")]
        [TestCase("Chocolate", 3, "Choate")]
        [TestCase("Chocolate", 1, "Ce")]
        public void FrontAndBackTest(string str, int n, string expectedResult)
        {
            StringWarmups string14 = new StringWarmups();
            string actualResult = string14.FrontAndBack(str, n);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase("java", 0, "ja")]
        [TestCase("java", 2, "va")]
        [TestCase("java", 3, "ja")]
        public void TakeTwoFromPositionTest(string str, int n, string expectedResult)
        {
            StringWarmups string15 = new StringWarmups();
            string actualResult = string15.TakeTwoFromPosition(str, n);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase("badxx", true)]
        [TestCase("xbadxx", true)]
        [TestCase("xxbadxx", false)]
        public void HasBadTest(string str, bool expectedResult)
        {
            StringWarmups string16 = new StringWarmups();
            bool actualResult = string16.HasBad(str);
            Assert.AreEqual(expectedResult, actualResult);
            
        }

        [TestCase("hello", "he")]
        [TestCase("hi", "hi")]
        [TestCase("h", "h@")]
        public void AtFirstTest(string str, string expectedResult)
        {
            StringWarmups string17 = new StringWarmups();
            string actualResult = string17.AtFirst(str);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase("last", "chars", "ls")]
        [TestCase("yo", "mama", "ya")]
        [TestCase("hi", "", "h@")]
        public void LastCharsTest(string str, string str2, string expectedResult)
        {
            StringWarmups string18 = new StringWarmups();
            string actualResult = string18.LastChars(str,str2);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase("abc", "cat", "abcat")]
        [TestCase("dog", "cat", "dogcat")]
        [TestCase("abc", "", "abc")]
        public void ConCatTest(string a, string b, string expectedResult)
        {
            StringWarmups string19 = new StringWarmups();
            string actualResult = string19.ConCat(a, b);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase("coding", "codign")]
        [TestCase("cat", "cta")]
        [TestCase("ab","ba")]
        public void SwapLastTest(string str, string expectedResult)
        {
            StringWarmups string20 = new StringWarmups();
            string actualResult = string20.SwapLast(str);
            Assert.AreEqual(expectedResult,actualResult);
        }


        [TestCase("edited", true)]
        [TestCase("edit", false)]
        [TestCase("ed", true)]
        public void FrontAgainTest(string str, bool expectedResult)
        {
            StringWarmups string21 = new StringWarmups();
            bool actualResult = string21.FrontAgain(str);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase("Hello", "Hi", "loHi")]
        [TestCase("Hello", "java", "ellojava")]
        [TestCase("java", "Hello", "javaello")]
        public void MinCatTest(string a, string b, string expectedResult)
        {
            StringWarmups string22 = new StringWarmups();
            string actualResult = string22.MinCat(a, b);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase("Hello", "llo")]
        [TestCase("away", "aay")]
        [TestCase("abed", "abed")]
        public void TweakFrontTest(string str, string expectedResult)
        {
            StringWarmups string23 = new StringWarmups();
            string actualResult = string23.TweakFront(str);
            Assert.AreEqual(expectedResult,actualResult);
        }


        [TestCase("xHix", "Hi")]
        [TestCase("xHi", "Hi")]
        [TestCase("Hxix", "Hxi")]
        public void StripXTest(string str, string expectedResult)
        {
            StringWarmups string24 = new StringWarmups();
            string actualResult = string24.StripX(str);
            Assert.AreEqual(expectedResult,actualResult);
        }
    }


}
