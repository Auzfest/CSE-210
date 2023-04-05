public class EnemyGenerator : Combat
{
public void getGoblin(List<string> newEnemy)
{
    Console.WriteLine("Your foe is a goblin!");
    Console.WriteLine("");
    Thread.Sleep(1000);
    if (newEnemy.Count == 0)
    {
        newEnemy.Add("goblin");
        newEnemy.Add("20");
        newEnemy.Add("2|5");
    }
    else
    {
        newEnemy.RemoveRange(0,2);
        newEnemy.Add("goblin");
        newEnemy.Add("20");
        newEnemy.Add("2|5");
    }
}
public void getHobgoblin(List<string> newEnemy)
{
    Console.WriteLine("Your foe is a hobgoblin!");
    Console.WriteLine("");
    Thread.Sleep(1000);
    if (newEnemy.Count == 0)
    {
        newEnemy.Add("hobgoblin");
        newEnemy.Add("25");
        newEnemy.Add("4|8");        
    }
    else
    {
    newEnemy.RemoveRange(0,2);
    newEnemy.Add("hobgoblin");
    newEnemy.Add("25");
    newEnemy.Add("4|8");
    }

}
public void getOrc(List<string> newEnemy)
{
    Console.WriteLine("Your foe is an orc!");
    Console.WriteLine("");
    Thread.Sleep(1000);
    if (newEnemy.Count == 0)
    {
    newEnemy.Add("Orc");
    newEnemy.Add("30");
    newEnemy.Add("6|12");
    }
    else
    {
    newEnemy.RemoveRange(0,2);
    newEnemy.Add("Orc");
    newEnemy.Add("30");
    newEnemy.Add("6|12");
    }
}

}