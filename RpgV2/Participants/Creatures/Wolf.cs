using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Participants.Creatures
{
    public class Wolf : CreatureBase
    {
        public const int MAX_INITIAL_HEALTH_POINTS = 25;
        public const int MELEE_MAX_DAMAGE = 20;

        public Wolf() : base(MAX_INITIAL_HEALTH_POINTS, MELEE_MAX_DAMAGE)
        {
        }
    }
}
