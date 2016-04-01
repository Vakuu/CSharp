using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankOfKurtovoKonare
{
    abstract class Account : IAccount
    {
        private Customer customer;
        private decimal balance;
        private decimal rate;

        public Account(Customer customer, decimal balance, decimal rate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.Rate = rate;
        }

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
                    throw new ArgumentOutOfRangeException("balance", "The balance cannot be negative!");
                }

                this.balance = value;
            }
        }

        public decimal Rate
        {
            get
            {
                return this.rate;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("interestRate", "The interest rate cannot be negative!");
                }

                this.rate = value;
            }
        }

        public void DepositMoney(decimal money)
        {
            this.Balance += money;
        }

        public abstract decimal CalculateInterest(int months);

        public override string ToString()
        {
            return string.Format("Account: {0}\nBalance = {1}\nInterest rate = {2}\n", this.GetType().Name, this.Balance, this.Rate);
        }
    }
}
