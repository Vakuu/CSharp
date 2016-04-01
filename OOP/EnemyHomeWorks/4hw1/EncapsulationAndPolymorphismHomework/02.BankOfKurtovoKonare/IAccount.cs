namespace _02.BankOfKurtovoKonare
{
    interface IAccount
    {
        void DepositMoney(decimal depositAmmount);

        decimal CalculateInterest(int monhts);
    }
}
