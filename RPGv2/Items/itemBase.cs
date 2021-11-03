using RPGv2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGv2.Items
{
    public abstract class itemBase : IItems
    {
        public abstract string Description { get; }

        public override string ToString()
        {
            return Description;
        }
    }
}
