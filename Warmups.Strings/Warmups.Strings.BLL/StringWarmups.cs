using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.Strings.BLL
{
    public class StringWarmups
    {
        public string SayHi(string name)
        {
            string result = "Hi, " + name + "!";
            return result;
        }

        public string Abba(string a, string b)
        {
            string message = a + b + b + a;
            return message;
        }

        public string MakeTags(string tag, string content)
        {
            string result = "";
            string tagType = "<" + tag + ">";
            string closeTag = "</" + tag + ">";
            result = tagType + content + closeTag;
            return result;
        }

        public string insertTheWord(string container, string word)
        {
            string result = "";
            int length = container.Length;
            char[] array = container.ToCharArray();

            string container1 = array[0].ToString() + array[1].ToString();
            string container2 = array[2].ToString() + array[3].ToString();
            result = container1 + word + container2;

            return result;

        }

        public string MultEnd(string str)
        {
            string result = "";
            int length = str.Length;
            char[] stringToArray = new char[length];
            stringToArray = str.ToCharArray();
            char lastLetter;
            char secondToLast;

            lastLetter = stringToArray[length - 1];
            secondToLast = stringToArray[length - 2];
            string together = secondToLast.ToString() + lastLetter.ToString();
            result = together + together + together;
            return result;
        }

        public string FirstHalf(string str)
        {
            string result = "";
            int length = str.Length;
            int half = length / 2;
            for (int i = 0; i < half; i++)
            {
                result += str[i];
            }
            return result;
        }

        public string TrimOne(string str)
        {
            string result = "";
            int length = str.Length;
            for (int i = 0; i < (length - 2); i++)
            {
                result += str[i + 1];
            }
            return result;

        }

        public string LongInMid(string a, string b)
        {
            int lengthA = a.Length;
            int lengthB = b.Length;
            string result = "";

            if (lengthA > lengthB)
            {
                result = b + a + b;
                return result;
            }
            else
            {
                result = a + b + a;
                return result;
            }
        }

        public string Rotateleft2(string str)
        {
            string result = "";
            int length = str.Length;

            //assign strToArray to tempArray, starting with the 2nd place
            for (int i = 2; i < (length); i++)
            {
                result += str[i];
            }

            //then add the first two chars to the end
            for (int j = (length - 2); j < (length); j++)
            {
                result += str[j - length + 2];
            }


            return result;
        }


        public string RotateRight2(string str)
        {
            string result = "";
            int length = str.Length;

            for (int i = 0; i < 2; i++)
            {
                result += str[i + length - 2];
            }

            //then add the rest of the char up to the last two
            for (int j = 2; j < (length); j++)
            {
                result += str[j - 2];
            }


            return result;
        }

        public string TakeOne(string str, bool fromFront)
        {
            string result = "";
            int length = str.Length;

            if (fromFront)
            {
                char front = str[0];
                result = front.ToString();
                return result;
            }
            else
            {
                char front = str[length - 1];
                result = front.ToString();
                return result;
            }

        }


        public string MiddleTwo(string str)
        {
            string result = "";
            int length = str.Length;
            int half = length / 2;
            char[] strAsArray = new char[length];
            strAsArray = str.ToCharArray();
            char[] tempArray = new char[2];

            for (int i = (half - 1); i <= half; i++)
            {
                tempArray[i - half + 1] = strAsArray[i];
            }

            result = new string(tempArray);
            return result;

        }

        public bool EndsWithLy(string str)
        {
            bool result = false;
            int length = str.Length;
            string endsWith = "";

            if (length > 1)
            {
                for (int i = (length - 2); i < (length); i++)
                {
                    endsWith += str[i];
                }
            }
            if (endsWith == "ly")
                result = true;
            return result;

        }

        public string FrontAndBack(string str, int n)
        {
            string result = "";

            for (int i = 0; i < n; i++)
            {
                result += str[i];
            }

            for (int j = str.Length - n; j < str.Length; j++)
            {
                result += str[j];
            }

            return result;

        }

        public string TakeTwoFromPosition(string str, int n)
        {
            string result = "";
            int length = str.Length;
            char[] tempArray = new char[length];
            int num = 0;

            if (length > n + 1)
            {
                for (int i = n; i < n + 2; i++)
                {
                    result += str[i];
                }
            }
            else
            {
                for (int j = 0; j < 2; j++)
                {
                    result += str[j];
                }

            }
            return result;
        }

        public bool HasBad(string str)
        {
            int length = str.Length;
            char[] strToArray = new char[length];
            strToArray = str.ToCharArray();
            char[] tempArray = new char[3];
            string tempToFinal = "";
            bool result;

            //iterate through index 0-4 to check for "bad"
            for (int h = 0; h <= 2; h++)
            {
                tempArray[h] = strToArray[h];
            }

            tempToFinal = new string(tempArray);

            if (tempToFinal == "bad")
            {
                result = true;
            }

            else
            {
                for (int i = 0; i <= 2; i++)
                {
                    tempArray[i] = strToArray[i + 1];
                }
                tempToFinal = new string(tempArray);
                if (tempToFinal == "bad")
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }

        public string AtFirst(string str)
        {
            string result = "";
            int length = str.Length;

            if (length < 2)
            {
                result += str[0];
                result += '@';
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    result += str[i];
                }
            }

            return result;
        }

        public string LastChars(string str, string str2)
        {
            string result = "";
            int length = str.Length;
            int length2 = str2.Length;

            if (length >= 1 && length2 >= 1)
            {
                result += str[0];
                result += str2[length2 - 1];
            }


            else if (length == 0)
            {
                if (length2 >= 1)
                {
                    result += '@';
                    result += str[length2 - 1];
                }

                else
                {
                    result = "@@";
                }
            }

            else if (length2 == 0)
            {
                result += str[0];
                result += '@';
            }
            else
            {
                result = "@@";
            }

            return result;
        }

        public string ConCat(string a, string b)
        {
            string result = "";
            int length = a.Length;
            int length2 = b.Length;

            if (length > 0 && length2 > 0 && (a[a.Length - 1] == b[0]))
                {
                    for (int i = 0; i < (length); i++)
                    {
                        result += a[i];
                    }
                    for (int j = 0; j < (length2 - 1); j++)
                    {
                        result += b[j + 1];
                    }
                }
            
            else
                result = a + b;

            return result;
        }

        public string SwapLast(string str)
        {
            string result="";
            int length = str.Length;

            if (length > 2)
            {
                for (int i = 0; i < (length - 2); i++)
                {
                    result+= str[i];
                }
               result+= str[length - 1];
               result+= str[length - 2];
            }

            else
            {
                result += str[1];
                result+= str[0];
            }

            return result;
        }

        public bool FrontAgain(string str)
        {
            bool eInFirst;
            bool dInSecond;
            bool result=false;

            if ((str[0] == 'e' && (str[1] == 'd') && (str[str.Length - 2] == 'e' && (str[str.Length - 1] == 'd'))))
            {
                eInFirst = true;
                dInSecond = true;

                if (eInFirst == true && dInSecond == true)
                {
                    result = true;
                }
            }
            else
            {
                result = false;
            }
            return result;
        }

        public string MinCat(string a, string b)
        {
            string result ="";
            int length1 = a.Length;
            int length2 = b.Length;

            //string a is greater than string b, shorten string a
            if (length1 > length2)
            {
                for (int i = 0; i < length2; i++)
                {
                    result+= a[i + (length1 - length2)];
                }

                for (int j = 0; j < length2; j++)
                {
                    result+= b[j];
                }
            }
            else if (length2 > length1)
            {
                for (int i = 0; i < length1; i++)
                {
                    result+= a[i];
                }
                for (int j = 1; j <= length1; j++)
                {
                   result+= b[j];
                }
            }
            else
                result = a + b;

            return result;
        }

        public string TweakFront(string str)
        {
            string result="";
            int length = str.Length;

            if (str[0] != 'a')
            {
                if (str[1] != 'b')
                {
                    for (int a = 2; a < length; a++)
                    {
                        result+= str[a];
                    }
                }

                else
                {
                    for (int j = 1; j <= length - 2; j++)
                    {
                       result+= str[j];
                    }
                }
            }

            else if (str[0] == 'a' && str[1] == 'b')
            {
                result = str;
            }

            else if (str[0] == 'a')
            {
                result += str[0];
                for (int i = 2; i <= length - 1; i++)
                {
                    result+= str[i];
                }

            }

            else
            {
                for (int j = 0; j <= length - 2; j++)
                {
                     result+= str[j + 1];
                }
            }

            return result;

        }

        public string StripX(string str)
        {
            string result="";
            int length = str.Length;

            //if string starts and ends with x
            if (str[0] == 'x' && str[length - 1] == 'x')
            {
                for (int i = 0; i < length - 2; i++)
                {
                   result+= str[i + 1];
                }

            }
            //if string starts with x only
            else if (str[length - 1] == 'x')
            {
                for (int j = 0; j < length - 1; j++)
                {
                    result += str[j];
                }

            }

            //if string ends with x only
            else if (str[0] == 'x')
            {
                for (int k = 0; k < length - 1; k++)
                {
                    result+= str[k + 1];
                }
            }
            else
            {
                result = str;
            }
            return result;
        }
    }
}
