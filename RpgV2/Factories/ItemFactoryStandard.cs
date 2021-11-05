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
                1 => new ClothGloves(),
                2 => new LeatherBoots(),
                3 => new PlateBoots(),
                4 => new WoodenShield(),
                5 => new IronSword(),
                6 => new SteelLance(),
                7 => new WoodenMace(),
                _ => throw new Exception($"Could not generate item with index {index} "),
            };
        }
    }
}
