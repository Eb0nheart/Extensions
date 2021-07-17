using Extensions.Conversion;
using NUnit.Framework;

namespace ExtensionsTests.ConversionTests
{
    public class TemperatureUnitsTests
    {
        [Test]
        public void CelsiusToFahrenheit_Works()
        {
            double value = 22.0;
            double expectedResult = 71.6;

            double result = value.CelsiusToFahrenheit();

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void CelsiusToKelvin_Works()
        {
            double value = 22.0;
            double expectedResult = 295.15;

            double result = value.CelsiusToKelvin();

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void FahrenheitToCelsius_Works()
        {
            double value = 71.6;
            double expectedResult = 22.0;

            double result = value.FahrenheitToCelsius();

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void FahrenheitToKelvin_Works()
        {
            double value = 71.6;
            double expectedResult = 295.15;

            double result = value.FahrenheitToKelvin();

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void KelvinToCelsius_Works()
        {
            double value = 295.15;
            double expectedResult = 22.0;

            double result = value.KelvinToCelsius();

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void KelvinToFahrenheit_Works()
        {
            double value = 295.15;
            double expectedResult = 71.6;

            double result = value.KelvinToFahrenheit();

            Assert.AreEqual(expectedResult, result);
        }
    }
}
