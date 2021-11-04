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

            switch (index)
            {
                case 1:
                    return new ClothGloves();
                case 2:
                    return new LeatherBoots();
                case 3:
                    return new PlateBoots();
                case 4:
                    return new WoodenShield();
                case 5:
                    return new IronSword();
                case 6:
                    return new SteelLance();
                case 7:
                    return new WoodenMace();
                default:
                    throw new Exception($"Could not generate item with index {index} ");
            }
        }
    }
}
