using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class CurrentAccount : Account
    {
        private decimal OverdraftLimit { get; set; }

        public CurrentAccount(string holderName, decimal initialBalance = 0, decimal overdraftLimit = 500) : base(holderName, initialBalance)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override string Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new InvalidOperationException("Invalid withdrawal amount");

            if (amount <= (Balance + OverdraftLimit))
            {
                Balance -= amount;
                return $"Withdraw Rs {amount}. New balance: Rs {Balance}";
            }
            return "Exceeds bank amount limit";
        }
    }
}
