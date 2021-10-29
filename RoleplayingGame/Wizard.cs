using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    public class Wizard : Character
    {
        #region Field Definitions
        
        #endregion

        #region Constructors
        public Wizard(string name, int maxHitPoints, int minDamage, int maxDamage, int maxStamina, int staminaRegen)
            : base(name, maxHitPoints, minDamage, maxDamage, maxStamina, staminaRegen)
        {
        }
        #endregion

        #region Properties

        #endregion

        #region Override Properties
        protected override int DealDamageModifyChance
        {
            get 
            { 
                return 50; 
            }
        }

        #endregion

        #region Override Methods
        protected override int CalculateModifedDamage(int dealtDamage)
        {
            return dealtDamage;
        }
        #endregion

        // Har egne properties

    }
}
