using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Items.Weapons
{
    class WoodenMace : WeaponBase
    {
        private string _name;
        private int _totalMinWeaponDamage;
        private int _totalMaxWeaponDamage;

        public WoodenMace(string name, int totalMinWeaponDamage, int totalMaxWeaponDamage)
        {
            _name = name;
            _totalMinWeaponDamage = totalMinWeaponDamage;
            _totalMaxWeaponDamage = totalMaxWeaponDamage;
        }

        public override string Description
        {
            get { return "Rough Wooden Mace"; }
        }

        public override int TotalMinWeaponDamage
        {
            get { return _totalMinWeaponDamage; }
        }

        public override int TotalMaxWeaponDamage
        {
            get { return _totalMaxWeaponDamage; }
        }

        public override string Name
        {
            get { return _name; }
        }
    }
}
