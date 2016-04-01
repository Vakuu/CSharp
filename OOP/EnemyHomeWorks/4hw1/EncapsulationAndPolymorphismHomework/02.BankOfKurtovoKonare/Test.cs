using System;
using System.Collections.Generic;

namespace _02.BankOfKurtovoKonare
{
    class Test
    {
        static void Main()
        {
            Loan first = new Loan(Customer.Individual, 2000, 5.6m);
            Loan second = new Loan(Customer.Company, 15000, 7.6m);

            Mortgage one = new Mortgage(Customer.Company, 43413, 4.4m);
            Mortgage two = new Mortgage(Customer.Individual, 3111, 3.4m);

            Deposit a = new Deposit(Customer.Individual, 750, 5m);
            Deposit b = new Deposit(Customer.Individual, 1001, 5.6m);
            b.DepositMoney(12000);
            b.Withdraw(1200);
            List<IAccount> accounts = new List<IAccount>()
            {
                first, second, one , two, a, b
            };

            foreach (var account in accounts)
            {
                Console.WriteLine(
                    "{0,-15}: {1:N2}, {2:N2}, {3:N2}, {4:N2}",
                    account.GetType().Name,
                    account.CalculateInterest(2),
                    account.CalculateInterest(3),
                    account.CalculateInterest(10),
                    account.CalculateInterest(13)
                    );
            }
        }
    }
}
