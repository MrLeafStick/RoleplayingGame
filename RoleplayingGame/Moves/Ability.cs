using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame.Moves
{
    class Ability
    {
        public static IEnumerable<AbilityList> AbilityTypeList
        {
            get { return Enum.GetValues(typeof(AbilityList)).Cast<AbilityList>(); }
        }
    }
}
