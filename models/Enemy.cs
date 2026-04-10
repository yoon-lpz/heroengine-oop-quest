using System;

namespace pp7_heroengine_oop_quest_yoon_lpz.models
{
    public abstract class Enemy
    {
        private int _health, _maxHealth, _strength;

        protected int Health
        {
            get => _health;
            set
            {
                if (value > 0 && MaxHealth == 0) _health = value; MaxHealth = value ;
                else if (value < 0) _health = 0;
                else _health = Math.Min(MaxHealth, value);
            }
        }

        protected int MaxHealth
        {
            get => _maxHealth;
            set { if (value >= Health) _maxHealth = value; }
        }

        protected int Strength
        {
            get => _strength;
            set { if (Tools.isNaturalNumber(value)) _strength = value; }
        }
    }
}
