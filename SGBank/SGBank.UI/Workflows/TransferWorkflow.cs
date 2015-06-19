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
    internal class TransferWorkflow
    {
        public void Execute(Account account)
        {
            // get transfer amount
            decimal transferAmount = GetTransferAmount(account);
            var ops = new AccountOperations();

            //withdraw transfer amount from that account
            var fromAccountRequest = new WithDrawalRequest()
            {
                Account = account,
                WithdrawalAmount = transferAmount
            };
            var fromAccountResponse = ops.MakeWithDrawal(fromAccountRequest);

            string getTransferAccount = GetTransferAccount();

            //trying to assign the transferTo account as the account in the deposit request.
            //have to change string toAccount to Account
            var getAccountResponse = ops.GetAccount(getTransferAccount);
            var toAccount = getAccountResponse.Data;

            var toAccountRequest = new DepositRequest()
            {
                Account = toAccount,
                DepositAmount = transferAmount
            };

            var toAccountResponse = ops.MakeDeposit(toAccountRequest);

            if (getAccountResponse.Success)
            {
                Console.Clear();
                Console.WriteLine("Transfered from account {0}, New Balance: {1:C}", fromAccountResponse.Data.AccountNumber, toAccountResponse.Data.Balance);
                UserInteractions.PressKeyToContinue();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("An Error Occured:  {0}", fromAccountResponse.Message);
                UserInteractions.PressKeyToContinue();
            }

        }

        public String GetTransferAccount()
        {
            do
            {
                Console.Clear();
                Console.Write("Enter an account number: ");
                string input = Console.ReadLine();
                int thisAccountNumber;

                if (int.TryParse(input, out thisAccountNumber))
                {
                    return input;
                }
                    

                Console.WriteLine("That was not a valid account number.  Press any key to continue...");
                Console.ReadKey();
            } while (true);
        }

        public decimal GetTransferAmount(Account account)
        {
            do
            {
                Console.Write("Enter a transfer amount: ");
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
