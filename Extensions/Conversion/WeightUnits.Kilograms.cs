using System;

namespace Extensions.Conversion.WeightUnits.Kilograms
{
    public static partial class WeightUnits
    {
        private static double _poundsRatio = 2.20462262;
        private static double _stoneRatio = 6.35029318;

        public static double KilogramsToPounds(this double value) => Math.Round(value * _poundsRatio, 2);

        public static double KilogramsToStone(this double value) => Math.Round(value / _stoneRatio, 2);
    }
}
