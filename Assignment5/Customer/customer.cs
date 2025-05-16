public class Customer : ICustomer
{
    private readonly string _firstName;
    private readonly string _lastName;
    private readonly IWallet _wallet;

    public Customer(string firstName, string lastName, IWallet wallet)
    {
        _firstName = firstName;
        _lastName = lastName;
        _wallet = wallet; 
    }

    public string FirstName => _firstName;
    public string LastName => _lastName;

    public float GetWalletBalance() => _wallet.GetBalance();

    public void DepositToWallet(float amount) => _wallet.AddMoney(amount);

    public void WithdrawFromWallet(float amount) => _wallet.SubtractMoney(amount);
}
