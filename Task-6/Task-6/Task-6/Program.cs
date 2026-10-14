using System;
using System.Threading;

namespace AdventureGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== ADVENTURE GAME =====");

            Warrior warrior = new Warrior("Alex", 80);
            Wizard wizard = new Wizard("Luna", 70);


            GameCharacter[] characters =
            {
                warrior,
                wizard
            };


            foreach (GameCharacter character in characters)
            {
                Console.WriteLine();

                character.UseSpecialAbility();

                character.TakeDamage(10);

                character.DisplayHealth();
            }


            Console.WriteLine();

            warrior.Heal();

            Console.WriteLine();

            warrior.Heal(15);


            Console.WriteLine();

            HealthPotion potion = new HealthPotion();

            potion.PotionName = "Health Potion";

            potion.Collect();


            Console.WriteLine();

            potion.Use(wizard, "15");


            Console.WriteLine();

            potion.Use(wizard, "abc");
        }
    }
}