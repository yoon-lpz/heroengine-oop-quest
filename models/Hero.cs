using System;

namespace pp7_heroengine_oop_quest_yoon_lpz.models
{
    public abstract class Hero
    {
        private string _name;
        private int _level = 1;
        private int _health;

        public string Name {
            get => _name;
            set { if (Tools.isValidString(value)) _name = value; }
        }
        public int Level
        {
            get => _level;
            set => _level = value;
        }
        public int Health
        {
            get => _health;
            set { if (Tools.isNaturalNumber(value)) _health = value; }
        }

        protected Hero(string name, int level, int health)
        {
            Name = name;
            Level = level;
            Health = health;
        }
    }
}
