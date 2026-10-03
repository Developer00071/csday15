namespace MyApp;

public class Cnt
{
    public int value { get; set; }

    public Cnt()
    {
        value = 0;
    }

    public Cnt(int startValue)
    {
        value = startValue;
    }

    public void Increase()
    {
        value++;
    }

    public void Decrease()
    {
        value--;
    }

    public void Increase(int increaseBy)
    {
        if (increaseBy > 0)
        {
            value += increaseBy;
        }
    }

    public void Decrease(int decreaseBy)
    {
        if (decreaseBy > 0)
        {
            value -= decreaseBy;
        }
    }
}
