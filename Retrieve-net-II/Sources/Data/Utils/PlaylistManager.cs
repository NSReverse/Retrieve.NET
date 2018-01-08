using Retrieve_net_II.R;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
