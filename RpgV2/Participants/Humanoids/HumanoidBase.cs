using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Participants.Humanoids
{
    public class HumanoidBase : ParticipantBase
    {
        public const int MAX_INITIAL_GOLD = 50;
        public const int MAX_INITIAL_ARMOR = 2;
        public const int MAX_INITIAL_WEAPONS = 2;

        public HumanoidBase(string name, int maxInitialHealthPoints, double maxDamage) : base(maxInitialHealthPoints, MAX_INITIAL_GOLD, MAX_INITIAL_ARMOR,MAX_INITIAL_WEAPONS, maxDamage, name)
        {

        }
    }
}
