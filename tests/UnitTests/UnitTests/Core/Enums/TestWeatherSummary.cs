using System;
using Xunit;

namespace My‏FirstRepository.Core.Enums
{
    public sealed class TestWeatherSummary
    {
        [Theory]
        [InlineData(1, nameof(WeatherSummary.Freezing))]
        [InlineData(2, nameof(WeatherSummary.Bracing))]
        [InlineData(3, nameof(WeatherSummary.Chilly))]
        [InlineData(4, nameof(WeatherSummary.Cool))]
        [InlineData(5, nameof(WeatherSummary.Mild))]
        [InlineData(6, nameof(WeatherSummary.Warm))]
        [InlineData(7, nameof(WeatherSummary.Balmy))]
        [InlineData(8, nameof(WeatherSummary.Hot))]
        [InlineData(9, nameof(WeatherSummary.Sweltering))]
        [InlineData(10, nameof(WeatherSummary.Scorching))]
        public void NameFromValue(Int32 value, String expectedName)
        {
            Assert.Equal(expectedName, WeatherSummary.FromValue(value).Name);
        }

        [Theory]
        [InlineData(nameof(WeatherSummary.Freezing), 1)]
        [InlineData(nameof(WeatherSummary.Bracing), 2)]
        [InlineData(nameof(WeatherSummary.Chilly), 3)]
        [InlineData(nameof(WeatherSummary.Cool), 4)]
        [InlineData(nameof(WeatherSummary.Mild), 5)]
        [InlineData(nameof(WeatherSummary.Warm), 6)]
        [InlineData(nameof(WeatherSummary.Balmy), 7)]
        [InlineData(nameof(WeatherSummary.Hot), 8)]
        [InlineData(nameof(WeatherSummary.Sweltering), 9)]
        [InlineData(nameof(WeatherSummary.Scorching), 10)]
        public void ValueFromName(String name, Int32 expectedValue)
        {
            Assert.Equal(expectedValue, WeatherSummary.FromName(name).Value);
        }
    }
}
