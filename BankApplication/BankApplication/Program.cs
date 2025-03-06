using System;

namespace BankApplication
{
    class Program
    {
        static void Main()
        {
            BankManagement bankManagement = new BankManagement();

            Console.Write("Enter Savings Account Holder Name: ");
            string savingsAccountHolderName = Console.ReadLine();
            bankManagement.AddAccount(AccountType.Saving, new SavingsAccount(savingsAccountHolderName));

            Console.Write("Enter Current Account Holder Name: ");
            string currentAccountHolderName = Console.ReadLine();

            bankManagement.AddAccount(AccountType.Current, new CurrentAccount(currentAccountHolderName));

            TransactionHandler.HandleTransactions(bankManagement);
            bankManagement.DisplayAccounts();
        }
    }
}
