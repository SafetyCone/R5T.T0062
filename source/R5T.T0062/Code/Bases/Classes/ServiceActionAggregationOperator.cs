using System;


namespace R5T.T0062
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ServiceActionAggregationOperator : IServiceActionAggregationOperator
    {
        #region Static
        
        public static ServiceActionAggregationOperator Instance { get; } = new ServiceActionAggregationOperator();

        #endregion
    }
}