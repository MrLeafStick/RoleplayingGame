using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Items.Armour
{
    public abstract class ArmourBase : ItemBase
    {
        public abstract int ArmourPoints { get; }
    }
}
