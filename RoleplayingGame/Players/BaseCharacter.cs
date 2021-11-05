using RoleplayingGame.Moves;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame

{
    /// <summary>
    /// This class represents a game character.
    /// </summary>
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
        public Character(string name, int hitPoints, int minDamage, int maxDamage)
        {
            _name = name;
            _hitPoints = hitPoints;
            _maxHitPoints = hitPoints;
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
        /// <summary>
        /// Reset the Character's state to the original state
        /// </summary>
        public void Reset()
        {
            _hitPoints = _maxHitPoints;
        }
        /// <summary>
        /// Returns the amount of points a Character deals in damage.
        /// This damage could then be received by another character.
        /// Note that there is a chance that the damage is modified.
        /// </summary>
        public int DealDamage()
        {
            return 0;
        }
        public int ReceiveDamage()
        {
            return 0;
        }

        /// <summary>
        /// Log data about the character to the battle log,
        /// in case the character is still alive.
        /// </summary>
        public void LogSurvivor()
        {
            if (!IsDead)
            {
                
            }
        }

        public int DealDamageModifier(int dealtDamage)
        {
            int damage = NumberGenerator.Next(_minDamage, _maxDamage);
            int modifiedDamage = DealDamageModifier(damage);
            string damageDesc;

            damageDesc = (damage < modifiedDamage) ? "(INCREASED)" : "";

            string message = $"{Name} dealt {modifiedDamage} damage {damageDesc}";

            BattleLog.Save(message);
            return modifiedDamage;
        }
        /// <summary>
        /// Modifies the amount of received damage. 
        /// </summary>
        public int ReceiveDamageModifier(int receiveDamage)
        {
            int modifiedDamage = ReceiveDamageModifier(receiveDamage);
            _hitPoints = _hitPoints - modifiedDamage;

            string damageDesc = (receiveDamage > modifiedDamage) ? "(DECREASED)" : "";
            string message = $"{Name} recieved {modifiedDamage} damage {damageDesc}, and is down to {_hitPoints} HP";


            BattleLog.Save(message);
            if (IsDead)
            {
                BattleLog.Save(Name + " died!");
            }

            return modifiedDamage;
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
        protected virtual int CalculateModifiedDamage(int dealtDamage)
        {
            return dealtDamage;
        }

        /// <summary>
        /// Return the modifed reveived damage.
        /// unless orverried in a derved class the modifed received
        /// damage is the sae as the original received damage.
        /// </summary>
        protected virtual int CalculateModifiedReceivedDamage(int receivedDamage)
        {
            return receivedDamage;
        }


        #endregion
    }
}
