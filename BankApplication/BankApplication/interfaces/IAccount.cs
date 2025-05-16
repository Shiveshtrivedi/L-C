using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.interfaces
{
    public interface IAccount
    {
        string HolderName { get; }
        decimal GetBalance();
        string Deposit(decimal amount);
        string Withdraw(decimal amount);
    }
}
