namespace ConsoleGame
{
    public class Enemy : Stats
    {
        public Enemy(string name = null, int hitPoints = 0, int armorClass = 0, int attackPoints = 0, bool alive = true, int coins = 0)
        {
            Name = name;
            HitPoints = hitPoints;
            ArmorClass = armorClass;
            AttackPoints = attackPoints;
            isAlive = alive;
            Coins = coins;
        }
    }
}