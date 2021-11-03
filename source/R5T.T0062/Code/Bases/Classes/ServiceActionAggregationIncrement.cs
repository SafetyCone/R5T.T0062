using System;


namespace R5T.T0062
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ServiceActionAggregationIncrement : IServiceActionAggregationIncrement
    {
        #region Static
        
        public static ServiceActionAggregationIncrement Instance { get; } = new ServiceActionAggregationIncrement();

        #endregion
    }
}