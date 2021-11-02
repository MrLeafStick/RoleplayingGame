using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        protected int _stamina;
        protected int _maxStamina;
        protected int _staminaRegen;
        protected int _mana;
        protected int _maxMana;
        protected int _manaRegen;
        protected Random _random;
        #endregion

        #region Constructor
        public BaseCharacter(string name, 
                            int maxHitPoints, 
                            int minDamage, 
                            int maxDamage, 
                            int maxStamina, 
                            int staminaRegen,
                            int maxMana,
                            int ManaRegen)
        {
            _name = name;
            _maxHitPoints = maxHitPoints;
            _minDamage = minDamage;
            _maxDamage = maxDamage;
            _maxStamina = maxStamina;
            _staminaRegen = staminaRegen;
            _maxMana = maxMana;
            _manaRegen = ManaRegen;

            SpellVector = new Dictionary<AbilityType, int>();
            Reset();
        }
        #endregion

        #region Properties
        public Dictionary<AbilityType, int> SpellVector { get; set; }

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
        /*
        public void AddRandomSpells(int numSpells)
        {
            _random = new Random(Guid.NewGuid().GetHashCode());
            
            for(int i = 0; i < numSpells; i++)
            {
                var rndSpell = _random.Next(0, Spell.SpellTypeList.Count());
                var spell = Spell.SpellTypeList.ElementAt(rndSpell);
            }
        }
        */
        public void AddAbility(AbilityType ability, int strength)
        {
            SpellVector[ability] = strength;
        }

        public void Reset()
        {
            _hitPoints = _maxHitPoints;
            _stamina = _maxStamina;
            _mana = _maxMana;
        }
        
        public virtual int DealDamage()
        {
            int randomAbility = NumberGenerator.Next(0, SpellVector.Count);
            var ability = SpellVector.ElementAt(randomAbility);
            var abilityName = ability.Key.ToString();
            var abilityValue = ability.Value;
            int damageCost = (int)(abilityValue / 2);
            int damage = NumberGenerator.Next(_minDamage, _maxDamage);
            int modifiedDamage = DealDamageModifier(damage, abilityValue);

            if(damageCost <= _stamina)
            {
                _stamina -= damageCost;
                string damageDesc = (damage < modifiedDamage) ? "(INCREASED)" : "\b";
                string message = $"{Name} dealt {modifiedDamage} damage {damageDesc} with {abilityName}. (Stamina {_stamina})";

                BattleLog.Save(message);

                return modifiedDamage;
            }
            else
            {
                string message = $"{Name} is too exhausted to deal damage. (Stamina {_stamina})";

                BattleLog.Save(message);

                return 0;
            }
        }

        public int ReceiveDamage(int damage)
        {
            int modifiedDamage = ReceiveDamageModifier(damage);
            _hitPoints = _hitPoints - modifiedDamage;

            string damageDesc = (damage > modifiedDamage) ? " (DECREASED)" : "";
            string message = $"{Name} received {modifiedDamage} damage{damageDesc}, and is now down to {_hitPoints} HP";

            BattleLog.Save(message);

            if (IsDead)
            {
                BattleLog.Save($"{Name} died!");
            }

            return modifiedDamage;
        }

        public void LogSurvivor()
        {
            if (!IsDead)
            {
                BattleLog.Save($"{Name} survived with {_hitPoints} hitpoints left");
            }
        }

        public int DealDamageModifier(int dealtDamage, int modifier)
        {
            int modifiedDealtDamage = dealtDamage;
            if(NumberGenerator.BelowPercentage(DealDamageModifyChance))
            {
                modifiedDealtDamage = CalculateModifedDamage(dealtDamage, modifier);
            }
            return modifiedDealtDamage;
        }

        public int ReceiveDamageModifier(int receiveDamage)
        {
            int modifiedReceivedDamage = receiveDamage;
            if (NumberGenerator.BelowPercentage(ReceiveDamageModifyChance))
            {
                modifiedReceivedDamage = CalculateModifedReceivedDamage(receiveDamage);
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
        protected virtual int ReceiveDamageModifyChance
        {
            get { return 0; }
        }

        /// <summary>
        /// Return the modifed dealt damage.
        /// Unless overrisded in a dirived class, the modified dealt
        /// damage is the same as the original dealt damage.
        /// </summary
        protected virtual int CalculateModifedDamage(int dealtDamage, int modifier)
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

        public virtual void Regenerate()
        {
            _stamina += _staminaRegen;
            _mana += _manaRegen;
        }
        #endregion
    }
}
