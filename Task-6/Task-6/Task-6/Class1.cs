using System;

namespace AdventureGame
{
    abstract class GameCharacter
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        protected int Health { get; set; }

        public GameCharacter(string name, int health)
        {
            Name = name;

            if (health > 100)
                Health = 100;
            else if (health < 0)
                Health = 0;
            else
                Health = health;
        }

        public abstract void UseSpecialAbility();

        public virtual void TakeDamage(int amount)
        {
            Health = Health - amount;

            if (Health < 0)
                Health = 0;

            Console.WriteLine(Name + " takes " + amount + " damage.");
        }

        public void Heal()
        {
            Health = Health + 10;

            if (Health > 100)
                Health = 100;

            Console.WriteLine(Name + " heals 10 points.");
            Console.WriteLine(Name + "'s health: " + Health);
        }

        public void Heal(int amount)
        {
            Health = Health + amount;

            if (Health > 100)
                Health = 100;

            Console.WriteLine(Name + " heals " + amount + " points.");
            Console.WriteLine(Name + "'s health: " + Health);
        }

        public void DisplayHealth()
        {
            Console.WriteLine(Name + "'s health: " + Health);
        }
    }


    class Warrior : GameCharacter
    {
        public Warrior(string name, int health)
            : base(name, health)
        {
        }

        public override void UseSpecialAbility()
        {
            Console.WriteLine("The Warrior attacks with a sword!");
        }

        public override void TakeDamage(int amount)
        {
            int damage = amount - 2;

            if (damage < 0)
                damage = 0;

            Health = Health - damage;

            if (Health < 0)
                Health = 0;

            Console.WriteLine(Name + " takes " + damage + " damage.");
        }
    }


    class Wizard : GameCharacter
    {
        public Wizard(string name, int health)
            : base(name, health)
        {
        }

        public override void UseSpecialAbility()
        {
            Console.WriteLine("The Wizard uses magic!");
        }

        public override void TakeDamage(int amount)
        {
            Health = Health - amount;

            if (Health < 0)
                Health = 0;

            Console.WriteLine(Name + " takes " + amount + " damage.");
        }
    }


    interface ICollectible
    {
        void Collect();
    }


    class HealthPotion : ICollectible
    {
        public string PotionName { get; set; }

        public void Collect()
        {
            Console.WriteLine("Health Potion collected!");
        }

        public void Use(GameCharacter character, string amountText)
        {
            try
            {
                int amount = Convert.ToInt32(amountText);

                character.Heal(amount);
            }
            catch
            {
                Console.WriteLine("Invalid input! Please enter a number.");
            }
        }
    }
}