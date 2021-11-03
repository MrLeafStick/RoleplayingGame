using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGameV2.Participants.Creatures
{
    public class CreatureBase : ParticipantBase
    {
        public const int MaxInitialItem = 3;

        public CreatureBase(int maxInitialHealthPoints, double maxDamage) 
            : base(maxInitialHealthPoints, 0, MaxInitialItem, maxDamage, "")
        {
        }

        public override string Name
        {
            get { return nameof(CreatureBase); }
        }
    }
}
