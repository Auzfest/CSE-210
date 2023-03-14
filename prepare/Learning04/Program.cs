using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment Math1= new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(Math1.GetSummary());
        Console.WriteLine(Math1.GetMathHomeworkList());

        WritingAssignment writing1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingHomeworkList());
    }
}