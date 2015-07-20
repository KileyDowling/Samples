using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLabs.BLL
{
    public class Lab
    {
        public static string ReverseText()
        {
            //Reverse a String
            //Difficulty: 1

            //Create a program that asks the user for a string of input and simply returns it in reverse order. 
            //For instance they enter “Hello” and it returns “olleH”.
            string userInput;
            string reverseInput = "";
            Console.WriteLine("Please enter a string");
            userInput = Console.ReadLine();
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                reverseInput += userInput[i];
            }
            return reverseInput;
        }

        public static string VowelCount()
        {
            //Make a program which asks the user to enter in a string
            //and then prints out how many vowels are in that string. 
            //For example, the user enters “hello world” and it returns “There are 3 vowels in ‘hello world’”.
            string userInput;
            int CharCount = 0;
            string vowels;
            Console.WriteLine("Please enter a string");
            userInput = Console.ReadLine();

            foreach (var item in userInput)
            {
                if (item == 'a' || item == 'e' || item == 'i' | item == 'o' | item == 'u')
                {
                    CharCount += 1;
                }
            }

            vowels = string.Format("There are {0} vowels in ‘{1}’", CharCount, userInput);
            return vowels;

        }

        public static string Palindrome()
        {
            //A palindrome is a string of characters when read from left to right 
            //and right to left is exactly the same (ignoring any spaces usually). 
            //One of the most well known palindromes is “race car”. 
            //No matter which direction you read it, it still reads “race car”. 
            //Create a program which checks if a string entered is a palindrome. If it is, 
            //print “The string ‘_____’ is a palindrome” where the blank is the string they entered.

            string userInput;
            string reverseInput = "";
            string result = "";
            Console.WriteLine("Please enter a string");
            userInput = Console.ReadLine();

            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                reverseInput += userInput[i];
            }

            if (reverseInput == userInput)
            {
                result = string.Format("The string ‘{0}’ IS a palindrome", userInput);
            }
            else
            {
                result = string.Format("The string ‘{0}’ IS NOT a palindrome", userInput);
            }
            return result;
        }

        public static string WordCounting()
        {
            //Write a program which asks the user for a string
            //and then counts how many words are in that string. 
            //For example if they write “This is my first program” the program would print out “There are 5 words”.

            string userInput;
            string result = "";
            int countWords = 0; 
            Console.WriteLine("Please enter a string");
            userInput = Console.ReadLine();

            string[] toArray = userInput.Split(' ');
            foreach (var item in toArray)
            {
                countWords += 1;
            }

            result = string.Format("There are {0} words in '{1}'",countWords, userInput);

            return result;
        }

        public static string PhoneLetter(string num)
        {
            //Given a digit string, return all possible letter combinations that the number could represent in a phone number.  On a typical phone:

            //2 - ABC
            //3 - DEF
            //4 - GHI
            //5 - JKL
            //6 - MNO
            //7 - PQRS
            //8 - TUV
            //9 - WXYZ

            //So given "23" you should output AD, AE, AF, BD, BE, BF, CD, CE, CF

            string result = "";
            int toNum = int.Parse(num);
            if (toNum > 1 && toNum < 10)
            {
                
            }
            else
            {
                result = "False, not a valid input";
            }
            return result;
        }
    }
}
