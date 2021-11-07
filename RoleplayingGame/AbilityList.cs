using System;
using System.Collections.Generic;
using System.Linq;

namespace RoleplayingGame
{
    public class AbilityList
    {
        public static IEnumerable<AbilityType> SpellTypeList
        {
            get { return Enum.GetValues(typeof(AbilityType)).Cast<AbilityType>(); }
        }

        /*
        public static string GetName(int index)
        {
            return Enum.GetNames(typeof(AbilityType))[index]; 
        }
        */
    }
}
