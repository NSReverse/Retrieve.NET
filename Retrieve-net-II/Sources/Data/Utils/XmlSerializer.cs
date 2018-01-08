using Retrieve_net_II.R;
using Retrieve_net_II.Sources.Model;
using System;
using System.Drawing;
using System.IO;

namespace Retrieve_net_II.Sources.Data.Utils
{
    class XmlSerializer
    {
        public static void Serialize(VideoInfo info)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(VideoInfo));

            string dataPath = String.Format(Strings.libraryFormatMetadata, PreferenceManager.GetLibraryLocation());

            FileStream dataFile = File.Create(dataPath + info.youtubeID + ".xml");
            serializer.Serialize(dataFile, info);
            dataFile.Close();
        }

        public static VideoInfo Deserialize(string filename)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(VideoInfo));

            string dataPath = String.Format(Strings.libraryFormatMetadata, PreferenceManager.GetLibraryLocation());

            FileStream dataFile = File.Open(filename, FileMode.Open);
            VideoInfo currentInfo = (VideoInfo)serializer.Deserialize(dataFile);
            dataFile.Close();

            string thumbPath = String.Format(Strings.libraryFormatThumbnails, PreferenceManager.GetLibraryLocation());

            currentInfo.thumbnailImage = Image.FromFile(thumbPath + currentInfo.youtubeID + ".png");

            return currentInfo;
        }

        public static void Serialize(PlaylistInfo info)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(PlaylistInfo));

            string dataPath = String.Format(Strings.libraryFormatPlaylists, PreferenceManager.GetLibraryLocation());

            FileStream dataFile = File.Create(dataPath + info.name + ".xml");
            serializer.Serialize(dataFile, info);
            dataFile.Close();
        }

        public static PlaylistInfo Deserialize(string filename, bool nullPlaylistHack)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(VideoInfo));

            string dataPath = String.Format(Strings.libraryFormatPlaylists, PreferenceManager.GetLibraryLocation());

            FileStream dataFile = File.Open(filename, FileMode.Open);
            PlaylistInfo currentInfo = (PlaylistInfo)serializer.Deserialize(dataFile);
            dataFile.Close();

            return currentInfo;
        }
    }
}
