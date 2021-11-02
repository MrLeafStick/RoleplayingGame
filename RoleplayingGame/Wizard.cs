using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    public class Wizard : BaseCharacter
    {
        #region Field Definitions
        
        #endregion

        #region Constructors
        public Wizard(string name,
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
        public override int DealDamage()
        {
            int damageCost = 20;
            int damage = NumberGenerator.Next(_minDamage, _maxDamage);
            int modifiedDamage = DealDamageModifier(damage);

            if (damageCost <= _mana)
            {
                _mana -= damageCost;
                string damageDesc = (damage < modifiedDamage) ? "(Increased)" : "";
                string message = $"{Name} throws fireball and dealt {modifiedDamage} damage {damageDesc}. (Mana {_mana})";

                BattleLog.Save(message);

                return modifiedDamage;
            }
            else
            {
                string message = $"{Name} is too exhausted to throw spell. (Mana {_mana})";

                BattleLog.Save(message);

                return 0;
            }
        }

        protected override int CalculateModifedDamage(int dealtDamage)
        {
            return dealtDamage;
        }
        #endregion

        // Har egne properties

    }
}
