using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_V3.Helpers
{
    public class RNG
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

        public T GetRandom<T>(List<T> list)
        {
            return list.ElementAt(_generator.Next(0, list.Count));
        }
    }
}
