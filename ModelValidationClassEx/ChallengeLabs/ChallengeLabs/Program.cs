using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeLabs.BLL;
namespace ChallengeLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("-- Reverse Text --");
            //string reverseInput = Lab.ReverseText();
            //Console.WriteLine(reverseInput); 

            //Console.WriteLine("-- Count Vowels --");
            //string countVowels = Lab.VowelCount();
            //Console.WriteLine(countVowels);

            //Console.WriteLine("-- Palindrome --");
            //string palindrome = Lab.Palindrome();
            //Console.WriteLine(palindrome);

            Console.WriteLine("-- Count Words --");
            string countWords = Lab.WordCounting();
            Console.WriteLine(countWords);

            //keep window open
            Console.ReadLine();
        }
    }
}
