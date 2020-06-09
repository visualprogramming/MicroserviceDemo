// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="visual-programming">
//   All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DemoSite
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Hosting;

    /// <summary>
    /// The program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main entry point to the application
        /// </summary>
        /// <param name="args">The args</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Creates the host builder
        /// </summary>
        /// <param name="args">The args</param>
        /// <returns>Host builder</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                    {
                        webBuilder.UseStartup<Startup>();
                    });
    }
}