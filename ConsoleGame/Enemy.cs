namespace ConsoleGame
{
    public class Enemy : Stats
    {
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int ArmorClass { get; set; }
        public int AttackPoints { get; set; }

        public Enemy(string name = null, int hitPoints = 0, int armorClass = 0, int attackPoints = 0)
        {
            Name = name;
            HitPoints = hitPoints;
            ArmorClass = armorClass;
            AttackPoints = attackPoints;
        }
    }
}