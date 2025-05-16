using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.interfaces
{
    public interface ITransactionHandler
    {
        void HandleTransactions(IBankManagement bankManagement,ITransactionProcessor transactionProcessor,ILoanProcessor loanProcessor);
    }
}
