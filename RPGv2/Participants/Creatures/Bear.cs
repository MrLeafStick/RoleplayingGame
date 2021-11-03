using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGv2.Participants.Creatures
{
    public class Bear : CreatureBase
    {
        public const int MaxInitialHealthPoints = 70;
        public const int MaxDamage = 25;

        public Bear(int maxInitialHealthPoints, double MaxDamage) : base(maxInitialHealthPoints, MaxDamage)
        {
        }
    }
}
