public class HitpointRandomizer : Combat
{
    private List<string> userHitOrMiss = new List<string>();

        public HitpointRandomizer()
    {
        userHitOrMiss.Add("hit");
        userHitOrMiss.Add("hit");
        userHitOrMiss.Add("hit");
        userHitOrMiss.Add("block");
    }

        public virtual string getRandomHitOrMiss(string enemyHealth, int weaponDamage)
    {
        Random randomGenerator = new Random();
        int random_prompt = randomGenerator.Next(0, 3);
        if (userHitOrMiss[random_prompt] == "hit")
        {
            Console.WriteLine("You hit it!");
            int enemysHealth = int.Parse(enemyHealth); 
            int enemyDepletedHealth = enemysHealth - weaponDamage; 
            string depletedHealth = $"{enemyDepletedHealth}";          
            Console.WriteLine($"Dealt {weaponDamage} damage!");
            return depletedHealth;

        }
        else if (userHitOrMiss[random_prompt] == "block")
        {
            Console.WriteLine("It blocked you!");
            Console.WriteLine("");
            Thread.Sleep(1000);
        }
        return enemyHealth;
    }
}