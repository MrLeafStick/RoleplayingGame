using RPG_V3.Helpers;
using RPG_V3.Interfaces;
using RPG_V3.Interfaces.Factories;
using RPG_V3.Interfaces.Items.Armor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_V3.Factories
{
    public class ArmorFactoryStandard : IArmorFactory
    {
        public IArmor CreateArmor()
        {
            Armor armor = GetRandom(Armor.List(), RNG._generator);
            //Armor armor = new Armor(GetRandom(Armor.List(), RNG._generator));

            //return armor;
            return new Armor(GetRandom(Armor.List(), RNG._generator));
        }

        T GetRandom<T>(List<T> list, Random random)
        {
            return list.ElementAt(random.Next(0, list.Count));
        }
    }
}
