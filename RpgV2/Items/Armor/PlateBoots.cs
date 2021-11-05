using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Items.Armor
{
    class PlateBoots : ArmorBase
    {
        public override string Description
        {
            get { return "Hardened plate Boots ";  }
        }

        public override int ArmorPoints
        {
            get { return 65;  }
        }
    }
}
