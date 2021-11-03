using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0062;
using R5T.T0063;


namespace System
{
    /// <summary>
    /// Basic <see cref="IServiceAction"/> extensions related to the <see cref="IServiceAction{TService}"/> type (like constructors).
    /// </summary>
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Get a do-nothing instance communicating that a service is added elsewhere (perhaps later, perhaps earlier).
        /// Useful for when a dependent service AddXAction() method requires an IServiceAction instance, but you know it will be added elsewhere (or are willing to risk the error if not) so you don't want to re-create the service action instance, or don't want decided what implementation to use for the instance.
        /// </summary>
        /// <remarks>
        /// Note: there should be no reason to use this method since it is now easy to pass service action instances. Still, this method is provided if needed. In that case, just ignore the obsolete warning at the call site.
        /// </remarks>
        [Obsolete("Is there no way to reorder program flow so a real service action instance or service action aggregation instance is available where required?\nIgnore if required.", false)]
        public static IServiceAction<TService> AddedElsewhere<TService>(this IServiceAction _)
        {
            var output = new DoNothingServiceAction<TService>();
            return output;
        }

        /// <summary>
        /// Get a do-nothing instance communicating that a service has already been added (in some other location).
        /// Useful for when a dependent service AddXAction() method requires an IServiceAction instance, but you know it was already added (or are willing to risk the error if not) so you don't want to re-create the service action instance, or don't want decided what implementation to use for the instance.
        /// </summary>
        /// <remarks>
        /// Note: there should be no reason to use this method since it is now easy to pass service action instances. Still, this method is provided if needed. In that case, just ignore the obsolete warning at the call site.
        /// </remarks>
        [Obsolete("Is there no way to request a real service action instance or service action aggregation instance as a parameter for this call site?\nIgnore if required.", false)]
        public static IServiceAction<TService> AlreadyAdded<TService>(this IServiceAction _)
        {
            var output = new DoNothingServiceAction<TService>();
            return output;
        }

        /// <summary>
        /// Constructor for <see cref="SingleRunServiceAction{TService}"/>.
        /// </summary>
        public static IServiceAction<TService> NewSingleRun<TService>(this IServiceAction _,
            Action<IServiceCollection> servicesAction)
        {
            var output = new SingleRunServiceAction<TService>(servicesAction);
            return output;
        }

        /// <summary>
        /// Chooses single-run (<see cref="IServiceActionExtensions.NewSingleRun{TService}(IServiceActionExtensionMethodBase, Action{IServiceCollection})"/>) as the default constructor for <see cref="IServiceAction{TService}"/> instances.
        /// </summary>
        public static IServiceAction<TService> New<TService>(this IServiceAction _,
            Action<IServiceCollection> servicesAction)
        {
            var output = _.NewSingleRun<TService>(servicesAction);
            return output;
        }
    }
}
