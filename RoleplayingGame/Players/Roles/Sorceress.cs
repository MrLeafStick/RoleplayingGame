using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    public class Sorceress : BaseCharacter
    {
        public Sorceress(string name, int maxHitPoints, int maxMana, int minDamage, int maxDamage) : base(name, maxHitPoints, maxMana, minDamage, maxDamage)
        {
        }

        protected override int DealDamageModifyChance
        {
            get { return 20; }
        }

        protected override int CalculateModifiedDamage(int dealtDamage)
        {
            return dealtDamage * 3;
        }


    }
}
