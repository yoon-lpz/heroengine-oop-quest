using System;

namespace pp7_heroengine_oop_quest_yoon_lpz.models
{
    public class Mage: Hero
    {
        private int _mana = 50;
        private int _arkLevel = 1;

        public int Mana
        {
            get => _mana;
            set { if (Tools.isNaturalNumber(value)) _mana = value; }
        }

        public int ArkLevel
        {
            get => _arkLevel;
            set { if (Tools.isNaturalNumber(value)) _arkLevel = value; }
        }

        public Mage(string name, int level, int health, int mana, int arkLevel) : base(name, level, health)
        {
            Mana = mana;
            ArkLevel = arkLevel;
        }
    }
}
