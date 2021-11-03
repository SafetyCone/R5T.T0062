using System;


namespace R5T.T0062
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ServiceActionOperator : IServiceActionOperator
    {
        #region Static
        
        public static ServiceActionOperator Instance { get; } = new ServiceActionOperator();

        #endregion
    }
}