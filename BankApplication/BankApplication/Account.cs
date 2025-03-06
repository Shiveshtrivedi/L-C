using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public abstract class Account
    {
        protected decimal Balance { get; set; }
        public string HolderName { get; set; }
        public abstract string Withdraw(decimal amount);

        public Account(string holderName, decimal initialBalance = 0)
        {
            HolderName = holderName;
            Balance = initialBalance;
        }

        public string Deposit(decimal amount)
        {
            if(amount<=0)
            {
                throw new ArgumentException("Deposit amount must be greater than zero");
            }

            Balance += amount;
            return $"Deposited Rs {amount}. New balance: Rs {Balance}";
        }

        public decimal GetBalance()
        {
            return Balance;
        }
    }
}
