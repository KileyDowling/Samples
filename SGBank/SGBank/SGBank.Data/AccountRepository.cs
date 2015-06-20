using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGBank.Models;

namespace SGBank.Data
{
    public class AccountRepository
    {
        private const string FilePath = @"DataFiles\Bank.txt";

        public Account GetAccount(string accountNumber)
        {
            List<Account> allAccounts = GetAllAcounts();

            foreach (var account in allAccounts)
            {
                if (account.AccountNumber == accountNumber)
                    return account;
            }

            return null;
        }

        public List<Account> GetAllAcounts()
        {
            List<Account> accounts = new List<Account>();

            var reader = File.ReadAllLines(FilePath);

            for (int i = 1; i < reader.Length; i++)
            {
                var columns = reader[i].Split(',');

                var account = new Account();

                account.AccountNumber = columns[0];
                account.FirstName = columns[1];
                account.LastName = columns[2];
                account.Balance = decimal.Parse(columns[3]);

                accounts.Add(account);
            }

            return accounts;
        }

        public void UpdateAccount(Account accountToUpdate)
        {
            var allAccounts = GetAllAcounts();

            var existingAccount = allAccounts.First(a => a.AccountNumber == accountToUpdate.AccountNumber);
            existingAccount.Balance = accountToUpdate.Balance;
            existingAccount.FirstName = accountToUpdate.FirstName;
            existingAccount.LastName = accountToUpdate.LastName;

            OverwriteFile(allAccounts);
        }

        private void OverwriteFile(List<Account> allAccounts)
        {
            File.Delete(FilePath);

            using (var writer = File.CreateText(FilePath))
            {
                writer.WriteLine("AccountNumber,FirstName,LastName,Balance");

                foreach (var account in allAccounts)
                {
                    writer.WriteLine("{0},{1},{2},{3}", account.AccountNumber, account.FirstName, account.LastName, account.Balance);
                }
            }
        }

        public void CreateAccount(Account accountToAdd)
        {
            var allAccounts = GetAllAcounts();

            accountToAdd.AccountNumber = CreateNewAccountNumber();
            accountToAdd.Balance = accountToAdd.Balance;
            accountToAdd.FirstName = accountToAdd.FirstName;
            accountToAdd.LastName = accountToAdd.LastName;

            allAccounts.Add(accountToAdd);

            OverwriteFile(allAccounts);

        }

        private string CreateNewAccountNumber()
        {
            var reader = File.ReadAllLines(FilePath);
            string newAccountNumber;
            int accountNum;
            int numberofaccounts = 0;

            for (int i = 1; i < reader.Length; i++)
            {
                var columns = reader[i].Split(',');
                //access the first column [0], account number
                //find the last row in columns, add one to that number

                numberofaccounts += 1;
            }

            accountNum = numberofaccounts + 1;
            newAccountNumber = accountNum.ToString();
            return newAccountNumber;
        }


    }
}
