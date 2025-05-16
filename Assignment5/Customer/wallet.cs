public class Wallet : IWallet
{
    private float balance;

    public Wallet(float initialBalance)
    {
        if (initialBalance < 0)
            throw new ArgumentException("Initial balance cannot be negative", nameof(initialBalance));

        balance = initialBalance;
    }

    public float GetBalance() => balance;

    public void AddMoney(float amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be greater than zero", nameof(amount));

        balance += amount;
    }

    public void SubtractMoney(float amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be greater than zero", nameof(amount));

        if (amount > balance)
            throw new InvalidOperationException("Insufficient funds for withdrawal");

        balance -= amount;
    }
}
