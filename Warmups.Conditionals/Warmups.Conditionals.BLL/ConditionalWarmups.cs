using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warmups.Conditionals.BLL;


namespace Warmups.Conditionals.BLL
{
    public class ConditionalWarmsups
    {
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            bool result;

            if (aSmile == bSmile)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            bool result;

            if (isWeekday == true && isVacation == false)
            {
                result = false;
            }
            else
            {
                result = true;
            }

            return result;

        }

        public int SumDouble(int a, int b)
        {
            int result;

            if (a == b)
            {
                result = (a + b)*2;
            }
            else
            {
                result = (a + b);
            }

            return result;

        }

        public int Diff21(int n)
        {
            int result;
            if (n < 21)
            {
                result = 21 - n;
            }
            else if (n > 21)
            {
                result = (n - 21)*2;
            }
            else
            {
                result = n - n;
            }


            return result;

        }

        public bool ParrotTrouble(bool isTalking, int hour)
        {
            bool result;
            if ((hour < 7 || hour > 20) && isTalking == true)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;


        }

        public bool NearHundred(int n)
        {
            bool near100Output;
            int abValue100 = Math.Abs(100 - n);
            int abValue200 = Math.Abs(200 - n);

            if (n < 100 && abValue100 > 10)
            {
                near100Output = false;
            }
            else if (n > 100 && abValue200 < 10)
            {
                near100Output = false;
            }
            else
            {
                near100Output = true;
            }
            return near100Output;

        }

