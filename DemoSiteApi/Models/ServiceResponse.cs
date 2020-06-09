// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceResponse.cs" company="visual-programming">
//   All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DemoSiteApi.Models
{
    /// <summary>
    /// The service response
    /// </summary>
    public class ServiceResponse
    {
        /// <summary>
        /// Gets or sets a value indicating whether the action was successful
        /// </summary>
        public bool ActionSuccess { get; set; }

        /// <summary>
        /// Gets or sets a message associated with the action
        /// </summary>
        public string ActionMessage { get; set; }
    }
}
