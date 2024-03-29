﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGBank.BLL;
using SGBank.Models;
using SGBank.UI.Utilities;

namespace SGBank.UI.Workflows
{
    public class LookupMenu
    {
        private Account _currentAccount;
        public void Execute()
        {
            string accountNumber = GetAccountNumberFromUser();

            DisplayAccountInformation(accountNumber);
        }

        private void DisplayAccountInformation(string accountNumber)
        {
            var ops = new AccountOperations();
            var response = ops.GetAccount(accountNumber);
            Console.Clear();

            if (response.Success)
            {
                _currentAccount = response.Data;
                PrintAccountDetails(response);
                DisplayActionMenu();
                UserInteractions.PressKeyToContinue();
            }
            else
            {
                Console.WriteLine("A problem occured...");
                Console.WriteLine(response.Message);

                UserInteractions.PressKeyToContinue();
            }

        }

        private void DisplayActionMenu()
        {
            do
            {
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Transfer");
                Console.WriteLine("(Q) for quit");

                Console.WriteLine("\n\n Enter your choice: ");
                string input = Console.ReadLine();

                if (input.ToUpper() == "Q")
                    break;

                ProcessChoice(input);
            } while (true);
        }

        private void ProcessChoice(string input)
        {
            switch (input)
            {
                case "1":
                    var depositWorkflow = new DepositWorkflow();
                    depositWorkflow.Execute(_currentAccount);
                    break;

                case "2":
                    var withdrawalWorkflow = new WithdrawalWorkflow();
                    withdrawalWorkflow.Execute(_currentAccount);
                    break;

                case "3":
                    var transferWorkflow = new TransferWorkflow();
                    transferWorkflow.Execute(_currentAccount);
                    break;


            }
        }

        private void PrintAccountDetails(Response<Account> response)
        {
            Console.WriteLine("Account Information");
            Console.WriteLine("=========================================");
            Console.WriteLine("Account Number: {0}", response.Data.AccountNumber);
            Console.WriteLine("Account Name: {0}, {1}", response.Data.LastName, response.Data.FirstName);
            Console.WriteLine("Account Balance: {0:C}", response.Data.Balance);
        }

        private string GetAccountNumberFromUser()
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
    }
}
