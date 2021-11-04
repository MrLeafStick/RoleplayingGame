using RPG_V2.Helpers;
using RPG_V2.Interfaces;
using RPG_V2.Items.Armour;
using RPG_V2.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Factories
{
    class ItemFactoryStandard
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
                    return new WoodMace();
            default:
                    throw new Exception($"Could not generate item with index {index}");
            }
        }
    }
}
