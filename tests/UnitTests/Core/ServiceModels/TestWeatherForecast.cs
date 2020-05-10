using System;
using Xunit;

namespace MyFirstRepository.Core.ServiceModels
{
    public class TestWeatherForecast
    {
        [Fact]
        public void Properties()
        {
            var date = DateTime.Today;
            var temperatureC = 100;
            var summary = "Summary";

            var weatherForecast = new WeatherForecast();
            Assert.NotNull(weatherForecast);

            weatherForecast.Date = date;
            Assert.Equal(date, weatherForecast.Date);

            weatherForecast.TemperatureC = temperatureC;
            Assert.Equal(temperatureC, weatherForecast.TemperatureC);

            weatherForecast.Summary = summary;
            Assert.Equal(summary, weatherForecast.Summary);
        }

        [Theory]
        [InlineData(100, 212)]
        [InlineData(-75, -103)]
        [InlineData(0, 32)]
        public void TemperatureF(Int32 temperatureC, Int32 expectedTemperatureF)
        {
            var weatherForecast = new WeatherForecast { TemperatureC = temperatureC };
            Assert.Equal(expectedTemperatureF, weatherForecast.TemperatureF);
        }
    }
}
