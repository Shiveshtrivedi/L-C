using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.interfaces
{
    public interface IUserInteractionService
    {
        string GetInput(string message);
        bool GetConfirmation(string message);
        void ShowMessage(string message);
    }
}
