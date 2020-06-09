// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WeatherService.cs" company="visual-programming">
//   All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DemoSiteApi.Services
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    using DemoSiteApi.Interfaces;
    using DemoSiteApi.Models.WeatherService;

    using Newtonsoft.Json.Linq;

    /// <inheritdoc cref="IWeatherService"/>
    public class WeatherService : IWeatherService
    {
        /// <summary>
        /// Gets the http client
        /// </summary>
        private readonly HttpClient httpClient = new HttpClient();

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherService"/> class
        /// </summary>
        public WeatherService()
        {
            this.httpClient.DefaultRequestHeaders.Add("User-Agent", "(Demo Weather Micro-service, visualprogramming@gmail.com)");
        }

        /// <inheritdoc cref="IWeatherService.GetWeatherByGeoLocation"/>
        public async Task<WeatherResponse> GetWeatherByGeoLocation(GeoLocation geoLocation)
        {
            var response = new WeatherResponse { ActionSuccess = true };
            try
            {
                var pointsData = await this.GetPointsData(geoLocation);
                response.City = pointsData.City;
                response.State = pointsData.State;

                var json = this.httpClient.GetStringAsync(pointsData.HourlyForecastUrl);
                var data = JObject.Parse(await json);
                var current = data["properties"]?["periods"]?[0];
                response.Temperature = $"{current?["temperature"]}{current?["temperatureUnit"]}";
            }
            catch (Exception ex)
            {
                response.ActionSuccess = false;
                response.ActionMessage = ex.Message;
            }

            return response;
        }

        /// <summary>
        /// Gets the points data based on the provided geo location
        /// </summary>
        /// <param name="geoLocation">The geo location</param>
        /// <returns>A points response</returns>
        private async Task<PointsResponse> GetPointsData(GeoLocation geoLocation)
        {
            var url = $"https://api.weather.gov/points/{geoLocation.Latitude},{geoLocation.Longitude}";
            var json = this.httpClient.GetStringAsync(url);
            var data = JObject.Parse(await json);
            var properties = data["properties"];
            var locationProperties = properties?["relativeLocation"]?["properties"];
            return new PointsResponse
                       {
                           City = locationProperties?["city"]?.ToString(),
                           State = locationProperties?["state"]?.ToString(),
                           HourlyForecastUrl = properties?["forecastHourly"]?.ToString()
                       };
        }
    }
}
