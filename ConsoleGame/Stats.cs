namespace ConsoleGame
{
    public abstract class Stats
    {
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int ArmorClass { get; set; }
        public int AttackPoints { get; set; }
        public bool isAlive { get; set; }
        public int Coins { get; set; }
    }
}