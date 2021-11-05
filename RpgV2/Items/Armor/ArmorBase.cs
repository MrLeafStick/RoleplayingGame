using RpgV2.Helpers;
using RpgV2.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Items.Armor
{
    public abstract class ArmorBase : ItemBase, IArmor
    {

        public  int ArmorPoints { get; set; }

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

