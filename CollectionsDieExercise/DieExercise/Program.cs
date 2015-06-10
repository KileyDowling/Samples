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
            Dictionary<string, int> amountOfTimes = new Dictionary<string, int>();

            for (int i = 0; i < 100; i++)
            {
                result[i] = rng1.Next(2, 13);
            }

            //key: roll result, value: # of times that was rolled
            // add to the value each time it finds a result
            Dictionary<int, int> foundResultIntsDictionary = new Dictionary<int, int>();
            int sum = 0;
            for (int i = 2; i < 13; i++)
            {
                foundResultIntsDictionary.Add(i,sum);

            }

            List<int> list = new List<int>(foundResultIntsDictionary.Keys);

            //iterate through each index in result [100 total]
            //iterate 2 to 12, roll results
            int foundIt = 0;
            int counter = 2;
            while (counter < 13)
            {                
                //start at index 0 for list, go to 11 
                    //index of list
                    foreach (var num in result)
                    {
                        if (list[counter-2]==result[num])
                        {
                            foundIt += 1;
                        }
                    }
                
                foundResultIntsDictionary[counter] =foundIt;
                foundIt = 0;
                counter += 1;
            }

            int totalRolls = 0;
            foreach (var item in foundResultIntsDictionary.Keys)
            {
                Console.WriteLine("Result {0} was rolled {1} times",item,foundResultIntsDictionary[item]);
                totalRolls += foundResultIntsDictionary[item];
            }
            Console.WriteLine("\n\n\nTotal Rolls: {0}", totalRolls);
            Console.ReadLine();


        }
    }
}