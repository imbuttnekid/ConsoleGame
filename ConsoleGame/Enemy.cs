namespace ConsoleGame
{
    public class Enemy : Stats
    {
        public Enemy(string name = null, int hitPoints = 0, int armorClass = 0, int attackPoints = 0, int potions = 0)
        {
            Name = name;
            HitPoints = hitPoints;
            ArmorClass = armorClass;
            AttackPoints = attackPoints;
            Potions = potions;
        }
    }
}