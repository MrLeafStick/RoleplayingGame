using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Items.Armour
{
    class WoodenShield : ArmourBase
    {
        public override string Description
        {
            get { return "Round wooden shield"; }
        }

        public override int ArmourPoints
        {
            get { return 40; }
        }
    }
}
