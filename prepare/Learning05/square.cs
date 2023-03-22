public class Square : Shape
{
    private double newSide;

    public Square(string color, double side) : base(color)
    {
        newSide = side;
    }

    public override double GetArea()
    {
        return newSide * newSide;
    }
}