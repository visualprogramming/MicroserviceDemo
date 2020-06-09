// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PointsResponse.cs" company="visual-programming">
//   All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DemoSiteApi.Models.WeatherService
{
    /// <summary>
    /// The points response
    /// </summary>
    public class PointsResponse
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
        /// Gets or sets the hourly forecast url
        /// </summary>
        public string HourlyForecastUrl { get; set; }
    }
}
