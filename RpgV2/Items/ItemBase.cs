using RpgV2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Items
{
    public abstract class ItemBase : IItem
    {
        public abstract string Description { get; }
        public override string ToString()
        {
            return Description;
        }

    }
}
