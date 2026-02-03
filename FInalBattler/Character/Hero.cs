using FinalBattler.Character.Upgrades;
using FinalBattler.Interfaces;

namespace FinalBattler.Character
{
    public class Hero : Creations, IHero
    {
        public int Health { get; set; }
        public int Power { get; set; }
        public int Luck { get; set; }
        public int Mana { get; set; }
        public int ExperienceRemaining { get; set; }
        public CombatClass CombatClass { get; set; }
        public List<Item> Items { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Spell> Spells { get; set; }
        public List<Equipment> Equipment { get; set; } = new List<Equipment>();
        public void DisplayStats(bool showTotalStats)
        {
            if (showTotalStats)
            {
                CalculateTotals();
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Class: {CombatClass}");
                Console.WriteLine($"Level: {Level}");
                Console.WriteLine($"Health: {TotalHealth}");
                Console.WriteLine($"Power: {TotalPower}");
                Console.WriteLine($"Luck: {TotalLuck}");
                Console.WriteLine($"Mana: {TotalMana}");
            }
            else
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Class: {CombatClass}");
                Console.WriteLine($"Level: {Level}");
                Console.WriteLine($"Health: {Health}");
                Console.WriteLine($"Power: {Power}");
                Console.WriteLine($"Luck: {Luck}");
                Console.WriteLine($"Mana: {Mana}");
            }
        }
        public void LevelUp()
        {
            Level++;
            Random random = new Random();
            switch (CombatClass)
            {
                case CombatClass.Warrior:
                    Health += random.Next(10, 20);
                    Power += random.Next(1, 3);
                    Luck += random.Next(1, 3);
                    Mana += random.Next(1, 5);
                    break;
                case CombatClass.Wizard:
                    Health += random.Next(1, 15);
                    Power += random.Next(3, 5);
                    Luck += random.Next(1, 3);
                    Mana += random.Next(3, 8);
                    break;
                case CombatClass.Rogue:
                    Health += random.Next(1, 15);
                    Power += random.Next(1, 3);
                    Luck += random.Next(3, 5);
                    Mana += random.Next(1, 5);
                    break;
            }
        }
        public void CalculateTotals()
        {
            TotalHealth = Health;
            TotalPower = Power;
            TotalLuck = Luck;
            TotalMana = Mana;
            foreach(Equipment equipment in Equipment)
            {
                switch (equipment.StatBoosted)
                {
                    case StatBoostType.Power:
                        TotalPower = Power + equipment.BoostValue;
                        break;
                    case StatBoostType.Luck:
                        TotalLuck = Luck + equipment.BoostValue;
                        break;
                    case StatBoostType.Mana:
                        TotalMana = Mana + equipment.BoostValue;
                        break;
                    case StatBoostType.Health:
                        TotalHealth = Health + equipment.BoostValue;
                        break;
                }
            }
        }
        public void Equip(Equipment equipment)
        {
            Equipment.Add(equipment);
        }
        public void DisplayEquipment()
        {
            foreach (Equipment equipment in Equipment)
            {
                Console.WriteLine($"{equipment.EquipmentName} : +{equipment.BoostValue} {equipment.StatBoosted}");
            }
        }

        public Hero()
        {
            Name = "Unknown";
            Console.WriteLine("Pick your class(as number)");
            int i = 0;
            foreach(CombatClass combatClass in Enum.GetValues<CombatClass>())
            {
                Console.WriteLine($"{i}: {combatClass}");
                i++;
            }
            CombatClass = (CombatClass)int.Parse(Console.ReadLine());
            Level = 0;
            Health = 1;
            Power = 1;
            Luck = 1;
            Mana = 1;
        }
    }
}
