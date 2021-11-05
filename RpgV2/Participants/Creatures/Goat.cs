using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Participants.Creatures
{
    public class Goat : CreatureBase
    {
        public const int MAX_iNITIAL_HEALTH_POINTS = 25;
        public const int MELEE_MAX_DAMAGE = 20;

        public Goat(): base(MAX_iNITIAL_HEALTH_POINTS,MELEE_MAX_DAMAGE)
        {

        }


    }
}
