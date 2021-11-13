using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V3.Helpers
{
    public static class MathFunctions
    {

        public static double Lerp(double minValue, double maxValue, double n)
        {
            return minValue + n * (maxValue - minValue);
        }

    }
}
