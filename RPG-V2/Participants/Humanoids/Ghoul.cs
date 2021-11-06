using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Participants.Humanoids
{
    public class Ghoul : HumanoidBase
    {
        public const int MAX_INITIAL_HEALTH_POINTS = 200;
        public const int MAX_DAMAGE = 80;

        public Ghoul(string name) : base(name, MAX_INITIAL_HEALTH_POINTS, MAX_DAMAGE)
        {
        }
    }
}
