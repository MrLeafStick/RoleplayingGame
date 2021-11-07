using RPG_V2.Interfaces;

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
