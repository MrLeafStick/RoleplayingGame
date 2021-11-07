using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_V3.Helpers
{
    public class Randomizer
    {
        public static Random _generator = new Random(Guid.NewGuid().GetHashCode());

        public static int RandomInt(int minVal, int maxVal)
        {
            return _generator.Next(minVal, maxVal + 1);
        }

        public static int RandomPercent()
        {
            return _generator.Next(0, 100 + 1);
        }

        public static double RandomDouble(double minVal, double maxVal)
        {
            return _generator.NextDouble() * (maxVal - minVal) + minVal;
        }

        public static bool CoinFlip()
        {
            return RandomPercent() < 50;
        }

        public static string GenerateName()
        {
            List<string> generator = new List<string> { "xan", "tran", "ser", "mor", "houl", "zuur", "raz", "qex", "sir", "zor", "vaar", "khon", "an", "bel", "lin" };

            var name = generator[Randomizer.RandomInt(0, generator.Count - 1)] +
                       generator[Randomizer.RandomInt(0, generator.Count - 1)] +
                       generator[Randomizer.RandomInt(0, generator.Count - 1)];

            name = name.Substring(0, 1).ToUpper() + name.Substring(1, name.Length - 1);

            return name;
        }

        public static T GetRandom<T>(List<T> list)
        {
            return list.ElementAt(_generator.Next(0, list.Count));
        }
    }
}
