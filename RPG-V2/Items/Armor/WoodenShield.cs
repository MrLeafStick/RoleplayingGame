using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Items.Armour
{
    class WoodenShield : ArmorBase
    {
        public override string Description
        {
            get { return "Round wooden shield"; }
        }

        public override int ArmorPoints
        {
            get { return 40; }
        }

        public override int MaxArmorPoints { get; }
        public override string Name { get; }
    }
}
