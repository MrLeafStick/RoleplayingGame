using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Participants.Creatures
{
    public class Snake : CreatureBase
    {
        public const int MAX_INITIAL_HEALTH_POINTS = 70;
        public const int MELEE_MAX_DAMAGE = 25;

        public Snake() : base(MAX_INITIAL_HEALTH_POINTS, MELEE_MAX_DAMAGE)
        {
        }
    }
}
