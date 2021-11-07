using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Items.Armor
{
    public class LeatherBoots : ArmorBase
    {
        public override int MaxArmorPoints
        {
            get { return 25; }
        }
        public override string Name
        {
            get { return "Brown Leather Boots"; }
        }
    }
}
