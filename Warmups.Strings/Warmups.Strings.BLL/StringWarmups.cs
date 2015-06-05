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
            string result="";
            string tagType = "<" + tag + ">";
            string closeTag = "</" + tag + ">";
            result = tagType + content + closeTag;
            return result;
        }

        public string insertTheWord(string container, string word)
        {
            string result="";
            int length = container.Length;
            char[] array = container.ToCharArray();

            string container1 = array[0].ToString() + array[1].ToString();
            string container2 = array[2].ToString() + array[3].ToString();
            result = container1 + word + container2;

            return result;

        }

        public string MultEnd(string str)
        {
            string result="";
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
            string result="";
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
            string result="";
            int length = str.Length;
            for (int i = 0; i < (length - 2); i++)
            {
                result+= str[i + 1];
            }
            return result;

        }

        public string LongInMid(string a, string b)
        {
            int lengthA = a.Length;
            int lengthB = b.Length;
            string result="";

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
            string result ="";
            int length = str.Length;

            //assign strToArray to tempArray, starting with the 2nd place
            for (int i = 2; i < (length); i++)
            {
                result+= str[i];
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
            string result="";
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
            string result="";
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

    }
}
