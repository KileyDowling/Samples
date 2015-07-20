using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            FactorChecker checker = new FactorChecker();
            FactorResult result = checker.CheckFactors(number);

            PrintResults(result);
            Console.ReadLine();
        }

        private static void PrintResults(FactorResult result)
        {
            Console.WriteLine("The number you selected was {0}", result.Number);
            Console.WriteLine("The factors are: {0}", string.Join(",", result.Factors));
            Console.WriteLine("Perfect? {0}", result.IsPerfect);
            Console.WriteLine("Prime? {0}", result.IsPrime);
        }
    }
}
