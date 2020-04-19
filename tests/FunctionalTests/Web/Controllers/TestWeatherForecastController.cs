using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using MyFirstRepository.Core.ServiceModels;
using Xunit;

namespace MyFirstRepository.Web.Controllers
{
    public sealed class TestWeatherForecastController : IClassFixture<WebApplicationFactory<Startup>>
    {
        public TestWeatherForecastController(WebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        private readonly HttpClient _client;

        [Fact]
        public async Task Get()
        {
            HttpResponseMessage response = await _client.GetAsync("/WeatherForecast");
            Assert.True(response.IsSuccessStatusCode);
            String stringResponse = await response.Content.ReadAsStringAsync();

            Assert.NotNull(stringResponse);
            Assert.NotEmpty(stringResponse);

            IEnumerable<WeatherForecast> weatherForecasts = JsonSerializer.Deserialize<IEnumerable<WeatherForecast>>(stringResponse);
            Assert.NotEmpty(weatherForecasts);
        }
    }
}
