﻿using RoleplayingGameV2.Helpers;
using RoleplayingGameV2.Interfaces;

namespace RoleplayingGameV2.Items.Armor
{
    public abstract class ArmorBase : ItemBase, IArmor
    {
        public int ArmorPoints { get; private set; }

        protected ArmorBase()
        {
            ArmorPoints = RNG.RandomInt(1, MaxArmorPoints);
        }

        public override string Description
        {
            get { return $"{Name} ({ArmorPoints} armor points)"; }
        }

        public abstract int MaxArmorPoints { get; }
        public abstract string Name { get; }
    }
}

// TODO: Fix the rest of the armor classes to reflect the new infrastructure