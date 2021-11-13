using RPG_V3.Interfaces;

namespace RPG_V3.Items
{
    class Item : IItem
    {
        public Item() 
        {
            Name = "";
            Value = 0.0;
            Weight = 0.0;
            Repair = 0.0;
        }

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

        public override string ToString()
        {
            return base.ToString();
        }

        public string Name { get; set; }
        public double Value { get; set; }
        public double Weight { get; set; }
        public double Repair { get; set; }
    }
}