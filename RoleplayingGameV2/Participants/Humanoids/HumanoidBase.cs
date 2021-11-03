using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGameV2.Participants.Humanoids
{
    public class HumanoidBase : ParticipantBase
    {
        public HumanoidBase(int maxInitialHealthPoints, int maxInitialGold, int maxInitialItems, double maxDamage, string name) : base(maxInitialHealthPoints, maxInitialGold, maxInitialItems, maxDamage, name)
        {
        }
    }
}
