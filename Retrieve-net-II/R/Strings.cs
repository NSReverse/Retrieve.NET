using System;

namespace Retrieve_net_II.R
{
    class Strings
    {
        public const string clientString = "Retrieve Desktop Client, .NET 4.5.2";
        public const string User32 = "user32.dll";

        public const string readyString = "Ready";
        public const string statusFormatSearching = "Searching for \"{0}\"";
        public const string startingSearch = "Starting Search...";
        public const string searchFormatComplete = "Search Completed (\"{0}\")";

        public const string searchResultsTitle = "{0} - Search Results";
        public const string youtubeFormatURL = "https://www.youtube.com/watch?v={0}";
        public const string youtubeVideoFormatID = "[ID: {0}]";

        public const string youtubeDeveloperKey = "AIzaSyAPMYZx4_2SJMZ90MQJk9sEdEZLHZHzwvE";
        public const string publicURI = "http://retrieve.nsreverse.net:3000/";
        public const string localURI = "http://10.0.0.49:3000/";

        public const string pingResponse = "Pong!";
        public const string pingSuccess = "Connection Success";
        public const string pingAlertTitle = "Retrieve URL Resolver Connectivity";
        public const string resolveError = "Failed to get video download URL, please check your connection and try again.";
        public const string resolveAlertTitle = "Retrieve URL Resolver Error";
        public const string errorUnableToDownload = "Error - Cannot Download";
        public const string noDefaultLibrary = "There is no default library set. Please go to the Settings menu and set a folder for storing your library";

        public const string loadingData = "Loading Data...";
        public const string noData = "No Data";
        public const string resolvingUrl = "Resolving URL...";
        public const string downloadFormatProgress = "{0:0.00} MB of {1:0.00} MB ({2} %)";

        public const string aboutTitle = "About Retrieve";
        public const string aboutBody = "Retrieve is a simple application to download YouTube videos and play them.\n\nCreated by Robert Brown (@NSReverse, @ReverseEffect)";

        public const string formatSearchURL = "https://www.googleapis.com/youtube/v3/search?part=snippet&q={0}&maxResults=50&type=video&key={1}";

        public const string searchQueryEmptyAlertTitle = "Error - Query Empty";
        public const string searchQueryEmptyAlertBody = "Please enter a valid search query";

        public const string libraryFormatMetadata = "{0}\\videodata\\";
        public const string libraryFormatThumbnails = "{0}\\thumbs\\";
        public const string libraryFormatVideos = "{0}\\videos\\";
        public const string libraryFormatPlaylists = "{0}\\videolists\\";

        public struct SocketEvents
        {
            public static string PING = "ping";
            public static string PONG = "pong";
            public static string RECEIVED_DOWNLOAD_URL = "videoParsed";
            public static string SEND_YOUTUBE_URL = "getDownloadURL";
        }

        public struct Tags
        {
            public static string MAIN_FORM = "MainForm";
            public static string SEARCH_RESULT_FORM = "SearchResultForm";
            public static string SEARCH_VIDEO_INPUT_FORM = "SearchVideoInputForm";
            public static string SEARCH_RESULT_VIDEO_OPTIONS_FORM = "SearchResultVideoOptionsForm";

            public static string JSON_UTILS = "JsonUtils";
            public static string QUICK_ALERT = "QuickAlert";

            public static string IMAGE_DOWNLOADER = "ImageDownloader";
            public static string SOCKET_MANAGER = "SocketManager";
            public static string STRING_DOWNLOADER = "StringDownloader";

            public static string SETTINGS_PANEL = "SettingsPanel";
            public static string FOLDERS_PANEL = "FoldersPanel";
            public static string VIDEOS_PANEL = "VideosPanel";

            public static string FILE_DOWNLOADER = "FileDownloader";
        }
    }
}
