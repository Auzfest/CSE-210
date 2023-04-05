public class GetRank
{
    public void rank(int totalEnemies)
    {
        if (totalEnemies <= 5)
        {
            Console.WriteLine("You're ranked at Rookie!");
        }
        else if (totalEnemies >= 5 && totalEnemies <= 10)
        {
            Console.WriteLine("You're ranked at Battle-Hardened!");
        }
        else if (totalEnemies >= 11 && totalEnemies <= 20)
        {
            Console.WriteLine("You're ranked at Knight!");
        }
        else if (totalEnemies >= 21 && totalEnemies <= 30)
        {
            Console.WriteLine("You're ranked at Captain!");
        }
        else if (totalEnemies >= 31 && totalEnemies <= 49)
        {
            Console.WriteLine("You're ranked at General!");
        }
        else
        {
            Console.WriteLine("You're ranked at the highest honor of LEGEND!");
        }
    }
}