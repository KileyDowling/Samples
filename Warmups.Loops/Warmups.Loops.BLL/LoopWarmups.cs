using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.Loops.BLL
{
    public class LoopWarmups
    {
        public string StringTimes(string str, int n)
        {
            string result = "";

            for (int i = 0; i < n; i++)
            {
                result += str;
            }

            return result;
        }

        public string FrontTimes(string str, int n)
        {
            string result = "";

            if (str.Length > 2)
            {
                for (int i = 0; i < n; i++)
                {
                    result += str.Substring(0, 3);
                }
            }

            else
            {
                for (int i = 0; i < n; i++)
                {
                    result += str;

                }
            }

            return result;

        }

        public int CountXX(string str)
        {
            char[] tempArray = str.ToCharArray();
            int result = 0;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (tempArray[i] == 'x' && tempArray[i + 1] == 'x')
                {
                    result += 1;
                }
            }
            return result;
        }

        public bool DoubleX(string str)
        {
            bool result;
            int firstX = str.IndexOf('x');

            if (str[firstX + 1] == 'x')

                result = true;
            else
                result = false;
            return result;

        }

        public string EveryOther(string str)
        {
            string result = "";
            char[] strToArray = str.ToCharArray();
            int counter = 1;
            int x = 1;
            if (str.Length % 2 == 0)
                x = 0;
            char[] tempArray = new char[str.Length / 2 + x];

            tempArray[0] = strToArray[0];

            for (int i = 1; i < tempArray.Length; i++)
            {
                tempArray[i] = strToArray[i + counter];
                counter += 1;
            }

            result = new string(tempArray);
            return result;
        }

        public string StringSplosion(string str)
        {
            string result = "";
            int numTimes = 0;
            char[] strToArray = str.ToCharArray();


            while (numTimes < str.Length + 1)
            {
                for (int i = 0; i < numTimes; i++)
                {
                    result += strToArray[i];
                }
                numTimes += 1;
            }

            return result;
        }

        public int CountLast2(string str)
        {
            int result = 0;
            int numTimes = 0;
            char[] strToArray = str.ToCharArray();


            for (int i = 0; i < str.Length - 2; i++)
            {
                if (strToArray[i] == strToArray[str.Length - 2] && strToArray[i + 1] == strToArray[str.Length - 1])
                {
                    numTimes += 1;
                }
                result = numTimes;
            }

            return result;

        }

        public int Count9(int[] numbers)
        {
            int result = 0;
            int count9 = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 9)
                {
                    count9 += 1;
                }
                result = count9;

            }
            return result;

        }

        public bool ArrayFront9(int[] numbers)
        {
            bool result = false;
            bool found9 = false;
            int n;
            if (numbers.Length >= 4)
            {
                n = 4;
            }
            else
            {
                n = numbers.Length;
            }

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] == 9)
                {
                    found9 = true;
                }
            }
            result = found9;
            return result;

        }

        public bool Array123(int[] numbers)
        {
            bool result;
            int found123 = 0;

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i] == 1 && numbers[i + 1] == 2 && numbers[i + 2] == 3)
                {
                    found123 += 1;
                }
            }
            if (found123 > 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public int SubStringMatch(string a, string b)
        {
            int result = 0;
            int length;
            if (a.Length > b.Length || a.Length == b.Length)
                length = b.Length;
            else
            {
                length = a.Length;
            }
            for (int i = 0; i < length - 1; i++)
            {
                if (a[i] == b[i] && a[i + 1] == b[i + 1])
                {
                    result += 1;
                }
            }

            return result;

        }

        public string StringX(string str)
        {
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'x' && i == 0 || i == str.Length - 1)
                {
                    result += str[i];
                }
                else if (str[i] == 'x')
                {

                }
                else
                {
                    result += str[i];
                }
            }
            return result;
        }

        public string AltPairs(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0 || i == 1 || i == 4 || i == 5 || i == 8 || i == 9)
                    result += str[i];
            }

            return result;
        }

        public string DoNotYak(string str)
        {
            /*Suppose the string "yak" is unlucky. Given a string, return a version where all the "yak" are removed, 
             * but the "a" can be any char. The "yak" strings will not overlap. 
                DoNotYak("yakpak") -> "pak"
                DoNotYak("pakyak") -> "pak"
                DoNotYak("yak123ya") -> "123ya"  */

            string result = "";

            for (int i = 0; i < str.Length - 3; i++)
            {
                if (str.Contains("yak"))
                {
                    if (str[i] == 'y' && str[i + 1] == 'a' && str[i + 2] == 'k')
                    {
                        result = str.Remove(i, (i + 3));
                        break;
                    }
                    else
                    {
                        result += str[i];
                    }
                }
            }
            return result;

        }

        public int Array667(int[] numbers)
        {
            /*Given an array of ints, return the number of times that two 6's are next to each other in the array. 
                     * Also count instances where the second "6" is actually a 7. 
                   Array667({6, 6, 2}) -> 1
                   Array667({6, 6, 2, 6}) -> 1
                   Array667({6, 7, 2, 6}) -> 1 */

            int result = 0;
            int count6 = 0;
            int length = numbers.Length;

            //check if 6 is followed by a 6 or 7
            for (int i = 0; i < length - 1; i++)
            {
                if (numbers[i] == 6 && numbers[i + 1] == 6 || numbers[i] == 6 && numbers[i + 1] == 7)
                    count6 += 1;
            }
            result = count6;


            return result;
        }

        public bool NoTriples(int[] numbers)
        {
            bool result;
            int foundTrips = 0;
            int length = numbers.Length;

            for (int i = 0; i < length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1] && numbers[i + 1] == numbers[i + 2])
                {
                    foundTrips += 1;
                }
            }

            if (foundTrips > 0)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }

        public bool Pattern51(int[] numbers)
        {
            bool result;
            int length = numbers.Length;
            int two71Pat = 0;

            for (int i = 0; i < length - 1; i++)
            {
                if ((numbers[i + 1] == numbers[i] + 5) && (numbers[i + 2] == 1))
                {
                    two71Pat += 1;
                }
            }

            if (two71Pat > 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}