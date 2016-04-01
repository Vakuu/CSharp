using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankOfKurtovoKonare
{
    interface IAccount
    {
        Customer Customer { get; set; }

        decimal Balance { get; set; }

        decimal Rate { get; set; }

        void DepositMoney(decimal money);

        decimal CalculateInterest(int months);
    }
}
