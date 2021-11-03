using System;

using R5T.D0085;
using R5T.T0062;
using R5T.T0063;

using Instances = R5T.T0062.X002.Instances;


namespace System
{
    public static class IServiceActionOperatorExtensions
    {
        /// <summary>
        /// Programmatically create a service action for a service from a service action for a <see cref="IServicesConfigurer"/>.
        /// </summary>
        public static IServiceAction<TService> GetServiceAction<TService, TServicesConfigurer>(this IServiceActionOperator _,
            IServiceAction<TServicesConfigurer> servicesConfigurerAction)
            where TServicesConfigurer : IServicesConfigurer
        {
            var output = Instances.ServiceAction.New<TService>(services =>
            {
                SyncOverAsyncHelper.ExecuteSynchronously(async () =>
                {
                    using var servicesConfigurerServiceProvider = Instances.ServiceOperator.GetServiceInstance(
                        servicesConfigurerAction,
                        out TServicesConfigurer servicesConfigurer);

                    await servicesConfigurer.ConfigureServices(services);
                });
            });

            return output;
        }
    }
}