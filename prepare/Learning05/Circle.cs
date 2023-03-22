public class Circle : Shape
{
    private double newRadius;

    public Circle(string color, double radius) : base (color)
    {
        newRadius = radius;
    }

        public override double GetArea()
    {
        return newRadius * newRadius * Math.PI;
    }

}