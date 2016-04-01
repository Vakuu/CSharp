using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankOfKurtovoKonare
{
    using Interfaces;
    using Customers;
    using Accounts;
    class Program
    {
        static void Main(string[] args)
        {
            DepositAccount depositAcc1 = new DepositAccount(new CompanyCustomer(), 10000, 7.0);
            DepositAccount depositAcc2 = new DepositAccount(new IndividualCustomer(), 1000, 8.0);
            LoanAccount loanAcc1 = new LoanAccount(new CompanyCustomer(), 10000, 7.0);
            LoanAccount loanAcc2 = new LoanAccount(new IndividualCustomer(), 1000, 8.0);
            MortgageAccount mortgageAcc1 = new MortgageAccount(new CompanyCustomer(), 10000, 7.0);
            MortgageAccount mortgageAcc2 = new MortgageAccount(new IndividualCustomer(), 1000, 8.0);
            Console.WriteLine(depositAcc1.CalculateInterestForAPeriod(10));
            Console.WriteLine(depositAcc2.CalculateInterestForAPeriod(10));
            Console.WriteLine(loanAcc1.CalculateInterestForAPeriod(2));
            Console.WriteLine(loanAcc1.CalculateInterestForAPeriod(4));
            Console.WriteLine(loanAcc2.CalculateInterestForAPeriod(3));
            Console.WriteLine(loanAcc2.CalculateInterestForAPeriod(6));
            Console.WriteLine(mortgageAcc1.CalculateInterestForAPeriod(12));
            Console.WriteLine(mortgageAcc1.CalculateInterestForAPeriod(14));
            Console.WriteLine(mortgageAcc2.CalculateInterestForAPeriod(6));
            Console.WriteLine(mortgageAcc2.CalculateInterestForAPeriod(8));
        }
    }
}
