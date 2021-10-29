using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    /// <summary>
    /// This class represents the Defender character type.
    /// </summary>
    public class Defender : Character
    {
        public Defender(string name, List<Ability> abilities, int hitPoints, int minDamage, int maxDamage) 
            : base(name, abilities, hitPoints, minDamage, maxDamage)
        {
        }

        /// <summary>
        /// A Defender has a 45 % chance of having the received damage reduced.
        /// </summary>
        protected override int ReceiveDamageModifiChance
        {
            get { return 45; }
        }

        /// <summary>
        /// If the damage is reduced, it is reduced by 50 %.
        /// </summary>
        protected override int CalculateModifedReceivedDamage(int receivedDamage)
        {
            return receivedDamage / 2;
        }
    }
}

