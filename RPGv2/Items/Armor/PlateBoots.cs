using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Items.Armor
{
    class PlateBoots : ArmorBase
    {
        private string _name;

        public PlateBoots(string name)
        {
            _name = name;
        }

        public override string Description
        {
            get { return "Hardened plate Boots ";  }
        }

        public override int MaxArmorPoints
        {
            get { return 65; }
        }

        public override string Name
        {
            get { return _name; }
        }
    }
}
