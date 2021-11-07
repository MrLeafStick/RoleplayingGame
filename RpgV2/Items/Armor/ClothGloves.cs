using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Items.Armor
{
    public class ClothGloves : ArmorBase
    {
        public override int MaxArmorPoints
        {
            get { return 10; }
        }

        public override string Name
        {
            get { return "Black Cloth Gloves"; }
        }
    }
}
