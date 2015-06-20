using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SGBank.BLL;
using SGBank.Models;

namespace SGBank.Tests
{
    [TestFixture]
    public class AccountOperationsTests
    {
        [Test]
        public void FoundAccountReturnsSuccess()
        {
            var operations = new AccountOperations();
            var response = operations.GetAccount("1");

            Assert.IsTrue(response.Success);
            Assert.AreEqual("1", response.Data.AccountNumber);
            Assert.AreEqual("Mary", response.Data.FirstName);
            Assert.AreEqual("Jones", response.Data.LastName);
            Assert.AreEqual(327.00M, response.Data.Balance);
        }

        [Test]
        public void NotFoundAccountReturnsFail()
        {
            var operations = new AccountOperations();
            var response = operations.GetAccount("10000");
            Assert.IsFalse(response.Success);
            Assert.AreEqual("Account Not Found!", response.Message);
        }

        [Test]
        public void CanDepositMoney()
        {
            var ops = new AccountOperations();
            var loadAccountResponse = ops.GetAccount("2");
            var request = new DepositRequest();
            request.Account = loadAccountResponse.Data;
            request.DepositAmount = 100.00M;
            var depositResponse = ops.MakeDeposit(request);

            var reloadAccount = ops.GetAccount("2");

            Assert.AreEqual("2", reloadAccount.Data.AccountNumber);
            Assert.AreEqual("Bob", reloadAccount.Data.FirstName);
            Assert.AreEqual(223.00M, reloadAccount.Data.Balance);
        }

        [Test]
        public void CanWithdrawMoney()
        {
            var ops = new AccountOperations();
            var loadAccountResponse = ops.GetAccount("2");
            var request = new WithDrawalRequest();
            request.Account = loadAccountResponse.Data;
            request.WithdrawalAmount = 100.00M;
            var withdrawalRequest = ops.MakeWithDrawal(request);

            var reloadAccount = ops.GetAccount("2");

            Assert.AreEqual("2", reloadAccount.Data.AccountNumber);
            Assert.AreEqual("Bob", reloadAccount.Data.FirstName);
            Assert.AreEqual(23.00M, reloadAccount.Data.Balance);

        }

        [Test]
        public void CanTransferMoney()
        {
            var ops = new AccountOperations();
            var accountFrom = ops.GetAccount("1");
            var accountTo = ops.GetAccount("2");
        }
    }
}
