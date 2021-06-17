namespace ConsoleGame
{
    public class Player : Stats
    {
        public int Potions { get; private set; }

        public Player(string name = null, int hitPoints = 0, int armorClass = 0, int attackPoints = 0, bool alive = true, int coins = 0)
        {
            Name = name;
            HitPoints = hitPoints;
            ArmorClass = armorClass;
            AttackPoints = attackPoints;
            Potions = 1;
            isAlive = alive;
            Coins = coins;
        }
    }
}
