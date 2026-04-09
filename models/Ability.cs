using System;

namespace pp7_heroengine_oop_quest_yoon_lpz.models
{
    public class Ability
    {
        private int _power;
        private float _cost;
        private string _name;
        private abilityType _type;
        private rarity _rarity;

        private string[] nameList = new string[0];
        private string[] auxList;

        public string Name {
            get => _name;
            set { if (Tools.isValidString(value) && nameList.Contains(value.Trim())) {
                    _name = value.Trim();
                    auxList = new string[nameList.Length + 1];
                    for (int i = 0; i < nameList.Length; i++) {
                        auxList[i] = nameList[i];
                    }
                    auxList[auxList.Length - 1] = value.Trim();
                    nameList = auxList;
                }
            }
        }
        public abilityType Type { get => _type; set => _type = value;}
        public rarity Rarity { get => _rarity; set => _rarity = value;}
        public float Cost { get =>  _cost; set {if (value >= 0) _cost = value;}}
        public int Power { get => _power; set { if (Tools.isNaturalNumber(value)) _power = value; } }

        public Ability(string name, abilityType type, rarity rarity, float cost, int power)
        {
            Name = name;
            Type = type;
            Rarity = rarity;
            Cost = cost;
            Power = power;
        }
    }
}
