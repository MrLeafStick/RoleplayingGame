using RPG_V3.Interfaces;
using RPG_V3.Helpers;
using System.Collections.Generic;

namespace RPG_V3.Items
{
    class Armor : Item, IArmor
    {
        
        public static Armor None { get { return new Armor(ArmorCategory.None, Material.None, 0.0, 0.0, 0.0, 0.0); } }


        public Armor(ArmorCategory category, Material material, double value, double weight, double maxArmorPoints, double minArmorPoints)
            : base(value, weight)
        {
            Category = category;
            Material = material;
            Name = GenerateName();
            MaxDamageReduction = maxArmorPoints;
            MinDamageReduction = minArmorPoints;
        }

        public Armor(ArmorCategory category, Material material) : base()
        {
            Category = category;
            Material = material;
            Name = GenerateName();
            MaxDamageReduction = CalculateMaxDamageReduction();
            MinDamageReduction = CalculateMinDamageReduction();
        }

        public Armor(Armor armor) : base(armor)
        {
            Category = armor.Category;
            Material = armor.Material;
            MaxDamageReduction = armor.MaxDamageReduction;
            MinDamageReduction = armor.MinDamageReduction;
        }

        private string GenerateName()
        {
            var name = Material.Name + Category.Name;

            return name.Substring(0, 1).ToUpper() + name.Substring(1, name.Length - 1).ToLower();
        }

        public void CalculateArmorRepair(double maxGivenDamage)
        {
            Repair -= maxGivenDamage * 0.001;
            
            if (Repair < 0.0) Repair = 0.0;
        }

        public double CalculatedReducedDamage(double maxGivenDamage)
        {
            return maxGivenDamage * MathFunctions.Lerp(MinDamageReduction, MaxDamageReduction, Repair) * Material.StrengthModifier;
        }

        private double CalculateMaxDamageReduction()
        {
            return Material.StrengthModifier;
        }

        private double CalculateMinDamageReduction()
        {
            return Material.StrengthModifier * 0.01;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        
        public static List<Armor> List()
        {
            return new List<Armor> { None };
        }
        

        public ArmorCategory Category { get; }
        public Material Material { get; } // TODO: move material to Item.
        public double MaxDamageReduction { get; }
        public double MinDamageReduction { get; }
        public bool IsBroken { get { return Repair <= 0.0; } }
    }
}
