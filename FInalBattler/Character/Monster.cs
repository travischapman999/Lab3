using FinalBattler.Interfaces;
namespace FinalBattler.Character
{
    public class Monster :Creations
    {
        public MonsterType TypeOfMonster { get; set; }
        public List<string> MonsterNames { get; set; } = new List<string>
        {
            "Charles",
            "Boblin",
            "Florpis",
            "Globgor",
            "Harold",
			"Grinx",
			"Kelangu",
			"Mazhi",
			"Hangues",
			"Tatwanee",
			"Borokappa",
			"Azhiwaque"
		};
        public Random random { get; set; } = new Random();
        public virtual int CalculateDamage()
        {
            return 0;
        }
    }
    public class Goblin : Monster, IDamageCalculator
    {
         
        public Goblin()
        {
            TypeOfMonster = MonsterType.Goblin;
            TotalPower = 3;
            TotalHealth = random.Next(5, 8);
            Name = MonsterNames[random.Next(1, MonsterNames.Count)];
        }
        public override int CalculateDamage()
        {
            return TotalPower;
        }
    }
    public class Ogre : Monster, IDamageCalculator
    {
        public Ogre()
        {
            TypeOfMonster = MonsterType.Ogre;
            TotalPower = 5;
            TotalHealth = random.Next(10, 20);
            Name = MonsterNames[random.Next(1, MonsterNames.Count)];
        }
        public override int CalculateDamage()
        {
            return TotalPower;
        }
    }
    public class Dragon : Monster, IDamageCalculator
    {
        public Dragon()
        {
            TypeOfMonster = MonsterType.Dragon;
            TotalPower = 15;
            TotalHealth = random.Next(25, 50);
            Name = MonsterNames[random.Next(1, MonsterNames.Count)];
        }
        public override int CalculateDamage()
        {
            return TotalPower;
        }
    }
}
