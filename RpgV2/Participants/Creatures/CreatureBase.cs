using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Participants.Creatures
{
    public class CreatureBase : ParticipantBase
    {
        public const int MaxInitialItems = 3;

        public CreatureBase(int maxInitialHealthPoints,  double maxDamage) 
            : base(maxInitialHealthPoints, 0, MaxInitialItems, maxDamage, "")
        {
        }

        public override string Name
        {
            get { return GetType().Name;  }
        }
    }
}
