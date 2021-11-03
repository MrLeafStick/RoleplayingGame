using RoleplayingGameV2.Interfaces;

namespace RoleplayingGameV2.Items
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
