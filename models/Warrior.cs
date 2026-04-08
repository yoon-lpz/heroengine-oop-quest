using System;

namespace pp7_heroengine_oop_quest_yoon_lpz.models
{
    public class Warrior : Hero
    {
        private int _armor = 2;
        private string _warCry = "Default war cry";

        public int Armor {
            get => _armor;
            set { if (Tools.isNaturalNumber(value)) _armor = value; }
        }
        public string WarCry
        {
            get => _warCry;
            set { if (Tools.isValidString(value, 8)) _warCry = value; }
        }

        public Warrior(string name, int level, int health, int armor, string warCry) : base(name, level, health)
        {
            Armor = armor;
            WarCry = warCry;
        }
    }
}
