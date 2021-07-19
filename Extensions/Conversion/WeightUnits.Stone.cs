using System;

namespace Extensions.Conversion.WeightUnits.Stone
{
    public static partial class WeightUnits
    {
        private static double _kilogramsRatio = 6.35029318;
        private static double _poundsRatio = 0.0714285714;

        public static double StoneToKilograms(this double value) => Math.Round(value * _kilogramsRatio, 2);

        public static double StoneToPounds(this double value) => Math.Round(value / _poundsRatio, 2);
    }
}
