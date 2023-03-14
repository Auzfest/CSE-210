public class Assignment
{
    private string studentName;
    private string topic;

    public Assignment(string newStudentName, string newTopic)
    {
        studentName = newStudentName;
        topic = newTopic;
    }

    public string GetSummary()
    {
        return studentName + " - " + topic;
    }

    public string getStudentName()
    {
        return studentName;
    }
}