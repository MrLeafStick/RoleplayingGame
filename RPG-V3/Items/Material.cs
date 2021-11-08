using RPG_V3.Interfaces.Items;
using System.Collections.Generic;

namespace RPG_V3.Items
{
    class Material : IMaterial
    {
        private Material(string name) { Name = name; }
        public string Name { get; }
        public string Strength { get; }

        public static Material Leather { get { return new Material("leather"); } }
        public static Material Wood { get { return new Material("wood"); } }
        public static Material Flint { get { return new Material("flint"); } }
        public static Material Stone { get { return new Material("stone"); } }
        public static Material Copper { get { return new Material("copper"); } }
        public static Material Lead { get { return new Material("lead"); } }
        public static Material Tin { get { return new Material("tin"); } }
        public static Material Bronze { get { return new Material("bronze"); } }
        public static Material Iron { get { return new Material("iron"); } }
        public static Material Steel { get { return new Material("steel"); } }
        public static Material Diamond { get { return new Material("diamond"); } }
        public static Material Crystal { get { return new Material("crystal"); } }
        public static Material Ice { get { return new Material("ice"); } }

        public static List<Material> List()
        {
            return new List<Material> { Leather, Wood, Flint, Stone, Copper, Lead, Tin, Bronze, Iron, Steel, Diamond, Crystal, Ice };
        }
    }
}
