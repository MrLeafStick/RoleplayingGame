using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Items.Armor
{
    public class LeatherBoots : ArmorBase
    {
        private string _name;

        public LeatherBoots(string name)
        {
            _name = name;
        }

        public override string Description
        {
            get { return " Brown Leather Boots"; }
        }

        public override int MaxArmorPoints
        {
            get { return 25; }
        }

        public override string Name
        {
            get { return _name; }
        }
    }
}
