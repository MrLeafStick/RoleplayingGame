using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Items.Armour
{
    class PlateBoots : ArmourBase
    {
        public override string Description
        {
            get { return "Hardened plate boots"; }
        }

        public override int ArmourPoints
        {
            get { return 65; }
        }
    }
}
