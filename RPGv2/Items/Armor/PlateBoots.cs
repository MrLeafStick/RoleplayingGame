using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGv2.Items.Armor
{
    public class PlateBoots : ArmorBase
    {
        public override string Description
        {
            get { return "Shiny Plate Boots"; }
        }

        public override int ArmorPoints
        {
            get { return 65; }
        }
    }
}
