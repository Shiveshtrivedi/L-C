using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.interfaces
{
    public interface ILoanProcessor
    {
        void HandleLoanApplication(IBankManagement bankManagement, AccountType accountType);
        void HandleLoanRepayment(IBankManagement bankManagement, AccountType accountType);
    }

}
