using Microsoft.Extensions.DependencyInjection;

namespace MyFirstRepository.Core
{
    /// <summary>
    /// Defines a static class to implement an extension method to add all services from this assembly.
    /// </summary>
    public static class ServicesConfiguration
    {
        /// <summary>
        /// Adds all of the services found in the Core project.
        /// </summary>
        /// <param name="services">The extension method object reference.</param>
        public static void AddCoreServices(this IServiceCollection services)
        {
            // Add any services defined in this project to the passed collection.
        }
    }
}
