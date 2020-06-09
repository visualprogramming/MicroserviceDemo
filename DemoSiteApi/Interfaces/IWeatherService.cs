// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IWeatherService.cs" company="visual-programming">
//   All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DemoSiteApi.Interfaces
{
    using System.Threading.Tasks;

    using DemoSiteApi.Models.WeatherService;

    /// <summary>
    /// The weather service interface
    /// </summary>
    public interface IWeatherService
    {
        /// <summary>
        /// Gets the current weather data for the specified geo location
        /// </summary>
        /// <param name="geoLocation">The geo location</param>
        /// <returns>A weather response</returns>
        Task<WeatherResponse> GetWeatherByGeoLocation(GeoLocation geoLocation);
    }
}
