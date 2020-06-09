// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WeatherResponse.cs" company="visual-programming">
//   All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DemoSiteApi.Models.WeatherService
{
    /// <summary>
    /// The weather data
    /// </summary>
    public class WeatherResponse : ServiceResponse
    {
        /// <summary>
        /// Gets or sets the city
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the temperature
        /// </summary>
        public string Temperature { get; set; }
    }
}
