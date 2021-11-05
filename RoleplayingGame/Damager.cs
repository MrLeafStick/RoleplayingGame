using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    /// <summary>
    /// This class represents the Damager character type.
    /// </summary>
    public class Damager : Character
    {
        public Damager(string name, int hitPoints, int minDamage, int maxDamage) 
            : base(name, hitPoints, minDamage, maxDamage)
        {
        }
        /// <summary>
        /// A Damager has a 40 % chance of dealing increased damage.
        /// </summary>
        protected override int DealDamageModifyChance
        {
            get { return 40; }
        }

        /// <summary>
        /// If the damage is increased, it is doubled.
        /// </summary>
        protected override int CalculateModifedDamage(int dealtDamage)
        {
            return dealtDamage * 2;
        }
    }
}
