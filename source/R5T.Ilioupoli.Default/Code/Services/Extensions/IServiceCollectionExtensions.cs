using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Ilioupoli.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="TestingDataDirectoryContentConventions"/> implementation of <see cref="ITestingDataDirectoryContentConventions"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultTestingDataDirectoryContentConventions(this IServiceCollection services)
        {
            services.AddSingleton<ITestingDataDirectoryContentConventions, TestingDataDirectoryContentConventions>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="TestingDataDirectoryContentConventions"/> implementation of <see cref="ITestingDataDirectoryContentConventions"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<ITestingDataDirectoryContentConventions> AddDefaultTestingDataDirectoryContentConventionsAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<ITestingDataDirectoryContentConventions>(() => services.AddDefaultTestingDataDirectoryContentConventions());
            return serviceAction;
        }
    }
}
