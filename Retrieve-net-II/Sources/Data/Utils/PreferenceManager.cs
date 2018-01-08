using Retrieve_net_II.R.Configurations;
using System;

namespace Retrieve_net_II.Sources.Data.Utils
{
    class PreferenceManager
    {
        public static int GetSearchResultLimit()
        {
            if (Retrieve.Default.SearchResultLimit > 250 || Retrieve.Default.SearchResultLimit < 1)
            {
                Retrieve.Default.SearchResultLimit = 50;
                Retrieve.Default.Save();
            }

            return Retrieve.Default.SearchResultLimit;
        }

        public static string GetLibraryLocation()
        {
            return Retrieve.Default.LibraryLocation;
        }

        public static bool GetUseDevelopmentServer()
        {
            return Retrieve.Default.UseDevelopmentServer;
        }

        public static void ResetDefaults()
        {
            Retrieve.Default.LibraryLocation = "";
            Retrieve.Default.SearchResultLimit = 50;
            Retrieve.Default.UseDevelopmentServer = false;
            Retrieve.Default.Save();
        }

        public static void SetDefaults(string libraryLocation, int resultLimit, bool useDevelopmentServer) 
        {
            Retrieve.Default.LibraryLocation = libraryLocation;
            Retrieve.Default.SearchResultLimit = resultLimit;
            Retrieve.Default.UseDevelopmentServer = useDevelopmentServer;
            Retrieve.Default.Save();
        }
    }
}
