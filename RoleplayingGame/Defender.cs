using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    public class Defender : Character
    {
        public Defender(string name, int maxHitPoints, int minDamage, int maxDamage) : base(name, maxHitPoints, minDamage, maxDamage)
        {
        }

        protected override int ReceiveDamageModifyChance
        {
            get { return 45; }
        }

        protected override int CalculateModifedReceivedDamage(int receivedDamage)
        {
            return receivedDamage / 2;
        }
    }
}
