using RPG_V2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Items
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
