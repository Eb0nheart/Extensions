using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.Conversion
{
    public static class TemperatureUnits
    {
        public static double CelsiusToFahrenheit(this double value)
        {
            // (0°C × 9/5) + 32 = 32°F
            return (value * 9 / 5) + 32;
        }

        public static double CelsiusToKelvin(this double value)
        {
            // 0°C + 273.15 = 273,15K
            return value + 273.15;
        }

        public static double FahrenheitToCelsius(this double value)
        {
            // (32°F − 32) × 5/9 = 0°C
            return Math.Round((value - 32) * 5 / 9, 2);
        }

        public static double FahrenheitToKelvin(this double value)
        {
            // (32°F − 32) × 5/9 + 273.15 = 273,15K
            return Math.Round((value - 32) * 5 / 9, 2) + 273.15;
        }

        public static double KelvinToCelsius(this double value)
        {
            // 273.15K - 273.15 = 0°C
            return value - 273.15;
        }

        public static double KelvinToFahrenheit(this double value)
        {
            // (0K − 273.15) × 9/5 + 32 = -459,7°F
            return (value - 273.15) * 9 / 5 + 32;
        }
    }
}
