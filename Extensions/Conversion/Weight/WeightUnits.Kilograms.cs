namespace Extensions.Conversion.Weight.Kilograms;

public static partial class WeightUnits
{
    private static readonly double _poundsRatio = 2.20462262;
    private static readonly double _stoneRatio = 6.35029318;

    public static double KilogramsToPounds(this double value) => Math.Round(value * _poundsRatio, 2);

    public static double KilogramsToStone(this double value) => Math.Round(value / _stoneRatio, 2);
}