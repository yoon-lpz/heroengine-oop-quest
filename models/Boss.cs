using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp7_heroengine_oop_quest_yoon_lpz.models
{
    public class Boss : Enemy
    {
        public Boss() : base()
        {
            Health = 100;
            Strength = 30;
        }
    }
}
