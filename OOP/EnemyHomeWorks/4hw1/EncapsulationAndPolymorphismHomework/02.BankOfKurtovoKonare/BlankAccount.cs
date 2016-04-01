namespace _02.BankOfKurtovoKonare
{
    abstract class BlankAccount : IAccount
    {
        protected decimal balance;
        protected decimal interestRate;
        protected Customer customer;

        public BlankAccount(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        public Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }
        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public decimal InterestRate
        {
            get { return this.interestRate; }
            set { this.interestRate = value; }
        }

        public void DepositMoney(decimal depositAmmount)
        {
            this.Balance += depositAmmount;
        }

        public virtual decimal CalculateInterest(int monhts)
        {
            return this.Balance * (1 + this.InterestRate * monhts);
        }
    }
}
