using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V3.Interfaces
{
    public interface IArmor : IItem
    {
        int ArmorPoints { get; }
    }
}
