namespace _02.BankOfKurtovoKonare
{
    class Mortgage : BlankAccount
    {
        public Mortgage(Customer customer, decimal balance, decimal interestRate) :
            base(customer, balance, interestRate)
        {

        }
        public override decimal CalculateInterest(int monhts)
        {
            if(this.Customer == Customer.Individual)
            {
                if(monhts <= 6)
                {
                    return this.Balance;
                }
                else
                {
                    return this.Balance * (1 + this.InterestRate * (monhts - 6));
                }
            }
            else
            {
                if(monhts <= 12)
                {
                    return base.CalculateInterest(monhts) * 0.5M;
                }
                else
                {
                    return base.CalculateInterest(monhts) * 0.5M + base.CalculateInterest(monhts - 12);
                }
            }
        }
    }
}
