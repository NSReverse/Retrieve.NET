using Retrieve_net_II.R;
using Retrieve_net_II.Sources.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace Retrieve_net_II.Sources.Data.Utils
{
    class PlaylistManager
    {
        public interface Delegate
        {
            void PlaylistAdded();
        }

        public static HashSet<PlaylistInfo> GetAllPlaylistFiles()
        {
            string[] paths;
            HashSet<PlaylistInfo> playlistSet = new HashSet<PlaylistInfo>();

            if (ApplicationUtils.CheckLibrary())
            {
                paths = Directory.GetFiles(String.Format(Strings.libraryFormatPlaylists, PreferenceManager.GetLibraryLocation()));

                foreach (string currentPath in paths)
                {
                    PlaylistInfo currentInfo = XmlSerializer.Deserialize(currentPath, false);
                    playlistSet.Add(currentInfo);
                }
            }
            else
            {
                QuickAlert.ShowError("Error", "Library path is invalid. Please create a folder or point to an existing library in settings.");
            }

            return playlistSet;
        }

        public static void AddPlaylist(PlaylistInfo info, Delegate playlistDelegate)
        {
            XmlSerializer.Serialize(info);

            if (playlistDelegate != null)
            {
                playlistDelegate.PlaylistAdded();
            }
        }

        public static void RemovePlaylist(PlaylistInfo info)
        {
            string playlistPath = String.Format(Strings.libraryFormatPlaylists + info.UUID + ".xml", PreferenceManager.GetLibraryLocation());

            if (File.Exists(playlistPath)) { File.Delete(playlistPath); }
        }

        public void AddItemToPlaylist(VideoInfo video, PlaylistInfo playlist)
        {
            if (!playlist.idSet.Contains(video.youtubeID))
            {
                playlist.idSet.Add(video.youtubeID);
            }

            XmlSerializer.Serialize(playlist);
        }

        public void RemoveItemFromPlaylist(VideoInfo video, PlaylistInfo playlist)
        {
            if (playlist.idSet.Contains(video.youtubeID))
            {
                playlist.idSet.Remove(video.youtubeID);
            }

            XmlSerializer.Serialize(playlist);
        }
    }
}
