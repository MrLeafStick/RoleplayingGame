using RPG_V3.Interfaces.Items;
using System.Collections.Generic;

namespace RPG_V3.Items
{
    class Material : IMaterial
    {
        private Material(string name, double strength, double value, double weight) 
        { 
            Name = name;
            StrengthModifier = strength;
            ValueModifier = value;
            WeightModifier = weight;
        }

        public string Name { get; }
        public double StrengthModifier { get; }
        public double ValueModifier { get; }
        public double WeightModifier { get; }

        public static Material Leather { get { return new Material("leather", 0.8, 50.0, 7.0); } }
        public static Material Wood { get { return new Material("wood", 0.5, 50.0, 7.0); } }
        public static Material Flint { get { return new Material("flint", 0.9, 50.0, 7.0); } }
        public static Material Stone { get { return new Material("stone", 0.7, 50.0, 7.0); } }
        public static Material Gold { get { return new Material("gold", 0.1, 50.0, 7.0); } }
        public static Material Silver { get { return new Material("silver", 0.3, 50.0, 7.0); } }
        public static Material Copper { get { return new Material("copper", 0.2, 50.0, 7.0); } }
        public static Material Lead { get { return new Material("lead", 0.1, 50.0, 7.0); } }
        public static Material Tin { get { return new Material("tin", 0.1, 50.0, 7.0); } }
        public static Material Bronze { get { return new Material("bronze", 0.6, 50.0, 7.0); } }
        public static Material Iron { get { return new Material("iron", 0.7, 50.0, 7.0); } }
        public static Material Steel { get { return new Material("steel", 0.8, 50.0, 7.0); } }
        public static Material Diamond { get { return new Material("diamond", 1.0, 50.0, 7.0); } }
        public static Material Crystal { get { return new Material("crystal", 0.8, 50.0, 7.0); } }
        public static Material Ice { get { return new Material("ice", 0.4, 50.0, 7.0); } }
        public static Material None { get { return new Material("none", 0.0, 0.0, 0.0); } }

        public static List<Material> List()
        {
            return new List<Material> 
            { 
                Leather, Wood, Flint, Stone, Gold, Silver, Copper, Lead, Tin, Bronze, Iron, Steel, Diamond, Crystal, Ice 
            };
        }

        public static List<Material> WeaponMaterials()
        {
            return new List<Material> 
            { 
                Flint, Stone, Copper, Bronze, Iron, Steel, Diamond, Crystal 
            };
        }

        public static List<Material> ArmorMaterials()
        {
            return new List<Material>
            {
                Leather, Wood, Copper, Lead, Tin, Bronze, Iron, Steel
            };
        }

        public static List<Material> Metals()
        {
            return new List<Material>
            {
                Silver, Gold, Copper, Bronze, Iron, Steel
            };
        }
    }
}

// TODO: add Material child classes Metal, Stone, Organic, etc.
