using pp7_heroengine_oop_quest_yoon_lpz.ui;
using System;

namespace pp7_heroengine_oop_quest_yoon_lpz.models
{
    public class Mage : Hero
    {
        private int _mana = 50, _arkLevel = 1;
        private Ability[] _abilities = new Ability[0];
        private Ability[] aux;

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

        public Mage(string name, int health, int mana, int arkLevel) : base(name, health)
        {
            Mana = mana;
            ArkLevel = arkLevel;
        }

        /// <summary>
        /// Adds a new <paramref name="ability"/> to the current Hero. If it's repeated, it doesn't add.
        /// </summary>
        /// <param name="ability">Ability to be added.</param>
        public void AddAbility(Ability ability) {
            if (!_abilities.Contains(ability))
            {
                aux = _abilities;
                for (int i = 0; i < _abilities.Length; i++)
                {
                    aux[i] = _abilities[i];
                }
                aux[aux.Length - 1] = ability;
                _abilities = aux;
            } else Console.WriteLine(String.Format(Messages.abilityRepeated, Name, ability));
        }

        /// <summary>
        /// Prints on screen a list of the known abilities by the current Hero.
        /// </summary>
        public void ShowAbilities()
        {
            Console.WriteLine(Messages.spacer);
            Console.WriteLine(String.Format(Messages.showAbilitiesTitle, Name));
            Console.WriteLine(Messages.spacer);

            if (_abilities.Length == 0) Console.WriteLine(String.Format(Messages.noAbilities, Name));
            else
            {
                foreach (Ability ability in _abilities)
                {
                    Console.WriteLine(String.Format(Messages.showAbilities, $"[{ability.Rarity}]".PadRight(13), ability.Name.PadRight(20), $"{ability.Type}".PadRight(10), $"{ability.Cost}".PadLeft(3)));
                }
                Console.WriteLine(Messages.spacer);
            }
        }

        public void UseAbility(Ability ability, Hero hero)
        {
            if (!_abilities.Contains(ability)) Console.WriteLine(String.Format(Messages.notKnowAbility, Name, ability));
            else
            {
                switch(ability.Type)
                {
                    case abilityType.Attack:

                        return;
                }
            }
        }
    }
}
