using System;

namespace MyFirstRepository.Core.ServiceModels
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public Int32 TemperatureC { get; set; }

        public Int32 TemperatureF => 32 + (Int32)(TemperatureC * 1.8);

        public String Summary { get; set; }
    }
}
