using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Participants.Creatures
{
    public class Snake : CreatureBase
    {
        public const int MaxInitialHealthPoints = 70;
        public const int MaxDamage = 25;

        public Snake() : base(MaxInitialHealthPoints, MaxDamage)
        {
        }
    }
}
