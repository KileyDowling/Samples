using System;
using System.Collections.Generic;
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
            return input;
        }

        public static string GetDateFromUser()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Enter the date of the order you wish to look up ");
                Console.Write("in this format(MMDDYYYY): ");
                string input = Console.ReadLine();
                int thisDate;

                if (int.TryParse(input, out thisDate))
                {
                    return input;
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

        internal static string GetStateAbbreviation()
        {
            throw new NotImplementedException();
        }
    }


}
