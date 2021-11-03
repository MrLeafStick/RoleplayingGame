using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGv2.Items.Armor
{
    public class ClothGloves : ArmorBase
    {
        public override string Description
        {
            get { return "Black Cloth Gloves"; }
        }

        public override int ArmorPoints
        {
            get { return 10; }
        }
    }
}
