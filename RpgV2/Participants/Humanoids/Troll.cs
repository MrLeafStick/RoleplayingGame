using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Participants.Humanoids
{
    class Troll : HumannoidBase
    {
        public const int MAX_INITIAL_HEALTH_POINTS = 200;
        public const int MAX_DAMGE = 80;

        public Troll(string name)
            : base(name, MAX_INITIAL_HEALTH_POINTS, MAX_DAMGE)
        {
        }
    }
}
