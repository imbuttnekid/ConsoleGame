namespace ConsoleGame
{
	public class Player : Stats
	{
		public string Name { get; set; }
		public int HitPoints { get; set; }
		public int ArmorClass { get; set; }
		public int AttackPoints { get; set; }

		public Player(string name = null, int hitPoints = 0, int armorClass = 0, int attackPoints = 0)
		{
			Name = name;
			HitPoints = hitPoints;
			ArmorClass = armorClass;
			AttackPoints = attackPoints;
		}
	}
}
