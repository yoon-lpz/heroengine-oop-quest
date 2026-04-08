using System;

namespace pp7_heroengine_oop_quest_yoon_lpz.ui
{
    public class Messages
    {
        public const string heroString = "[{0}] {1} | Level: {2} | HP: {3}/{4}";
        public const string warriorString = " | Armor: {0}";
        public const string warriorPresentation = "Battle cry: {0}";

        public const string attack = "{0} attacks! Deals {1} damage";
        public const string takeDamage = "{0} receives {1} damage";
        public const string takeDamageHP = " | HP: {0}/{1}";
        public const string takeDamageArmor = " -> absorbed {0} by armor -> net damage: {1}";
        public const string defeated = "{0} is already defeated.";
    }
}
