// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ErrorViewModel.cs" company="visual-programming">
//   All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DemoSite.Models
{
    /// <summary>
    /// The error view model
    /// </summary>
    public class ErrorViewModel
    {
        /// <summary>
        /// Gets or sets the request id
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Gets a value indicating whether the request id can be shown
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(this.RequestId);
    }
}
