using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class BankManagement
    {
        private Dictionary<AccountType, Account> Accounts { get; set; }

        public BankManagement()
        {
            Accounts = new Dictionary<AccountType, Account>();
        }

        public void AddAccount(AccountType accountType, Account account)
        {
            if (account == null)
                throw new ArgumentNullException(nameof(account));

            Accounts[accountType] = account;
        }

        public string ProcessTransaction(AccountType accountType, TransactionType action, decimal amount)
        {
            if (!Accounts.ContainsKey(accountType))
                return "Account not found";

            Account account = Accounts[accountType];
            switch (action)
            {
                case TransactionType.Deposit:
                    return account.Deposit(amount);
                case TransactionType.Withdraw:
                    return account.Withdraw(amount);
                default:
                    return "Invalid action";
            }
        }

        public void DisplayAccounts()
        {
            foreach (var account in Accounts)
            {
                Console.WriteLine($"Account Type : {account.Key}," +
                    $" HolderName : {(account.Value).HolderName}," +
                    $" Bank Balance : {(account.Value).GetBalance()}");
            }
        }

    }
}
