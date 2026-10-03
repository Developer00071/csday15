namespace MyApp;

public class PaymentCard
{
    private double balance;

    public PaymentCard(double startingBalance = 0)
    {
        balance = startingBalance;
    }

    public double Balance
    {
        get { return balance; }
    }

    public void AddMoney(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    public void TakeMoney(double amount)
    {
        if (amount > 0 && balance >= amount)
        {
            balance -= amount;
        }
    }
}
