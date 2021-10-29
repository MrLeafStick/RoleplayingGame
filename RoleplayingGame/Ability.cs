using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    public class Ability
    {
        private string _name;
        private AbilityType _abilityType;
        private int _cost;
        private int _damage;
        private int _damageModifier;

        public string Name { get { return _name; } }
        public AbilityType AbilityType { get { return _abilityType; } }
        public int Cost { get { return _cost; } }
        public int Damage { get { return _damage; } }
        public int DamageModifier { get { return _damageModifier; } }

        public Ability(string name, AbilityType abilityType, int cost, int damage, int damageModifier)
        {
            _name = name;
            _abilityType = abilityType;
            _cost = cost;
            _damage = damage;
            _damageModifier = damageModifier;
        }

        public virtual void Use(Character target) {}
    }

    public enum AbilityType
    {
        Spell,Weapon
    }
}
