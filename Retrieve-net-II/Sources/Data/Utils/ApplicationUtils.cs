using Retrieve_net_II.R;
using Retrieve_net_II.Sources.Data.Utils;
using System;
using System.IO;

namespace Retrieve_net_II.Sources
{
    class ApplicationUtils
    {
        private const String TAG = "ApplicationUtils";

        public static bool CheckLibrary()
        {
            try
            {
                Directory.GetFiles(String.Format(Strings.libraryFormatPlaylists, PreferenceManager.GetLibraryLocation()));
                return true;
            }
            catch (Exception ex)
            {
                Log.D(TAG, ex.Message);
                return false;
            }
        }
    }
}
