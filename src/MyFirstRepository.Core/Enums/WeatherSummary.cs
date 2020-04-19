using System;
using Ardalis.SmartEnum;

namespace MyFirstRepository.Core.Enums
{
    public sealed class WeatherSummary : SmartEnum<WeatherSummary, Int32>
    {
        private WeatherSummary(String name, Int32 value) : base(name, value) { }

        public static readonly WeatherSummary Freezing = new WeatherSummary(nameof(Freezing), 1);
        public static readonly WeatherSummary Bracing = new WeatherSummary(nameof(Bracing), 2);
        public static readonly WeatherSummary Chilly = new WeatherSummary(nameof(Chilly), 3);
        public static readonly WeatherSummary Cool = new WeatherSummary(nameof(Cool), 4);
        public static readonly WeatherSummary Mild = new WeatherSummary(nameof(Mild), 5);
        public static readonly WeatherSummary Warm = new WeatherSummary(nameof(Warm), 6);
        public static readonly WeatherSummary Balmy = new WeatherSummary(nameof(Balmy), 7);
        public static readonly WeatherSummary Hot = new WeatherSummary(nameof(Hot), 8);
        public static readonly WeatherSummary Sweltering = new WeatherSummary(nameof(Sweltering), 9);
        public static readonly WeatherSummary Scorching = new WeatherSummary(nameof(Scorching), 10);
    }
}
