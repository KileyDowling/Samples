using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata.BLL
{
    public class Calculator
    {
        public int Add(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;
            if (input.Contains("\n"))
            {
                return GetSumWithNewLine(input);
            }

            if (input.Contains(","))
            {
                return GetSumOfArray(input);
            }

            return int.Parse(input);
        }

        private int GetSumWithNewLine(string input)
        {
            string newInput = input.Replace('\n', ',');
            int sum =  GetSumOfArray(newInput);
            return sum;
        }

        private int GetSumOfArray(string input)
        {
            string[] nums = input.Split(',');
            int sum = 0;

            foreach (string num in nums)
            {
                sum += int.Parse(num);
            }

            return sum;
        }
    }
}
