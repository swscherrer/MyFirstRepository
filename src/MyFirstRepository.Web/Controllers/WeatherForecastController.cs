using Ardalis.SmartEnum;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyFirstRepository.Core.Enums;
using MyFirstRepository.Core.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstRepository.Web.Controllers
{
    /// <summary>
    /// The controller to support weather forecast methods.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly String[] Summaries = WeatherSummary.List.Select(summary => summary.Name).ToArray();

        private readonly ILogger<WeatherForecastController> _logger;

        /// <summary>
        /// A parameterized constructor to capture the various services used by the controller.
        /// </summary>
        /// <param name="logger">A reference to the <see cref="ILogger"/> service to use for logging.</param>
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// The GET method for the controller.
        /// </summary>
        /// <returns>A collection of <see cref="WeatherForecast"/> objects.</returns>
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
