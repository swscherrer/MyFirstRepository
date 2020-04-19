using System;

namespace MyFirstRepository.Core.ServiceModels
{
    /// <summary>
    /// Defines the properties for the <see cref="WeatherForecast"/> service model.
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// The date for the weather forecast.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// The temperature, in celsius.
        /// </summary>
        public Int32 TemperatureC { get; set; }

        /// <summary>
        /// The temperature, in farenheit.
        /// </summary>
        public Int32 TemperatureF => 32 + (Int32)(TemperatureC * 1.8);

        /// <summary>
        /// A summary description of the weather forecast.
        /// </summary>
        public String Summary { get; set; }
    }
}
