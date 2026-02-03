

using FinalBattler.Character;
using FinalBattler.Character.Upgrades;

public class Program
{
    static void Main()
    {
        Hero hero1 = new Hero();
        Equipment hat = new Equipment("Hat of Luck", (EquipmentSlot) 0, (StatBoostType) 2, 3);
        hero1.LevelUp();
        hero1.Equip(hat);
        hero1.DisplayStats(false);
        hero1.DisplayStats(true);
        hero1.DisplayEquipment();
    }
}

