using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGameV2.Items.Armor
{
    public abstract class ArmorBase : ItemBase
    {
        public abstract int ArmorPoints { get; }
    }
}
