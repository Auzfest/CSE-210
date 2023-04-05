public class Combat : Base
{
    private List<string> newEnemy = new List<string>();

    public string hitOrBlock(int weaponDamage)
    {
        HitpointRandomizer findWhatHappens = new HitpointRandomizer();
        string enemyHealthUpdate = findWhatHappens.getRandomHitOrMiss(newEnemy[1], weaponDamage);
        newEnemy[1] = enemyHealthUpdate;
        return enemyHealthUpdate;
    }

        public int EnemyhitOrBlock(int health)
    {
        EnemyHitpointRandomizer findWhatHappens = new EnemyHitpointRandomizer();
        string totalHitpointsTaken = findWhatHappens.getRandomHitOrMiss(newEnemy[2]);
        WeaponandHealth depleter = new WeaponandHealth();
        int newUserHealth = depleter.depleteHealth(health, totalHitpointsTaken);
        return newUserHealth;
    }
        public void getNewEnemy()
    {
        EnemyGenerator enemy = new EnemyGenerator();
        Random randomGenerator = new Random();
        int randomEnemy = randomGenerator.Next(1, 10);
        if (randomEnemy >= 1 && randomEnemy <= 5)
        {
            enemy.getGoblin(newEnemy);
        }
        else if (randomEnemy >= 6 && randomEnemy <= 8)
        {
            enemy.getHobgoblin(newEnemy);
        }
        else if (randomEnemy >= 9 && randomEnemy <= 10)
        {
            enemy.getOrc(newEnemy);
        }
    }
}