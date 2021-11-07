using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGameV2.Helpers
{
    public class RNG
    {
        private static Random _generator = new Random(Guid.NewGuid().GetHashCode());

        const int MAX_PERCENT_VALUE = 100;

        public static int RandomInt(int minValue, int maxValue)
        {
            return _generator.Next(minValue, maxValue + 1);
        }

        public static int RandomPercent()
        {
            return _generator.Next(0, MAX_PERCENT_VALUE + 1);
        }

        public static double RandomDouble(double minValue, double maxValue)
        {
            return _generator.NextDouble() * (maxValue - minValue) + minValue;
        }

        public static bool CoinFlip()
        {
            return RandomPercent() < 50;
        }
    }
}
