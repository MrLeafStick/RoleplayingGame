using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Interfaces
{
    public interface IArmor : IItem
    {
        int ArmorPoints { get; }
    }
}
