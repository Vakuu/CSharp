using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankOfKurtovoKonare.Accounts
{
    using Customers;
    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private double interestRate;
        public Customer Customer { get; set; }
        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Ballance cannot be negative.");
                }
                this.balance = value;
            }
        }
        public double InterestRate
        {
            get
            {
                return this.interestRate;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest rate cannot be negative.");
                }
                this.interestRate = value;
            }
        }
        public Account(Customer customer, decimal balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        public abstract decimal CalculateInterestForAPeriod(int months);
    }
}
