using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Roll the dice! Press enter to continue");
            Console.ReadLine();

            Random rng1 = new Random();
            int[] result = new int[100];
            for (int i = 0; i < 100; i++)
            {
                result[i] = rng1.Next(2, 13);
            }

            int foundNum = 0;
            int count = 0;

            int total = 0;



            for (int i = 2; i < 13; i++)
            {
                foreach (int num in result)
                {
                    if (result[num] == i)
                    {
                        foundNum += 1;
                    }

                }
                total += foundNum;
                Console.WriteLine("Dice Total " + i + "\nTimes Rolled: " + foundNum + "\n");
                foundNum = 0;
            }
            Console.WriteLine("total rolls:" + total);

            Console.ReadLine();


        }
    }
}