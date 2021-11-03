using System;

using R5T.T0063;
using R5T.T0067;


namespace R5T.T0062.X002
{
    public static class Instances
    {
        public static IServiceAction ServiceAction { get; } = T0062.ServiceAction.Instance;
        public static IServiceOperator ServiceOperator { get; } = T0067.ServiceOperator.Instance;
    }
}
