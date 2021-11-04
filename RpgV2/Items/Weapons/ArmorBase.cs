using RpgV2.Helpers;
using RpgV2.Interfaces;

namespace RpgV2.Items.Armor
{
    public abstract class ArmorBase : ItemBase, IArmor
    {
        public int ArmorPoints { get; private set; }


        public ArmorBase()
        {
            ArmorPoints = RNG.RandomInt(1, MaxArmorPoints);
        }

        public override string Description
        {
            get { return $"{Name} ({ArmorPoints} armor points)";  }
        }
        public abstract int MaxArmorPoints { get; }
        public abstract string Name { get;  }
    }
}


//TODO: Fix the rest of the armor class's to reflect the new infrastructure.
