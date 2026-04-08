using System;
using pp7_heroengine_oop_quest_yoon_lpz.interfaces;
using pp7_heroengine_oop_quest_yoon_lpz.ui;

namespace pp7_heroengine_oop_quest_yoon_lpz.models
{
    public abstract class Hero : ICombat, IPresentable
    {
        private int _level = 1, _health = 100, _maxHealth = 100, damage;
        private string _name = "Player";

        protected string Name {
            get => _name;
            set { if (Tools.isValidString(value)) _name = value; }
        }
        protected int Level
        {
            get => _level;
            set { _level = Math.Max(1, value); }
        }
        protected int Health
        {
            get => _health;
            set { _health = Math.Max(_health, value); }
        }
        protected int MaxHealth
        {
            get => _maxHealth;
            set { if (Tools.isNaturalNumber(value) && value >= Health) _maxHealth = value; }
        }

        protected Hero(string name, int level, int health)
        {
            Name = name;
            Level = level;
            Health = health;
            MaxHealth = health;
        }

        public virtual void Present()
        {
            Console.WriteLine(ToString());
        }

        public virtual void Attack(Hero hero)
        {
            if (Health > 0) {
                damage = 10 * Level;
                Console.WriteLine(String.Format(Messages.attack, Name, damage));
                hero.TakeDamage(damage);
            }
            else Console.WriteLine(String.Format(Messages.defeated, Name));
        }
        public virtual void TakeDamage(int damage) {
            if (Health > 0)
            {
                Health -= damage;

                Console.Write(String.Format(Messages.takeDamage, Name, damage));
                Console.WriteLine(String.Format(Messages.takeDamageHP, Health, MaxHealth));
            }
            else Console.WriteLine(String.Format(Messages.defeated, Name));
        }

        public override string ToString() => string.Format(Messages.heroString, this.GetType().Name, Name, Level, Health, MaxHealth);
    }
}
