using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoleplayingGame
{
    public class AbilityList
    {
        public static IEnumerable<AbilityType> SpellTypeList
        {
            get { return Enum.GetValues(typeof(AbilityType)).Cast<AbilityType>();  }
        }
    }
}
