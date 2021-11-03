using System;


namespace R5T.T0062
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ServiceAction : IServiceAction
    {
        #region Static
        
        public static ServiceAction Instance { get; } = new ServiceAction();

        #endregion
    }
}