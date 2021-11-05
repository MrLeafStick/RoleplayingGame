using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    public class Damager : BaseCharacter
    {
        public Damager(string name, int maxHitPoints, int maxMana, int minDamage, int maxDamage) : base(name, maxHitPoints, maxMana, minDamage, maxDamage)
        {
        }

        public Damager(string name, int hitPoints, int maxHitPoints, int minDamage, int maxDamage) : base(name, hitPoints, maxHitPoints, minDamage, maxDamage)
        {
        }

        protected override int DealDamageModifyChance
        {
            get { return 40; }
        }

        protected override int CalculateModifiedDamage(int dealtDamage)
        {
            return dealtDamage * 2;
        }
    }
}
