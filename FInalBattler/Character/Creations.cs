namespace FinalBattler.Character
{
	public class Creations
	{
		public string Name { get; set; } = string.Empty;
		public int Level { get; set; }
		public int TotalHealth { get; set; }
		public int TotalPower { get; set; }
		public int TotalLuck { get; set; }
		public int TotalMana { get; set; }
		public virtual void Attack()
		{

		}
	}

	public enum CombatClass
	{
		None,
		Warrior,
		Wizard,
		Rogue
	}
	public enum MonsterType
	{
		None,
		Goblin,
		Ogre,
		Dragon
	}
}
