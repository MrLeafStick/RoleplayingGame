using RPG_V2.Helpers;
using RPG_V2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Items.Armour
{
    public abstract class ArmourBase : ItemBase, IArmor
    {
        public  int ArmorPoints { get; private set; }

        public ArmourBase()
        {
            ArmorPoints = RNG.RandomInt(1, MaxArmorPoints);
        }

        public override string Description
        {
            get { return $"{Name} ({ArmorPoints} armor points"; }
        }


        public abstract int MaxArmorPoints { get; }
        public abstract string Name { get; }
    }
}

// TODO: Fix the rest of the armor class's to  reflect the new infrastructure.