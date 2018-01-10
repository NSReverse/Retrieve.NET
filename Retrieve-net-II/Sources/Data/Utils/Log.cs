using Retrieve_net_II.R;
using System;

namespace Retrieve_net_II.Sources.Data.Utils
{
    class Log
    {
        public static void D(string tag, string message)
        {
            if (ApplicationConfig.loggingEnabled)
            {
                string output = String.Format("{0} > {1}", tag, message);
                System.Diagnostics.Debug.WriteLine(output);
            }
        }
    }
}
