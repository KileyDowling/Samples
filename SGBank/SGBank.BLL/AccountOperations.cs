using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using SGBank.Data;
using SGBank.Models;

namespace SGBank.BLL
{
    public class AccountOperations
    {
        public Response<Account> GetAccount(string accountNumber)
        {
            var repo = new AccountRepository();
            var response = new Response<Account>();

            try
            {
                var account = repo.GetAccount(accountNumber);

                if (account == null)
                {
                    response.Success = false;
                    response.Message = "Account Not Found!";
                }
                else
                {
                    response.Success = true;
                    response.Data = account;
                }

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;

        }

        public Response<Account> MakeWithDrawal(WithDrawalRequest request)
        {
            var response = new Response<Account>();
            var accountToUpdate = request.Account;

            try
            {
                if (request.Account.Balance < request.WithdrawalAmount)
                {
                    response.Success = false;
                    response.Message = "You do not have adequate funds in your account.";

                }
                else
                {
                    accountToUpdate.Balance -= request.WithdrawalAmount;

                    var repo = new AccountRepository();
                    repo.UpdateAccount(accountToUpdate);
                    response.Success = true;
                    response.Data = accountToUpdate;

                }

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;

        }

        public Response<Account> MakeDeposit(DepositRequest request)
        {
            var response = new Response<Account>();
            var accountToUpdate = request.Account;

            try
            {
                if (request.DepositAmount <= 0)
                {
                    response.Success = false;
                    response.Message = "Must deposit a positive amount.";
                }
                else
                {
                    accountToUpdate.Balance += request.DepositAmount;

                    var repo = new AccountRepository();
                    repo.UpdateAccount(accountToUpdate);
                    response.Success = true;
                    response.Data = accountToUpdate;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public Response<Account> CreateAccount(CreateAccountRequest request)
        {
            var response = new Response<Account>();
            var newAccount = request.Account;

            var repo = new AccountRepository();         
            repo.CreateAccount(newAccount);
            response.Success = true;
            response.Data = newAccount;

            return response;

        } 

       

    }
}

