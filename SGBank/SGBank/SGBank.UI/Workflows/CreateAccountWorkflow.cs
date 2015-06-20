using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGBank.BLL;
using SGBank.Models;
using SGBank.UI.Utilities;


namespace SGBank.UI.Workflows
{
    class CreateAccountWorkflow
    {
        public void Execute()
        {
            var account = GetNewAccountData();

            var ops = new AccountOperations();
            var request = new CreateAccountRequest()
            {
                Account = account
            };

            var response = ops.CreateAccount(request);

            if (response.Success)
            {
                Console.Clear();
                Console.WriteLine("New account created! Thank you {0} for your business!. Your balance is {1:C}", response.Data.FirstName, response.Data.Balance);
                UserInteractions.PressKeyToContinue();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("An Error Occured:  {0}", response.Message);
                UserInteractions.PressKeyToContinue();
            }




        }

        private Account GetNewAccountData()
        {
            var newAccount = new Account();
           
            var firstname = GetNewFirstName();
            var lastname = GetNewLastName();
            var initialdeposit = GetInitialDeposit();

            newAccount.FirstName = firstname;
            newAccount.LastName = lastname;
            newAccount.Balance = initialdeposit;

            return newAccount;


        }

        

        private string GetNewFirstName()
        {
            Console.Write("Enter customer's first name: ");
            var input = Console.ReadLine();
       
            UserInteractions.PressKeyToContinue();
            Console.Clear();

            return input;

        }

        private string GetNewLastName()
        {
            Console.Write("Enter customer's last name: ");
            var input = Console.ReadLine();

            UserInteractions.PressKeyToContinue();
            Console.Clear();

            return input;
        }

        private decimal GetInitialDeposit()
        {
            do
            {
                Console.Write("Enter customer's initial deposit: ");
                var input = Console.ReadLine();
                decimal amount;
                if (decimal.TryParse(input, out amount))
                {
                    return amount;
                }

                Console.WriteLine("That was not a valid amount.  Please enter in decimal format.");
                UserInteractions.PressKeyToContinue();
                Console.Clear();
            } while (true);


        }




    }
}
