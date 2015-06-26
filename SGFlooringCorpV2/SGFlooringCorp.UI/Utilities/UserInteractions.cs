using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGFlooringCorp.Models;

namespace SGFlooringCorp.UI.Utilities
{
    class UserInteractions
    {
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
                Console.Clear();
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
