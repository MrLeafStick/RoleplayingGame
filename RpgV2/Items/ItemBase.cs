using RpgV2.Interfaces;

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
