using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.Arrays.BLL
{
    public class ArrayWarmups
    {
        public bool FirstLast6(int[] numbers)
        {
            bool result;
            int length = numbers.Length;
            int num6 = 0;

            for (int i = 0; i < length; i++)
            {
                if (numbers[i] == 6 && i == 0 || numbers[i] == 6 && i == length - 1)
                {
                    num6 += 1;
                }
            }
            if (num6 > 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;

        }

        public bool SameFirstLast(int[] numbers)
        {
            bool result;
            int firLast = 0;
            int length = numbers.Length;

            if (numbers[0] == numbers[length - 1])
            {
                firLast += 1;
            }

            if (firLast > 0)
                result = true;
            else
                result = false;
            return result;

        }

        public int[] MakePi(int n)
        {
            int[] result = new int[n];
            int[] piAsArray = {3, 1, 4, 1, 5, 9, 2, 6, 3, 5, 8, 9, 7, 9, 3, 2, 3, 8, 4, 6};


            for (int i = 0; i < n; i++)
            {
                result[i] = piAsArray[i];
            }

            return result;

        }

        public bool CommonEnd(int[] a, int[] b)
        {
            bool result;
            int length1 = a.Length;
            int length2 = b.Length;
            int samefirLas = 0;

            if (a[0] == b[0] || a[length1 - 1] == b[length2 - 1])
            {
                samefirLas += 1;
            }

            if (samefirLas > 0)
                result = true;
            else
                result = false;

            return result;
        }

        public int Sum(int[] numbers)
        {
            int result = 0;
            int runningTot = 0;
            int length = numbers.Length;

            for (int i = 0; i < length; i++)
            {
                runningTot += numbers[i];
            }
            result = runningTot;
            return result;

        }

        public int[] RotateLeft(int[] numbers)
        {
            int length = numbers.Length;
            int[] result = new int[length];

            for (int i = 0; i < length - 1; i++)
            {
                result[i] = numbers[i + 1];
            }

            result[length - 1] = numbers[0];

            return result;
        }

        public int[] Reverse(int[] numbers)
        {
            int length = numbers.Length - 1;
            int[] result = new int[length + 1];
            int counter = 0;

            for (int i = length; i >= 0; i--)
            {
                result[counter] = numbers[i];
                counter += 1;
            }
            return result;

        }

        public int[] HigherWins(int[] numbers)
        {
            int length = numbers.Length;
            int[] result = new int[length];
            int isLarger;

            if (numbers[0] > numbers[length - 1])
                isLarger = numbers[0];
            else
                isLarger = numbers[length - 1];

            for (int i = 0; i < length; i++)
            {
                result[i] = isLarger;
            }

            return result;
        }

        public int[] GetMiddle(int[] a, int[] b)
        {
            int[] result = new int[2];

            result[0] = a[1];
            result[1] = b[1];

            return result;
        }


        public bool HasEven(int[] numbers)
        {
            bool result;
            int length = numbers.Length;
            int hasEv = 0;

            for (int i = 0; i < length; i++)
            {
                if (numbers[i]%2 == 0)
                {
                    hasEv += 1;
                }
            }

            if (hasEv > 0)
                result = true;
            else
                result = false;

            return result;
        }

        public int[] KeepLast(int[] numbers)
        {
            int length = numbers.Length*2;
            int[] result = new int[length];

            result[length - 1] = numbers[numbers.Length - 1];

            return result;
        }

        public bool Double23(int[] numbers)
        {
            bool result;
            int length = numbers.Length;
            int doub2 = 0;
            int doub3 = 0;

            for (int i = 0; i < length; i++)
            {
                if (numbers[i] == 2)
                {
                    doub2 += 1;
                }
                else if (numbers[i] == 3)
                {
                    doub3 += 1;
                }
            }

            if (doub2 == 2 || doub3 == 2)
                result = true;
            else
                result = false;

            return result;
        }


        public int[] Fix23(int[] numbers)
        {
            int length = numbers.Length;

            for (int i = 0; i < length - 1; i++)
            {
                if (numbers[i] == 2 && numbers[i + 1] == 3)
                    numbers[i + 1] = 0;
            }

            return numbers;
        }

        public bool Unlucky1(int[] numbers)
        {
            bool result;
            int length = numbers.Length;
            int foundUn1 = 0;

            if (numbers[0] == 1 && numbers[1] == 3 || numbers[1] == 1 && numbers[2] == 3 ||
                numbers[length - 2] == 1 && numbers[length - 1] == 3)
            {
                foundUn1 += 1;
            }
            if (foundUn1 > 0)
                result = true;
            else
                result = false;

            return result;
        }

        public int[] make2(int[] a, int[] b)
        {
            int[] result = new int[2];
            int lengthA = a.Length;
            int counter = 0;

            while (counter < lengthA)
            {
                result[counter] = a[counter];
                counter += 1;
            }

            if (2 > lengthA)
            {
                for (int j = lengthA; j < 2; j++)
                {
                    result[j] = b[j - counter];
                }
            }

            return result;

        }
    }
}