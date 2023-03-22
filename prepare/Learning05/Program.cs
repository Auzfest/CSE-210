using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>();

        Square squared = new Square("Red", 3);
        shapes.Add(squared);

        Rectangle rectangled = new Rectangle("Blue", 4, 5);
        shapes.Add(rectangled);

        Circle circled = new Circle("Green", 6);
        shapes.Add(circled);

        foreach (Shape obj in shapes)
        {

            string color = obj.GetColor();

            double area = obj.GetArea();

            Console.WriteLine($"The {color} shape's area is {area}!");
        }
    }
}