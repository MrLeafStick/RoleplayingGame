using RoleplayingGameV2.Helpers;
using RoleplayingGameV2.Interfaces;
using RoleplayingGameV2.Interfaces.Factories;
using RoleplayingGameV2.Items.Armor;
using RoleplayingGameV2.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGameV2.Factories
{
    public class ItemFactoryStandard : IItemFactory
    {
        public IItem CreateItem()
        {
            int index = RNG.RandomInt(1, 8);
            return index switch
            {
                1 => new ClothGloves(),
                2 => new LeatherBoots(),
                3 => new PlateBoots(),
                4 => new WoodenShield(),
                5 => new IronSword(),
                6 => new SteelLance(),
                7 => new WoodenMace(),
                8 => new WoodenStick(),
                _ => throw new Exception($"Could not generate item with index {index}"),
            };
        }
    }
}
