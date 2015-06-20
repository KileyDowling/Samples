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
    class WithdrawalWorkflow
    {
        public void Execute(Account account)
        {
            decimal amount = GetWithdrawalAmount();
            var ops = new AccountOperations();
            var request = new WithDrawalRequest()
            {
                Account = account,
                WithdrawalAmount = amount
            };

            var response = ops.MakeWithDrawal(request);

            if (response.Success)
            {
                Console.Clear();
                Console.WriteLine("Withdrawn from account {0}, New Balance: {1:C}", response.Data.AccountNumber, response.Data.Balance);
                UserInteractions.PressKeyToContinue();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("An Error Occured:  {0}", response.Message);
                UserInteractions.PressKeyToContinue();
            }


        }

        private decimal GetWithdrawalAmount()
        {
            do
            {
                Console.Write("Enter a withdrawal amount: ");
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
