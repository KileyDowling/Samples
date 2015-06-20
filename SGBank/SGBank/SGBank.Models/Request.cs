using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBank.Models
{
    public class DepositRequest
    {
        public decimal DepositAmount { get; set; }
        public Account Account { get; set; }
    }

    public class WithDrawalRequest
    {
        public decimal WithdrawalAmount { get; set; }
        public Account Account { get; set; }

    }

    public class TransferRequest
    {
        public decimal TransferAmount { get; set; }
        public Account AccountFrom { get; set; }
    }

    public class CreateAccountRequest
    {
        public Account Account { get; set; } 

    }
}
