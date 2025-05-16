using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.interfaces
{
    public interface IBankManagement
    {
        void AddAccount(AccountType accountType, Account account);
        IAccount GetAccountByType(AccountType accountType);
        string ApplyLoan(AccountType accountType, decimal amount);
        bool HasActiveLoan(AccountType accountType);
        string RepayLoan(AccountType accountType, decimal amount);
        void DisplayAccounts();
    }
}
