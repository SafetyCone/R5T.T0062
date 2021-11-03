using System;


namespace R5T.T0062
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ServiceActionAggregation : IServiceActionAggregation
    {
        #region Static
        
        public static ServiceActionAggregation Instance { get; } = new ServiceActionAggregation();

        #endregion
    }
}