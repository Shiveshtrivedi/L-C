public interface IWallet
{
    float GetBalance();
    void AddMoney(float amount);
    void SubtractMoney(float amount);
}