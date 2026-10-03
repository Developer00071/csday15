namespace MyApp;

public class PaymentTerminal
{
    private double cashRegister;

    public double CashInRegister
    {
        get { return cashRegister; }
    }

    public void EatLunch(PaymentCard card)
    {
        double lunchPrice = 10.50;
        card.TakeMoney(lunchPrice);
        cashRegister += lunchPrice;
    }

    public void DrinkCoffee(PaymentCard card)
    {
        double coffeePrice = 3.00;
        card.TakeMoney(coffeePrice);
        cashRegister += coffeePrice;
    }

    public void AddMoneyToCard(PaymentCard card, double amount)
    {
        card.AddMoney(amount);
        cashRegister += amount;
    }
}
