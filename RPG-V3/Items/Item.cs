using RPG_V3.Interfaces;

namespace RPG_V3.Items
{
    class Item : IItem
    {
        public Item(Item item)
        {
            Name = item.Name;
            Value = item.Value;
            Weight = item.Weight;
        }

        public Item(string name, double value, double weight)
        {
            Name = name;
            Value = value;
            Weight = weight;
        }

        public string Name { get; set; }
        public double Value { get; set; }
        public double Weight { get; set; }

        //public double RepairState { get; }
    }
}
