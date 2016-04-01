using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankOfKurtovoKonare.Interfaces
{
    public interface IDepositAccount
    {
        void Deposit(decimal ammount);
        void Withdraw(decimal ammount);
    }
}
