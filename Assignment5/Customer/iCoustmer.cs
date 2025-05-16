public interface ICustomer
{
    string FirstName { get; }
    string LastName { get; }
    float GetWalletBalance();
    void DepositToWallet(float amount);
    void WithdrawFromWallet(float amount);
}