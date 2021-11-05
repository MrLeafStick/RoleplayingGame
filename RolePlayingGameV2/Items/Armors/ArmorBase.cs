using RolePlayingGameV2.Helpers;
using RolePlayingGameV2.Interfaces;

namespace RolePlayingGameV2.Items.Armors
{
    public abstract class ArmorBase : ItemBase, IArmor
    {
        public int ArmorPoints { get; }

        public ArmorBase()
        {
            ArmorPoints = RNG.RandomInt(1, MaxArmorPoints);
        }

        public override string Description { get { return $"{Name} ({ArmorPoints} armor points)"; } }

        public abstract int MaxArmorPoints { get; }
        public abstract string Name { get; }
    }
}

//TODO Fix the rest of the armor class to reflect the new strcuture...