using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class SavingsAccount : Account
    {
        private const decimal DefaultWithdrawalLimit = 1000;
        private decimal WithdrawalLimit { get; set; }

        public SavingsAccount(string holderName, decimal initialBalance = 0, decimal withdrawalLimit = DefaultWithdrawalLimit) : base(holderName, initialBalance)
        {
            WithdrawalLimit = withdrawalLimit;
        }

        public override string Withdraw(decimal amount)
        {
            if (!IsValidAmount(amount))
                throw new InvalidOperationException("Invalid withdrawal amount.");
            if (ExceedsWithdrawalLimit(amount))
                throw new InvalidOperationException($"Withdrawal exceeds limit of Rs {WithdrawalLimit}");
            if (!HasSufficientFunds(amount))
                throw new InvalidOperationException("Insufficient funds.");


            Balance -= amount;
            return $"Withdrew Rs {amount}. New balance: Rs {Balance}";
        }

        private bool IsValidAmount(decimal amount) => amount > 0;

        private bool ExceedsWithdrawalLimit(decimal amount) => amount > WithdrawalLimit;

        private bool HasSufficientFunds(decimal amount) => amount <= Balance;
    }
}
