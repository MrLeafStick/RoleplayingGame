using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Items.Armour
{
    public class LeatherBoots : ArmourBase
    {
        public override string Description
        {
            get { return "Brown leather boots"; }
        }

        public override int ArmorPoints
        {
            get { return 25; }
        }
    }
}
