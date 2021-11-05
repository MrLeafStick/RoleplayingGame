using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Items.Armor
{
    public class WoodenShield : ArmorBase
    {
        public override string Description
        {
            get { return "Round wooden Shield"; }
        }

        public override int ArmorPoints
        {
            get { return 40; }
        }
    }


}
