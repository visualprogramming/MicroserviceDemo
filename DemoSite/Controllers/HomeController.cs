// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeController.cs" company="visual-programming">
//   All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DemoSite.Controllers
{
    using System.Diagnostics;
    using System.Threading.Tasks;

    using DemoSite.Models;

    using DemoSiteApi.Interfaces;
    using DemoSiteApi.Models.WeatherService;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    /// <inheritdoc cref="Controller"/>
    public class HomeController : Controller
    {
        /// <summary>
        /// The logger
        /// </summary>
        private readonly ILogger<HomeController> logger;

        /// <summary>
        /// The weather service
        /// </summary>
        private readonly IWeatherService weatherService;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class
        /// </summary>
        /// <param name="logger">The logger</param>
        /// <param name="weatherService">The weather service</param>
        public HomeController(ILogger<HomeController> logger, IWeatherService weatherService)
        {
            this.logger = logger;
            this.weatherService = weatherService;
        }

        /// <summary>
        /// Gets the index page
        /// </summary>
        /// <returns>The index view</returns>
        public async Task<IActionResult> Index()
        {
            var geoLocation = new GeoLocation { Latitude = 25.79335, Longitude = -80.13491 }; // Miami Beach, FL
            var weatherData = await this.weatherService.GetWeatherByGeoLocation(geoLocation);
            var viewModel = new WeatherViewModel
                                {
                                    Location = $"{weatherData.City}, {weatherData.State}",
                                    Temperature = weatherData.Temperature
                                };

            return this.View(viewModel);
        }

        /// <summary>
        /// Gets the privacy page
        /// </summary>
        /// <returns>The privacy view</returns>
        public IActionResult Privacy()
        {
            return this.View();
        }

        /// <summary>
        /// Gets the error page
        /// </summary>
        /// <returns>The error view</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
