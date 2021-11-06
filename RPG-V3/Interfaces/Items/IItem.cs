using System;
using System.Collections.Generic;
using System.Text;

// Base interface for all in-animate objects, including physical objects,
// magical potions, weapons, armor etc.
namespace RPG_V3.Interfaces
{
    public interface IItem
    {
        string Description { get; }
    }
}
