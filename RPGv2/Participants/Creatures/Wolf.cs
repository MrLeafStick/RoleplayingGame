using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGv2.Participants.Creatures
{
    public class Wolf : CreatureBase
    {
        public const int MaxInitialHealthPoints = 60;
        public const int MaxDamage = 18;

        public Wolf(int maxInitialHealthPoints, double maxDamage) : base(maxInitialHealthPoints, maxDamage)
        {
        }
    }
}
