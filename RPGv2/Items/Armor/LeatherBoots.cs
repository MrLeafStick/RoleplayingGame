using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGv2.Items.Armor
{
    public class LeatherBoots : ArmorBase
    {
        public override string Description
        {
            get { return "Brown Leather Boots"; }
        }

        public override int ArmorPoints
        {
            get { return 25; }
        }
    }
}
