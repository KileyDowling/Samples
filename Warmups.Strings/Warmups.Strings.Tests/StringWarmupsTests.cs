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

    }

}
