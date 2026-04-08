using System;

namespace pp7_heroengine_oop_quest_yoon_lpz.models
{
    public class Rogue: Hero
    {
        private float _harmMultiplier = 1;
        private int _hiddenBlades = 0;

        public float HarmMultiplier
        {
            get => _harmMultiplier;
            set { if (value >= 0)  _harmMultiplier = value; }
        }

        public int HiddenBlades
        {
            get => _hiddenBlades;
            set { if (value >= 0) _hiddenBlades = value; }
        }

        public Rogue(string name, int level, int health, float harmMultiplier, int hiddenBlades) : base(name, level, health)
        {
            HarmMultiplier = harmMultiplier;
            HiddenBlades = hiddenBlades;
        }
    }
}
