using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.interfaces
{
    public interface ITransactionProcessor
    {
        void ProcessTransactionRequest(IBankManagement bankManagement, AccountType accountType, TransactionType transactionType);
        string PerformTransaction(IAccount account, TransactionType transactionType, decimal amount);
    }
}
