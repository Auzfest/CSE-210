public class WritingAssignment : Assignment
{
    private string title;

    public WritingAssignment(string studentName, string topic, string newTitle) : base(studentName, topic)
    {
        title = newTitle;
    }

    public string GetWritingHomeworkList()
    {
        string studentName =getStudentName();

        return title + " by " + studentName;
    }
}