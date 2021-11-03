using System;

using R5T.T0039.T002;


namespace R5T.T0062
{
    /// <summary>
    /// Base for extensions performing operations on service action aggregation instances.
    /// Like choosing specific implementations for service dependencies and building a dependent service actions out of dependency service actions, for example.
    /// </summary>
    [ExtensionMethodBaseMarker]
    public interface IServiceActionAggregationOperator
    {
    }
}