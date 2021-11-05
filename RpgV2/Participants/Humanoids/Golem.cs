using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Participants.Humanoids
{
    class Golem : HumanoidBase
    {
        public const int MAX_INITIAL_HEALTH_POINTS = 200;
        public const int MAX_DAMAGE = 80;

        public Golem(string name) : base(name, MAX_INITIAL_HEALTH_POINTS, MAX_DAMAGE) { }
    }
}
