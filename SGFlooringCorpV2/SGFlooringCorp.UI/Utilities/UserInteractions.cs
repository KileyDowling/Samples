using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGFlooringCorp.Models;
using SGFlooringCorp.UI.Workflows;

namespace SGFlooringCorp.UI.Utilities
{
    public class UserInteractions
    {

        public static int PromptForChoice(string message, int lowerBound, int upperBound)
        {
            bool validInput = false;
            int output = 0;

            while (!validInput)
            {
                Console.Write(message);
                validInput = Int32.TryParse(Console.ReadLine(), out output);

                if (!validInput)
                {
                    Console.WriteLine("That is not a valid choice");
                }
                else
                {
                    if (output < lowerBound || output > upperBound)
                    {
                        validInput = false;
                        Console.WriteLine("Choose an option {0}-{1}", lowerBound, upperBound);
                    }
                }
            }

            return output;
        }

        public static void PressKeyToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static string GetRequiredStringFromUser()
        {
            string input ="";
            bool validInput = false;

            do
            {
                
            } while (!validInput);
            return input;
        }

        public static DateTime GetDateFromUser()
        {
            do
            {
                Console.WriteLine("Enter the date of the order you wish to look up ");
                Console.Write("in this format(MMDDYYYY): ");
                string input = Console.ReadLine();
                DateTime thisDate;

                if (DateTime.TryParse(input, out thisDate))
                {
                    thisDate = DateTime.Parse(input);
                    return thisDate;
                }

                Console.WriteLine("That was not a valid date.  Press any key to continue...");
                Console.ReadKey();
            } while (true);
        }

        public static OrderRequest PromptForValidOrder()
        {
            var request = new OrderRequest();

            return request;
        }
    }


}
