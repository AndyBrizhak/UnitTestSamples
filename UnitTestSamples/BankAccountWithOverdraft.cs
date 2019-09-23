namespace UnitTestSamples
{
    public class BankAccountWithOverdraft : BankAccount
    {
        public int MinimumBalance { get; }

        public BankAccountWithOverdraft(int startingBalance, int minimumBalance)
            : base(startingBalance)
        {
            MinimumBalance = minimumBalance;
        }

        public new bool Withdraw(int amount)
        {
            if (Balance - amount > MinimumBalance)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }
}