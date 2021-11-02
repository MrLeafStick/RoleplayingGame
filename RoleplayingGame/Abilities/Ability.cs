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

        public static List<string> WarriorCharacters = new List<string>
        {
            nameof(BaseCharacter),
            nameof(Defender),
            nameof(Damager),
        };

        public static List<string> WizardCharacters = new List<string>
        {
            nameof(Wizard),
        };

        public static string GetNameByAbilityType(AbilityType abilityType)
        {
            return Enum.GetName(typeof(AbilityType), abilityType);
        }
    }
}
