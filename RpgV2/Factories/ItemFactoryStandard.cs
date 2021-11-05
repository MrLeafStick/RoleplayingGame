using RpgV2.Helpers;
using RpgV2.Interfaces;
using RpgV2.Interfaces.Factories;
using RpgV2.Items.Armor;
using RpgV2.Items.Weapons;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Factories
{
    public class ItemFactoryStandard : IItemFactory
    {
        public IItem CreateItem()
        {
            int index = RNG.RandomInt(1, 7);

            return index switch
            {
                1 => new ClothGloves("Silk Smooth"),
                2 => new LeatherBoots("Cow skin leather boots"),
                3 => new PlateBoots("Polished plate boots"),
                4 => new WoodenShield("Viking shield"),
                5 => new IronSword("Sharpened sword", 30, 70),
                6 => new SteelLance("Long stick", 20, 50),
                7 => new WoodenMace("Broken Club", 10, 30),
                _ => throw new Exception($"Could not generate item with index {index} ")
            };
        }
    }
}
    
