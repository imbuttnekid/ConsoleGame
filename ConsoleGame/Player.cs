namespace ConsoleGame
{
	public class Player : Stats
	{
		public Player(string name = null, int hitPoints = 0, int armorClass = 0, int attackPoints = 0)
		{
			Name = name;
			HitPoints = hitPoints;
			ArmorClass = armorClass;
			AttackPoints = attackPoints;
		}
	}
}
