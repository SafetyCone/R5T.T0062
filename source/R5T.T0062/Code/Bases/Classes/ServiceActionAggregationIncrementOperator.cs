using System;


namespace R5T.T0062
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ServiceActionAggregationIncrementOperator : IServiceActionAggregationIncrementOperator
    {
        #region Static
        
        public static ServiceActionAggregationIncrementOperator Instance { get; } = new ServiceActionAggregationIncrementOperator();

        #endregion
    }
}