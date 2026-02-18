using System.Reflection.Metadata.Ecma335;
using FinalBattler.Character;
using FinalBattler.Interfaces;

namespace FinalBattler.GamePlay
{
    public static class Combat
    {
        public static void Battle(Hero hero1,  Hero hero2)
        {
            while(hero1.TotalHealth > 0 && hero2.TotalHealth > 0)
            {
                hero2.TotalHealth -= hero1.CalculateDamage();
                if (hero2.TotalHealth < 0) hero2.TotalHealth = 0;
				Console.WriteLine($"{hero2.Name} health: {hero2.TotalHealth}");
				hero1.TotalHealth -= hero2.CalculateDamage();
                if (hero1.TotalHealth < 0) hero1.TotalHealth = 0;
				Console.WriteLine($"{hero1.Name} health: {hero1.TotalHealth}");
			}
            if (hero1.TotalHealth <= 0)
            {
                if (hero2.TotalHealth <= 0)
                {
                    Console.WriteLine("It's a tie");
                }
                Console.WriteLine($"{hero2.Name} wins");
            }
            if (hero2.TotalHealth <= 0) {
                Console.WriteLine($"{hero1.Name} wins");
            }
            hero1.CalculateTotals();
            hero2.CalculateTotals();
        }
        public static void Battle(Hero hero,  Monster monster)
        {
            while(hero.Health > 0 && monster.TotalHealth > 0)
            {
                monster.TotalHealth -= hero.CalculateDamage();
                Console.WriteLine($"{monster.Name} the {monster.TypeOfMonster} health: {monster.TotalHealth}");
                hero.Health -= monster.CalculateDamage();
                Console.WriteLine($"{hero.Name} health: {hero.TotalHealth}");
            }
            if (hero.Health < 0)
            {
                if (monster.TotalHealth < 0)
                {
                    Console.WriteLine("It's a tie");
                }
                Console.WriteLine($"{monster.Name} the {monster.TypeOfMonster} wins");
            }
            if (monster.TotalHealth < 0) {
                Console.WriteLine($"{hero.Name} wins");
            }
            hero.CalculateTotals();

        }
    }
}
