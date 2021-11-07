using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Items.Weapons
{
    public class IronSword : WeaponBase
    {
        private string _name;

        public IronSword(string name, int minWeaponDamage, int maxWeaponDamage) : base(minWeaponDamage, maxWeaponDamage)
        {
            _name = name;
        }

        public override string Description
        {
            get { return "One-Handed Iron Sword";  }
        }


        public override string Name
        {
            get { return _name; }
        }

    }
}
