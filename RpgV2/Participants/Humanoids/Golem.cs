using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Participants.Humanoids
{
    public class Golem : HumannoidBase
    {
        public const int MAX_INITIAL_HEALTH_POINTS = 200;
        public const int MAX_MELEE_DAMGE = 80;

        public Golem(string name) 
            : base(name, MAX_INITIAL_HEALTH_POINTS, MAX_MELEE_DAMGE)
        {
        }
    }
}
