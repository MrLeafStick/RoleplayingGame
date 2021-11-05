using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Participants.Humanoids
{
    public class HumannoidBase : ParticipantBase
    {
        public const int MAX_INITIAL_GOLD = 50;
        public const int MAX_INITIAL_ARMOR = 3;
        public const int MAX_INITIAL_WEAPON = 1;

        public HumannoidBase(string name, int maxInitialHealthPoints, double maxDamage) 
            : base(maxInitialHealthPoints, MAX_INITIAL_GOLD, MAX_INITIAL_ARMOR, MAX_INITIAL_WEAPON, maxDamage, name)
        {
        }
    }
}
