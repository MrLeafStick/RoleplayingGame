using System.Collections.Generic;

namespace RoleplayingGame
{
    /// <summary>
    /// This class represents a game character.
    /// </summary>
    public class BaseCharacter
    {
        #region Instance Fields
        private string _name;
        private Dictionary<AbilityType, double> _abilityVector;
        protected int _stamina;
        protected int _maxStamina;
        protected int _mana;
        protected int _maxMana;
        protected int _hitPoints;
        protected int _maxHitPoints;
        protected int _minDamage;
        protected int _maxDamage;
        #endregion

        #region Constructor
        public BaseCharacter(string name, Dictionary<AbilityType, double> abilityVector, int hitPoints, int minDamage, int maxDamage)
        {
            _name = name;
            _maxHitPoints = hitPoints;
            _minDamage = minDamage;
            _maxDamage = maxDamage;
            _abilityVector = abilityVector;
            Reset();
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
        }
        /// <summary>
        /// Checks if the BaseCharacter is dead, defined as having 0 or less hit points...
        /// </summary>
        public bool IsDead
        {
            get { return _hitPoints <= 0; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Reset the BaseCharacter's state to the original state
        /// </summary>
        public void Reset()
        {
            _hitPoints = _maxHitPoints;
        }
        /// <summary>
        /// Returns the amount of points a BaseCharacter deals in damage.
        /// This damage could then be received by another character.
        /// Note that there is a chance that the damage is modified.
        /// </summary>
        public int DealDamage()
        {
            int modifiedDamge = 0;

            foreach (var at in _abilityVector)
            {
                int damage = NumberGenerator.Next(_minDamage + (int)at.Value, _maxDamage + (int)at.Value);
                modifiedDamge += DealDamageModifier(damage);

                string damageDesc = (damage < modifiedDamge) ? "(INCREASED)" : "";
                string message = $"{Name} used {at.Key} which dealt {modifiedDamge} damage {damageDesc}";

                BattleLog.Save(message);
            }

            return modifiedDamge;
        }
        /// <summary>
        /// The BaseCharacter receives the amount of damage specified in the parameter.
        /// The number of hit points will decrease accordingly.
        /// Note that there is a chance that the damage is modified.
        /// </summary>
        public int ReceiveDamage(int damage)
        {
            int modifiedDamge = ReceiveDamageModifier(damage);
            _hitPoints = _hitPoints - modifiedDamge;

            string damageDesc = (damage > modifiedDamge) ? "(DESCREASED)" : "";
            string message = $"{Name} receives " +
                $"{modifiedDamge} damage " +
                $"{damageDesc}, and is down to " +
                $"{_hitPoints} HP";


            BattleLog.Save(message);

            if (IsDead)
            {
                BattleLog.Save($"{Name} died!");
            }

            return modifiedDamge;
        }

        /// <summary>
        /// Log data about the character to the battle log,
        /// in case the character is still alive.
        /// </summary>
        public void LogSurvivor()
        {
            if (!IsDead)
            {
                BattleLog.Save($"{Name} survived with: {_hitPoints} hit points left");
            }
        }
        /// <summary>
        /// Modifies the amount of dealt damage. 
        /// </summary>
        public int DealDamageModifier(int dealtDamage)
        {
            int modifiedDealtDamage = dealtDamage;
            if (NumberGenerator.BelowPercentage(DealDamageModifyChance))
            {
                modifiedDealtDamage = CalculateModifedDamage(dealtDamage);
            }

            return modifiedDealtDamage;
        }
        /// <summary>
        /// Modifies the amount of received damage. 
        /// </summary>
        public int ReceiveDamageModifier(int receiveDamage)
        {
            int modifiedReceiveDamage = receiveDamage;

            if (NumberGenerator.BelowPercentage(ReceiveDamageModifiChance))
            {
                modifiedReceiveDamage = CalculateModifedReceivedDamage(receiveDamage);
            }

            return modifiedReceiveDamage;
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
        /// Unless overrieded in a dirived class, a BaseCharacter has 
        /// 0% chance of having the damage received modified.
        /// </summary>
        protected virtual int ReceiveDamageModifiChance
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
