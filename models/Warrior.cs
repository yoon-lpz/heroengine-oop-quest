using pp7_heroengine_oop_quest_yoon_lpz.ui;
using System;

namespace pp7_heroengine_oop_quest_yoon_lpz.models
{
    public class Warrior : Hero
    {
        private int _armor = 2;
        private string _battleCry = "Default battle cry";

        public int Armor {
            get => _armor;
            set { if (Tools.isNaturalNumber(value)) _armor = value; }
        }
        public string BattleCry
        {
            get => _battleCry;
            set { if (Tools.isValidString(value, 8)) _battleCry = value; }
        }

        public Warrior(string name, int level, int health, int armor, string battleCry) : base(name, level, health)
        {
            Armor = armor;
            BattleCry = battleCry;
        }

        public override string ToString() => base.ToString() +  String.Format(Messages.warriorString, Armor);

        public override void Present()
        {
            base.Present();
            Console.WriteLine(String.Format(Messages.warriorPresentation, BattleCry));
        }
    }
}
