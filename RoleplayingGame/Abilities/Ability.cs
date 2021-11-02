using System;
using System.Collections.Generic;

namespace RoleplayingGame
{
    public class Ability
    {
        public static IEnumerable<AbilityType> AbilityTypeList
        {
            get { return Enum.GetValues<AbilityType>(); }
        }

        public static string GetNameByAbilityType(AbilityType abilityType)
        {
            return Enum.GetName(typeof(AbilityType), abilityType);
        }
    }
}
