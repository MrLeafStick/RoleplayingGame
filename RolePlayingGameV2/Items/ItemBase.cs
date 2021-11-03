using RolePlayingGameV2.Interfaces;

namespace RolePlayingGameV2.Items
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
