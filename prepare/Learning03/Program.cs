using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fractions firstFraction = new Fractions();
        Console.WriteLine(firstFraction.getFractionString());
        Console.WriteLine(firstFraction.getDecimalValue());

        Fractions sceondFraction = new Fractions(5);
        Console.WriteLine(sceondFraction.getFractionString());
        Console.WriteLine(sceondFraction.getDecimalValue());

        Fractions thirdFraction = new Fractions(3,4);
        Console.WriteLine(thirdFraction.getFractionString());
        Console.WriteLine(thirdFraction.getDecimalValue());

        Fractions fourthFraction = new Fractions(1,3);
        Console.WriteLine(fourthFraction.getFractionString());
        Console.WriteLine(fourthFraction.getDecimalValue());
    }
}