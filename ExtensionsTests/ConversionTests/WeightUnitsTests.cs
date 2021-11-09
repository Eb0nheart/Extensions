using Extensions.Conversion.Weight.Kilograms;
using Extensions.Conversion.Weight.Pounds;
using Extensions.Conversion.Weight.Stone;

namespace ExtensionsTests.ConversionTests;

public class WeightUnitsTests
{
    [Test]
    public void KilogramsToPounds_Works()
    {
        double value = 22.0;
        double expectedValue = 48.50;

        double result = value.KilogramsToPounds();

        Assert.AreEqual(expectedValue, result);
    }

    [Test]
    public void KilogramsToStone_Works()
    {
        double value = 22.0;
        double expectedValue = 3.46;

        double result = value.KilogramsToStone();

        Assert.AreEqual(expectedValue, result);
    }

    [Test]
    public void PoundsToKilograms_Works()
    {
        double value = 48.50;
        double expectedValue = 22.0;

        double result = value.PoundsToKilograms();

        Assert.AreEqual(expectedValue, result);
    }

    [Test]
    public void PoundsToStone_Works()
    {
        double value = 48.50;
        double expectedValue = 3.46;

        double result = value.PoundsToStone();

        Assert.AreEqual(expectedValue, result);
    }

    [Test]
    public void StoneToKilograms_Works()
    {
        double value = 3.46;
        double expectedValue = 21.97;

        double result = value.StoneToKilograms();

        Assert.AreEqual(expectedValue, result);
    }

    [Test]
    public void StoneToPounds_Works()
    {
        double value = 3.46;
        double expectedValue = 48.44;

        double result = value.StoneToPounds();

        Assert.AreEqual(expectedValue, result);
    }
}