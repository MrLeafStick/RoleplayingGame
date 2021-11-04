using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Participants.Creatures
{
    public class CreatureBase : ParticipantBase
    {
        public const int MaxInitialItems = 3;

        public CreatureBase(int maxInitialHealthPoints, double maxDamage)
            : base(maxInitialHealthPoints, 0, MaxInitialItems, maxDamage, "")
        {
        }

        public override string Name
        {
            get { return GetType().Name; }
        }
    }
}
