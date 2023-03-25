public class CheckListGoals : Goal
{
    private string newGoal;
    public override void makeNewGoal(int chosen, List<string> listOfGoals, int level, int points)
    {
        if (listOfGoals.Count == 0)
        {
            listOfGoals.Insert(0, $"{level}|{points}");
        }
        Console.Write("What is your goal?: ");
        string goalChoice = Console.ReadLine();
        Console.Write("describe it: ");
        string descriptionChoice = Console.ReadLine();
        Console.Write("How many points is it worth each time?: ");
        string pointsChoice = Console.ReadLine();
        Console.Write("How many times will this be done?: ");
        string howManyTimesChoice = Console.ReadLine();

        newGoal = string.Format($"CHECKLIST| {goalChoice} | {descriptionChoice} | 0|{howManyTimesChoice}");
        listOfGoals.Add(newGoal);
        listOfGoals.Add(pointsChoice);
    }

    public override string recordEvent(int chosen, List<string> listOfGoals, int level, int points)
    {
        string[] parts = listOfGoals[chosen].Split("|");

        string timesDone = parts[3];
        int newDoneTotal = int.Parse(timesDone);
        string TotalTimes = parts[4];
        int TotalTimesRequired = int.Parse(TotalTimes);
        newDoneTotal += 1;

        listOfGoals[chosen] = $"{parts[0]}| {parts[1]} | {parts[2]} | {newDoneTotal}|{parts[4]}";

        chosen += 1;
        int newPoints = int.Parse(listOfGoals[chosen]);
        points += newPoints;
        int dividedPoints = points / 500;
        level += dividedPoints;

        string newLevel = $"{level}|{points}";
        if (newDoneTotal == TotalTimesRequired)
        {
            listOfGoals[chosen] = "COMPLETE";
        }
        return newLevel;
        
    }
}