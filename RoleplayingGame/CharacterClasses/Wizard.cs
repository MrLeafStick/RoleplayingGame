using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    public class Wizard : BaseCharacter
    {
        public Wizard(string name, Dictionary<AbilityType, double> abilityVector, int hitPoints, int minDamage, int maxDamage) : base(name, abilityVector, hitPoints, minDamage, maxDamage)
        {
        }


        /// <summary>
        /// A Damager has a 40 % chance of dealing increased damage.
        /// </summary>
        protected override int DealDamageModifyChance
        {
            get { return 30; }
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
