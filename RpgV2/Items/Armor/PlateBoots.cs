using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Items.Armor
{
    public class PlateBoots : ArmorBase
    {
        public override int MaxArmorPoints
        {
            get { return 65; }
        }

        public override string Name
        {
            get { return "Hardened Plate Boots"; }
        }
    }
}
