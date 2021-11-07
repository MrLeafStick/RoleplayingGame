using System;

namespace RoleplayingGame
{
    public static class NumberGenerator
    {
        private static Random _generator = new Random(Guid.NewGuid().GetHashCode());

        public static int Next(int min, int max)
        {
            int value = min + _generator.Next(max - min);
            return value;
        }

        public static bool BelowPercentage(int percentage)
        {
            int generatedPercentage = Next(0, 100);
            return generatedPercentage < percentage;
        }
    }
}
