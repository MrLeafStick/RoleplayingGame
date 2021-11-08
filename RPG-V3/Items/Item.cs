using RPG_V3.Interfaces;

namespace RPG_V3.Items
{
    class Item : IItem
    {
        public string Name { get; }
        public double Value { get; }
        public double Weight { get; }
        
        //public double RepairState { get; }
    }
}
