using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    public class Fireball : Ability
    {
        public Fireball(string name, AbilityType abilityType, int cost, int damage, int damageModifier) 
            : base(name, abilityType, cost, damage, damageModifier)
        {
        }

        public override void Use(Character target)
        {
            base.Use(target);
        }
    }
}