        public bool PosNeg(int a, int b, bool negative)
        {
            bool result;
            if ((a < 0 || b < 0) && negative == false)
            {
                result = true;
            }
            else if ((a < 0 && b < 0) && negative == true)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        public string NotString(string s)
        {
            string result;

            if (s.Length > 3 && s.Substring(0, 3) == "not")
            {
                result = s;
            }
            else
            {
                result = "not " + s;
            }

            return result;
        }

        public bool Makes10(int a, int b)
        {
            bool result;

            if (a == 10 || b == 10)
            {
                result = true;
            }
            else if (a + b == 10)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        public string MissingChar(string str, int n)
        {
            string result = "";
            int length = str.Length;
            char[] strToArray = str.ToCharArray();
            char[] tempArray = new char[length - 1];

            for (int j = 0; j < length - 2; j++)
            {
                tempArray[j] = strToArray[j];
            }

            for (int i = n; i < (length - 1); i++)
            {
                tempArray[i] = strToArray[i + 1];
            }

            result = new string(tempArray);

            return result;
        }

        public string FrontBack(string str)
        {
            string result = "";
            int length = str.Length;
            char[] strToArray = str.ToCharArray();
            char[] tempArray = new char[length];

            for (int i = 0; i < length; i++)
            {
                tempArray[i] = strToArray[i];
            }
            tempArray[0] = strToArray[length - 1];
            tempArray[length - 1] = strToArray[0];

            result = new string(tempArray);

            return result;
        }

        public string Front3(string str)
        {
            string result;
            int length = str.Length;
            char[] strToArray = str.ToCharArray();
            char[] tempArray = new char[length];

            if (length < 3)
            {
                result = str + str + str;
            }
            else
            {
                int number = 0;
                int numberMax = 3;
                int repeatArray = 0;

                while (number < 9)
                {
                    for (int i = number; i < numberMax; i++)
                    {
                        tempArray[i] = strToArray[repeatArray + i];
                    }
                    number += 3;
                    numberMax += 3;
                    repeatArray -= 3;
                }
                result = new string(tempArray);
            }

            return result;
        }

        public string BackAround(string str)
        {
            string result="";
            int length = str.Length;
            char[] strToArray = str.ToCharArray();
            char[] tempArray = new char[length + 2];

            tempArray[0] = strToArray[length - 1];
            tempArray[length + 1] = strToArray[length - 1];

            for (int i = 1; i < (length + 1); i++)
            {
                tempArray[i] = strToArray[i - 1];
            }

            result = new string(tempArray);
            return result;
        } 
    
        public bool Multiple3or5(int number) 
        {
            bool result;

            if(number % 3 == 0 || number % 5 == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        public bool StartHi(string str)
        {
            bool result;
            int length = str.Length;
            char[] strToArray = str.ToCharArray();

            if (length < 3 && str == "hi")
            {
                result = true;
            }
            else if (strToArray[2] != ' ')
            {
                result = false;
            }
            else
            {
                result = true;
            }

            return result;
        }

        public bool IcyHot(int temp1, int temp2)
        {
            bool result;
            if ((temp1 < 0 && temp2 > 100) || (temp2 < 0 && temp1 > 100))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;

        }

        public bool Between10and20(int a, int b)
        {
            bool result;

            if ((a >= 10 && a <= 20) || (b >= 10 && b <= 20))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public bool HasTeen(int a, int b, int c)
        {
            bool result;

            if ((a >= 13 && a <= 19) || ((b >= 13) && (b <= 19)) || ((c >= 13) && (c <= 19)))
            {
                result = true;
            }

            else
            {
                result = false;
            }

            return result;
        }

        public bool SoAlone(int a, int b)
        {
            bool result;

            if ((a >= 13 && a <= 19) && (b >= 13 && b <= 19))
            {
                result = false;
            }
            else if (a >= 13 && a <= 19)
            {
                result = true;
            }
            else if (b >= 13 && b <= 19)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        public string RemoveDel(string str)
        {
            string result="";
            int length = str.Length - 2;
            char[] arrToString = str.ToCharArray();

            if (arrToString[1] == 'd' && arrToString[2] == 'e' && arrToString[3] == 'l')
            {
                result += arrToString[0];
                for (int i = 1; i < length - 1; i++)
                {
                    result += arrToString[i + 3];
                }
            }
            else
            {
                result = str;
            }

            return result;
        }

        public bool IxStart(string str)
        {
            bool result;
            char[] strToArray = str.ToCharArray();

            if (strToArray[1] == 'i' && strToArray[2] == 'x')
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        public string StartOz(string str)
        {
            string result = "";
            char[] strToArray = str.ToCharArray();

            if (strToArray[0] == 'o')
            {
                if (strToArray[1] == 'z')
                {
                    for (int i = 0; i < 2; i++)
                    {
                        result += strToArray[i];
                    }

                }
                else
                {
                    result += strToArray[0];

                }
            }
            else if (strToArray[1] == 'z')
            {
                result += strToArray[1];

            }
            else
            {
                result = "";
            }

            return result;

        }

        public int Max(int a, int b, int c)
        {
            int result;

            if (a > b && a > c)
            {
                result = a;
            }
            else if (b > a && b > c)
            {
                result = b;
            }
            else
            {
                result = c;
            }

            return result;
        }

        public int Closer(int a, int b)
        {
            int result;
            int distFrom10A = Math.Abs(10 - a);
            int distFrom10B = Math.Abs(10 - b);

            if (distFrom10A > distFrom10B)
            {
                result = b;
            }
            else if (distFrom10B > distFrom10A)
            {
                result = a;
            }
            else
            {
                result = 0;
            }
            return result;
        }

        public bool GotE(string str)
        {
            bool result;
            int length = str.Length;
            char[] strToArray = str.ToCharArray();
            int counter = 0;

            for (int i = 0; i < length; i++)
            {
                if (strToArray[i] == 'e')
                {
                    counter += 1;
                }
            }

            if (counter >= 1 && counter <= 3)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        public string EndUp(string str)
        {
            string result;
            int length = str.Length;
            char[] strToArray = str.ToCharArray();
            string tempArray;

            if (length < 3)
            {
                result = str.ToUpper();
            }
            else
            {
                tempArray = str.ToUpper();
                char[] tempArray2 = new char[length];

                for (int i = (length - 1); i > (length - 4); i--)
                {
                    strToArray[i] = tempArray[i];
                }
                result = new string(strToArray);
            }



            return result;

        }

        public string EveryNth(string str, int n)
        {
            string result ="";
            int length = str.Length;
            char[] strToArray = str.ToCharArray();
            int num = n;

            result += strToArray[0];
            for (int i = 1; i < (length / n + 1); i++)
            {
                result+= strToArray[num];
                num += n;

            }

            return result;

        }
    }


}