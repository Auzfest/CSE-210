public class MathAssignment : Assignment
{
    private string textbookSection;
    private string problems;

    public MathAssignment(string studentName, string topic, string newTextbookSection, string newProblems) : base(studentName, topic)
    {
        textbookSection = newTextbookSection;
        problems = newProblems;
    }

    public string GetMathHomeworkList()
    {
        return "Section: " + textbookSection + "Problems: " + problems;
    }
}