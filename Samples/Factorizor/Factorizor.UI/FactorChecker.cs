using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor.UI
{
    public class FactorChecker
    {
        public FactorResult CheckFactors(int number)
        {
            FactorResult result = new FactorResult();

            result.Number = number;

            result.Factors = GetFactors(number);
            result.IsPerfect = CheckPerfect(result);
            result.IsPrime = CheckPrime(result);

            return result;
        }

        private bool CheckPrime(FactorResult result)
        {
            return result.Factors.Count == 1;
        }

        private bool CheckPerfect(FactorResult result)
        {
            int sum = 0;

            for (int i = 0; i < result.Factors.Count; i++)
            {
                sum += result.Factors[i];
            }

            return sum == result.Number;
        }

        private List<int> GetFactors(int number)
        {
            List<int> factors = new List<int>();

            for (int i = 1; i < number; i++)
            {
                if (number%i == 0)
                {
                    factors.Add(i);
                }
            }

            return factors;
        }
    }
}
