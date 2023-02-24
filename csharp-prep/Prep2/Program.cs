using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int grade_percentage = int.Parse(input);

        Console.WriteLine("your grade is an: ");

        if (grade_percentage >= 90)
        {
            Console.WriteLine("A"); 
        }
        else if (grade_percentage >= 80)
        {
            Console.WriteLine("B");
        }
        else if (grade_percentage >= 70)
        {
            Console.WriteLine("C");
        }
        else if (grade_percentage >= 60)
        {
            Console.WriteLine("D");
        }
        else if (grade_percentage < 60)
        {
            Console.WriteLine("F");
        }
        else
        {
            
        }
    }
     
}