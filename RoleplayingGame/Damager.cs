using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    public class Damager : BaseCharacter
    {
        #region Constructors
        public Damager(string name, 
                          int maxHitPoints, 
                          int minDamage, 
                          int maxDamage, 
                          int maxStamina, 
                          int staminaRegen,
                          int maxMana,
                          int ManaRegen)
            : base(name, maxHitPoints, minDamage, maxDamage, maxStamina, staminaRegen, maxMana, ManaRegen)
        {

        }
        #endregion

        protected override int DealDamageModifyChance
        {
            get { return 40; }
        }

        protected override int CalculateModifedDamage(int dealtDamage, int modifier)
        {
            return dealtDamage * (int)(modifier * 0.1);
        }
    }
}
