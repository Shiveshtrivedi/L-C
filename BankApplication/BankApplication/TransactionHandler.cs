using System;

namespace BankApplication
{
    public static class TransactionHandler
    {
        public static void HandleTransactions(BankManagement bankManagement)
        {
            foreach (var accountType in Enum.GetValues(typeof(AccountType)))
            {
                ProcessUserTransaction(bankManagement, (AccountType)accountType, TransactionType.Deposit);
                ProcessUserTransaction(bankManagement, (AccountType)accountType, TransactionType.Withdraw);
            }
        }

        private static void ProcessUserTransaction(BankManagement bankManagement, AccountType accountType, TransactionType transactionType)
        {
            Console.Write($"Enter {transactionType} amount for {accountType} account: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
            {
                string result = bankManagement.ProcessTransaction(accountType, transactionType, amount);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a valid positive number.");
            }
        }
    }
}
