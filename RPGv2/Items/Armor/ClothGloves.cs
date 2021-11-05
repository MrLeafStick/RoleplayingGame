using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Items.Armor
{
    public class ClothGloves : ArmorBase
    {
        private string _name;

        public ClothGloves(string name)
        {
            _name = name;
        }

        public override string Description
        {
            get { return "Black Cloth Gloves";  }
        }

        public override int MaxArmorPoints
        {
            get { return 10; }
        }

        public override string Name
        {
            get { return _name; }
        }
    }
}
