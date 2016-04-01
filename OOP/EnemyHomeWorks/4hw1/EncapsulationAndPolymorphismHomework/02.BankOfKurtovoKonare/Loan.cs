namespace _02.BankOfKurtovoKonare
{
    class Loan : BlankAccount
    {
        public Loan(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }
        
        public override decimal CalculateInterest(int monhts)
        {
            if (this.Customer == Customer.Individual)
            {
                if (monhts <= 3)
                {
                    return this.Balance;
                }
                else
                {
                    return this.Balance * (1 + this.InterestRate * (monhts - 3));
                }
            }
            else {
                if (monhts <= 2)
                {
                    return this.Balance;
                }
                else
                {
                    return this.Balance * (1 + this.InterestRate * (monhts - 2));
                }
            }
         }

     }
}

