using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Participants.Creatures
{
    public class Snake : CreatureBase
    {
        public const int MaxInitialHealthPoints = 40;
        public const int MaxDamage = 10;

        public Snake() : base(MaxInitialHealthPoints, MaxDamage)
        {
        }
    }
}
