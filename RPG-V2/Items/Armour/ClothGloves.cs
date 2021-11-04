using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Items.Armour
{
    public class ClothGloves : ArmourBase
    {
        public override string Description
        {
            get { return "Black cloth gloves"; }
        }

        public override int ArmorPoints
        {
            get { return 10; }
        }
    }
}
