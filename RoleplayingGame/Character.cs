using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame

{
    public class Character
    {
        #region Instance Fields
        private string _name;
        protected int _hitPoints;
        protected int _maxHitPoints;
        protected int _minDamage;
        protected int _maxDamage;
        
        #endregion

        #region Constructor
        public Character(string name, int hitPoints, int maxHitPoints, int minDamage, int maxDamage)
        {
            _name = name;
            _hitPoints = hitPoints;
            _maxHitPoints = maxHitPoints;
            _minDamage = minDamage;
            _maxDamage = maxDamage;
            Reset();
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
        }        

        public bool IsDead
        {
            get { return _hitPoints <= 0; }
        }
        #endregion

        #region Methods
        public void Reset()
        {
            _hitPoints = _maxHitPoints;
        }

        public int DealDamage()
        {
            int damage = NumberGenerator.Next(_minDamage, _maxDamage);
            int modifiedDamage = DealDamageModifier(damage);

            string damageDesc = (damage < modifiedDamage) ? "(Increased)" : "";
            string message = $"{Name} dealt {modifiedDamage} damage {damageDesc}";

            //TODO: Create BattleLog
            BattleLog.Save(message);

            return modifiedDamage;
        }
        public int ReceiveDamage(int damage)
        {
            int modifiedDamage = ReceiveDamageModifier(damage);
            _hitPoints = _hitPoints - modifiedDamage;

            string damageDesc = (damage < modifiedDamage) ? "(Decreased)" : "";
            string message = $"{Name} received {modifiedDamage} damage {damageDesc}, and is now down to {_hitPoints} hp";

            //TODO: Create BattleLog
            BattleLog.Save(message);

            if (!IsDead)
            {
                // TODO: BattleLog
                BattleLog.Save($"{Name} died!");
            }

            return modifiedDamage;
        }

        public void LogSurvivor()
        {
            if (!IsDead)
            {
                // TODO: BattleLog
                BattleLog.Save($"{Name} survived with {_hitPoints} hitpoints left");
            }
        }

        public int DealDamageModifier(int dealtDamage)
        {
            int modifiedDealtDamage = dealtDamage;
            if(NumberGenerator.BelowPercentage(DealDamageModifyChance))
            {
                modifiedDealtDamage = CalculateModifedDamage(dealtDamage);
            }
            return modifiedDealtDamage;
        }

        public int ReceiveDamageModifier(int receiveDamage)
        {
            int modifiedReceivedDamage = receiveDamage;
            if (NumberGenerator.BelowPercentage(ReceiveDamageModyChance))
            {
                modifiedReceivedDamage = CalculateModifedDamage(receiveDamage);
            }
            return modifiedReceivedDamage;
        }

        #endregion

        #region Virtual Properties and Methods
        /// <summary>
        /// Return the change of the damage dealt being modifed, 
        /// unless overrides in a derived class, a charactor has 
        /// 0% chance of having the damage dealt modified.
        /// </summary>
        protected virtual int DealDamageModifyChance
        {
            get { return 0; }
        }        

        /// <summary>
        /// Return the chance of the damage received bbeing modified.
        /// Unless overrieded in a dirived class, a Character has 
        /// 0% chance of having the damage received modified.
        /// </summary>
        protected virtual int ReceiveDamageModyChance
        {
            get { return 0; }
        }

        /// <summary>
        /// Return the modifed dealt damage.
        /// Unless overrisded in a dirived class, the modified dealt
        /// damage is the same as the original dealt damage.
        /// </summary
        protected virtual int CalculateModifedDamage(int dealtDamage)
        {
            return dealtDamage;
        }

        /// <summary>
        /// Return the modifed reveived damage.
        /// unless orverried in a derved class the modifed received
        /// damage is the sae as the original received damage.
        /// </summary>
        protected virtual int CalculateModifedReceivedDamage(int receivedDamage)
        {
            return receivedDamage;
        }

        #endregion
    }
}
