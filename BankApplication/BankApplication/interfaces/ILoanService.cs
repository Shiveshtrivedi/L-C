using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.interfaces
{
     public interface ILoanService
       {
         string Apply(decimal amount, ref decimal balance);
         string Repay(decimal amount, Account account);
         bool HasActiveLoan { get; }
        }
}
