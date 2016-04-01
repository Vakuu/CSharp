using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankOfKurtovoKonare.Accounts
{
    using Customers;
    using Interfaces;

    public class LoanAccount : Account, ILoanAccount
    {
        public LoanAccount(Customer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate)
        {
        }
        public void Deposit(decimal ammount)
        {
            this.Balance += ammount;
        }
        public override decimal CalculateInterestForAPeriod(int months)
        {
            if (months < 0)
            {
                throw new ArgumentOutOfRangeException("Months cannot be negative number.");
            }
            if (this.Customer is IndividualCustomer)
            {
                if (months <= 3)
                {
                    return 0;
                }
                else
                {
                    return this.Balance * (decimal)(1 + (this.InterestRate / 100) * ((double)months - 3));
                }
            }
            if (months <= 2)
            {
                return 0;
            }
            return this.Balance * (decimal)(1 + (this.InterestRate / 100) * ((double)months - 2));
        }
    }
}
