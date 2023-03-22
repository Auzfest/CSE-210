public abstract class Shape
{
    private string newColor;


    public Shape(string color)
    {
        newColor = color;
    }

    public string GetColor()
    {
        return newColor;
    }

    public void SetColor(string color)
    {
        newColor = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }
}