using RPG_V3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V3.Items
{
    class Item : IItem
    {
        public string Name { get; }
        public double Value { get; }
        public double Weight { get; }
    }
}
