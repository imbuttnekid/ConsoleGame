namespace ConsoleGame
{
    public interface Stats
    {
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int ArmorClass { get; set; }
        public int AttackPoints { get; set; }
    }
}