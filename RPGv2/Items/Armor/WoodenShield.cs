using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Items.Armor
{
    public class WoodenShield : ArmorBase
    {
        private string _name;

        public WoodenShield(string name)
        {
            _name = name;
        }

        public override string Description
        {
            get { return "Round wooden Shield"; }
        }

        public override int MaxArmorPoints
        {
            get { return 40; }
        }

        public override string Name
        {
            get { return _name; }
        }
    }


}
