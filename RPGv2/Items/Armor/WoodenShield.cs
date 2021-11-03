using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGv2.Items.Armor
{
    public class WoodenShield : ArmorBase
    {
        public override string Description
        {
            get { return "Round Wooden Shield"; }
        }

        public override int ArmorPoints
        {
            get { return 40; }
        }
    }
}
