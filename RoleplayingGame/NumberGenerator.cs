﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    public static class NumberGenerator
    {
        private static Random _generator = new Random();

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