public class EnemyHitpointRandomizer : HitpointRandomizer
{
        private List<string> enemyHitOrMiss = new List<string>();

        public EnemyHitpointRandomizer()
    {
        enemyHitOrMiss.Add("hit");
        enemyHitOrMiss.Add("block");
        enemyHitOrMiss.Add("hit");
        enemyHitOrMiss.Add("block");
    }

    public string getRandomHitOrMiss(string weaponDamage)
    {
        string[] hitPoints = weaponDamage.Split("|");
 
        Random randomGenerator = new Random();
        int random_prompt = randomGenerator.Next(0, 3);
        if (enemyHitOrMiss[random_prompt] == "hit")
        {
            Console.WriteLine("It hit you!");
            int randomHit = randomGenerator.Next(0,1);
            weaponDamage = hitPoints[randomHit];     
            Console.WriteLine($"Dealt {weaponDamage} damage!");
            return weaponDamage;
        }
        else if (enemyHitOrMiss[random_prompt] == "block")
        {
            Console.WriteLine("You blocked it!");
            Thread.Sleep(1000);
        }
        return "0";
    }
}