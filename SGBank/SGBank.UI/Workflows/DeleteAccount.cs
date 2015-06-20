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
    public class DeleteAccount
    {
        private Account _currentAccount;

        public void Execute()
        {
            string getAccountNum = GetAccounttoDelete();
            var ops = new AccountOperations();
            var accountToDelete = ConverNumberToAccount(getAccountNum);

            var request = new DeleteAccountRequest()
            {
                Account  = accountToDelete
            };

            var response = ops.DeleteAccount(request);

            if (response.Success)
            {
                Console.Clear();
                Console.WriteLine("Account Deleted");
                UserInteractions.PressKeyToContinue();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("An Error Occured:  {0}", response.Message);
                UserInteractions.PressKeyToContinue();
            }


        }
        private Account ConverNumberToAccount(string accountNumber)
        {
            var ops = new AccountOperations();
            var response = ops.GetAccount(accountNumber);
            Console.Clear();

                _currentAccount = response.Data;
                return _currentAccount;

        }

        private string GetAccounttoDelete()
        {
          
                Console.Write("Enter an Account number: ");
                var input = Console.ReadLine();
            return input;


        }


    }
}
