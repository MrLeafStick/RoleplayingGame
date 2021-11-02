﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace RoleplayingGame
{
    public class BaseCharacter
    {
        #region Instance Fields
        private string _name;
        protected int _hitPoints;
        protected int _maxHitPoints;
        protected int _minDamage;
        protected int _maxDamage;
        protected Dictionary<AbilityType, int> _abilities;

        private Random _random;
        #endregion

        #region Constructor
        public BaseCharacter(string name, int hitPoints, int minDamage, int maxDamage)
        {
            _name = name;
            _maxHitPoints = hitPoints;
            _minDamage = minDamage;
            _maxDamage = maxDamage;
            _abilities = new Dictionary<AbilityType, int>();
            _abilities.Add(AbilityType.Hand, 5);
            _abilities.Add(AbilityType.Weapon, 15);
            AddRandomAbilities(3);
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

        public void AddRandomAbilities(int amount = 1)
        {
            for (int i = 0; i < amount;)
            {
                _random = new Random(Guid.NewGuid().GetHashCode() + i);

                var randomAbilityIndex = _random.Next(0, Ability.AbilityTypeList.Count());
                var abilityType = Ability.AbilityTypeList.ElementAt(randomAbilityIndex);
                if (!_abilities.ContainsKey(abilityType))
                {
                    var abilityDamage = _random.Next(100);
                    _abilities.Add(abilityType, abilityDamage);
                    i++;
                }
            }
        }

        /// <summary>
        /// Returns the amount of points a character deals in damage.
        /// This damage could then be received by another character
        /// nate that there is a chance that the damage is modified
        /// </summary>
        /// <returns></returns>
        public int DealDamage()
        {
            int randomAbility = NumberGenerator.Next(0, _abilities.Count);
            var ability = _abilities.ElementAt(randomAbility);

            //int damage = NumberGenerator.Next(_minDamage, _maxDamage);
            int modifiedDamge = DealDamageModifier(ability.Value);

            string damageDesc = (ability.Value < modifiedDamge) ? "(INCREASED)" : "";

            string message = $"{Name} dealt {modifiedDamge} damage {damageDesc}, using {Ability.GetNameByAbilityType(ability.Key)}";

            //string message = $"{Name} dealt {modifiedDamge} damage {damageDesc}";
            if (this is Wizard)
            {
                //message = $"{Name} throwed a big ass fire ball, dealt {modifiedDamge} damage {damageDesc}";
            }

            BattleLog.Save(message);
            return modifiedDamge;
        }

        public int ReceiveDamage(int damage)
        {
            int modifiedDamge = ReceiveDamageModifier(damage);
            _hitPoints -= modifiedDamge;

            string damageDesc = (damage > modifiedDamge) ? "(DESCREASED)" : "";
            string message = $"{Name} receives {modifiedDamge} damage {damageDesc}, and is down to {_hitPoints} HP";
            BattleLog.Save(message);

            if (IsDead)
            {
                BattleLog.Save($"{Name} died!");
            }

            return modifiedDamge;
        }

        public void LogSurvivor()
        {
            if (!IsDead)
            {
                BattleLog.Save($"{Name} survived with: {_hitPoints} hit points left");
            }
        }

        public int DealDamageModifier(int dealtDamage)
        {
            int modifiedDealtDamage = dealtDamage;
            if (NumberGenerator.BelowPercentage(DealDamageModifyChance))
            {
                modifiedDealtDamage = CalculateModifedDamage(dealtDamage);
            }

            return modifiedDealtDamage;
        }

        public int ReceiveDamageModifier(int receiveDamage)
        {
            int modifiedReceiveDamage = receiveDamage;

            if (NumberGenerator.BelowPercentage(ReceiveDamageModifyChance))
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
        /// Unless overrieded in a dirived class, a Character has 
        /// 0% chance of having the damage received modified.
        /// </summary>
        protected virtual int ReceiveDamageModifyChance
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
