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
            Repair = item.Repair;
        }

        public Item(double value, double weight)
        {
            Value = value;
            Weight = weight;
        }

        public Item(string name, double value, double weight, double repair)
        {
            Name = name;
            Value = value;
            Weight = weight;
            Repair = repair;
        }

        public string Name { get; set; }
        public double Value { get; set; }
        public double Weight { get; set; }
        public double Repair { get; set; }
    }
}