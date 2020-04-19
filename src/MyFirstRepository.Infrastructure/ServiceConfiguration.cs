using Microsoft.Extensions.DependencyInjection;

namespace MyFirstRepository.Infrastructure
{
    /// <summary>
    /// Defines a static class to implement an extension method to add all services from this assembly.
    /// </summary>
    public static class ServiceConfiguration
    {
        /// <summary>
        /// Adds all of the services found in the Infrastructure project.
        /// </summary>
        /// <param name="services">The extension method object reference.</param>
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            // Add any services defined in this project to the passed collection.
        }
    }
}
