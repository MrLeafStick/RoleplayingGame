using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    public class Ability
    {
        public static IEnumerable<AbilityType> AbilityTypeList
        {
            get { return Enum.GetValues(typeof(AbilityType)).Cast<AbilityType>(); }
        }
    }

    public enum AbilityType
    {
        BasicAttack,
        PowerAttack,
        WhirlwindAttack,
        Fireball,
        Blizzard,
        ShieldSmash,
        ShieldBlock,
        HealingSpring,
        SacredGround
    }
}