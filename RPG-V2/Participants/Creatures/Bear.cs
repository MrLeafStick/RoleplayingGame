using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Participants.Creatures
{
    public class Bear : CreatureBase
    {
        public const int MaxInitialHealthPoints = 70;
        public const int MaxDamage = 25;

        public Bear() : base(MaxInitialHealthPoints, MaxDamage)
        {
        }
    }
}
