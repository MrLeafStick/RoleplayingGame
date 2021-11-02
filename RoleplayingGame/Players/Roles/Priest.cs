using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame.Players.Roles
{
    public class Priest : BaseCharacter
    {
        public Priest(string name, int maxHitPoints, int maxMana, int minDamage, int maxDamage) : base(name, maxHitPoints, maxMana, minDamage, maxDamage)
        {
        }
    }
}
