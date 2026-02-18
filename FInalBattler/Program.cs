

using FinalBattler.Character;
using FinalBattler.Character.Upgrades;
using static FinalBattler.GamePlay.Combat;

public class Program
{
    static void Main()
    {
        Hero hero1 = new Hero();
        Hero hero2 = new Hero("Tbone120");
        Equipment hatOfLuck = new Equipment
        ("Hat of Luck", (EquipmentSlot) 0, (StatBoostType) 2, 3);
        hero1.Equip(hatOfLuck);
        hero1.DisplayStats(false);
        hero1.DisplayStats(true);
        hero1.DisplayEquipment();
        hero2.DisplayStats(false);
        hero2.DisplayStats(true);
        List<Monster> monsters = new List<Monster>
        {
            new Goblin(),
            new Goblin(),
            new Goblin(),
            new Goblin(),
            new Dragon()
        };
        foreach (Monster monster in monsters)
        {
            Console.WriteLine($"{monster.Name} the {monster.TypeOfMonster}");
        }
        Battle(hero1, hero2);
        //Battle(hero1, monsters[1]);
    }
}