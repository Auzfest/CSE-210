public class Rectangle : Shape
{
    private double newLength;

    private double newWidth;

    public Rectangle(string color, double length, double width) : base (color)
    {
        newLength = length;
        newWidth = width;
    }

        public override double GetArea()
    {
        return newLength * newWidth;
    }
}