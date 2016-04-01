using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankOfKurtovoKonare
{
    class Program
    {
        static void Main(string[] args)
        {
            Deposit deposit = new Deposit(Customer.Company, 28000m, 4.7m);
            deposit.Withdraw(365m);
            deposit.DepositMoney(1000m);
            deposit.CalculateInterest(10);
            Console.WriteLine("Deposit:\n{0}", deposit);

            Loans loanIndividual = new Loans(Customer.Individual, 12000m, 70m);
            loanIndividual.DepositMoney(3000m);
            loanIndividual.CalculateInterest(5);
            Console.WriteLine("Loan individual:\n{0}", loanIndividual);

            Loans loanCompalny = new Loans(Customer.Company, 500000m, 6m);
            loanCompalny.DepositMoney(30000m);
            loanCompalny.CalculateInterest(4);
            Console.WriteLine("Loan company:\n{0}", loanCompalny);

            Mortage mortageIndividual = new Mortage(Customer.Individual, 500, 8.3m);
            mortageIndividual.DepositMoney(430m);
            mortageIndividual.CalculateInterest(4);
            Console.WriteLine("Mortage individual:\n{0}", mortageIndividual);

            Mortage mortageCompany = new Mortage(Customer.Company, 50000, 4m);
            mortageIndividual.DepositMoney(6000m);
            mortageIndividual.CalculateInterest(33);
            Console.WriteLine("Mortage individual:\n{0}", mortageIndividual);
        }
    }
}
