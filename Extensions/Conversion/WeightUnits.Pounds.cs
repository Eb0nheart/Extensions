using System;

namespace Extensions.Conversion.WeightUnits.Pounds
{
    public static partial class WeightUnits
    {
        private static double _kilogramsRatio = 2.20462262;
        private static double _stoneRatio = 0.0714285714;

        public static double PoundsToKilograms(this double value) => Math.Round(value / _kilogramsRatio, 2);

        public static double PoundsToStone(this double value) => Math.Round(value * _stoneRatio, 2);
    }
}
