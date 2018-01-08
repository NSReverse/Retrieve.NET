using Retrieve_net_II.R;
using System;
using System.IO;

namespace Retrieve_net_II.Sources.Data.Utils
{
    class PlaylistManager
    {
        public static string[] GetAllPlaylistFiles()
        {
            return Directory.GetFiles(String.Format(Strings.libraryFormatPlaylists, PreferenceManager.GetLibraryLocation()));
        }
    }
}
