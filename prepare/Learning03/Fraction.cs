public class Fractions
{
    private int topNumber;
    private int bottomNumber;

    public Fractions()
    {
        topNumber = 1;
        bottomNumber = 1;
    }

    public Fractions(int top)
    {
        topNumber = top;
        bottomNumber = 1;
    }

    public Fractions(int top, int bottom)
    {
        topNumber = top;
        bottomNumber = bottom;
    }

    public string getFractionString()
    {
        string fraction = $"{topNumber}/{bottomNumber}";
        return fraction;
    }

    public double getDecimalValue()
    {
        return (double)topNumber / (double)bottomNumber;
    }
}