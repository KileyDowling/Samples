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
            char[] tempArray = new char[n * 3];
            char[] strToArray = str.ToCharArray();
            int counter = 0;

            //add logic for if string is less than 3 chars

            while (counter < n * 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    tempArray[counter + i] = strToArray[i];
                }
                counter += 3;
            }
            result = new string(tempArray);
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
            if (str.Length%2 == 0)
                x = 0;
            char[] tempArray = new char[str.Length/2+x];

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
            string result ="";
            int numTimes = 0;
            char[] strToArray = str.ToCharArray();


            while (numTimes < str.Length+1)
            {
                for (int i = 0; i < numTimes; i++)
                {
                    result += strToArray[i];
                }
                numTimes += 1;
            }

            return result;
        }
    }

}