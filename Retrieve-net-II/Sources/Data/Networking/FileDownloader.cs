using Retrieve_net_II.R;
using Retrieve_net_II.Sources.Data.Utils;
using Retrieve_net_II.Sources.Model;
using System;
using System.ComponentModel;
using System.IO;
using System.Net;

namespace Retrieve_net_II.Sources.Data.Networking
{
    public class FileDownloader
    {
        private VideoCompletedDelegate completionDelegate;
        private ProgressDelegate progressDelegate;
        private VideoInfo videoMetadata;

        public interface VideoCompletedDelegate
        {
            void VideoDownloaded(VideoInfo videoInfo);
        }

        public interface ProgressDelegate
        {
            void VideoDownloadProgressChanged(double receivedBytes, double bytesExpected, int progress);
        }

        public static FileDownloader WithCompletionDelegate(VideoCompletedDelegate delegateCandidate) {
            FileDownloader downloader = new FileDownloader();

            if (delegateCandidate is VideoCompletedDelegate)
            {
                downloader.completionDelegate = delegateCandidate;
            }

            return downloader;
        }

        public FileDownloader WithProgressDelegate(ProgressDelegate delegateCandidate)
        {
            if (delegateCandidate is ProgressDelegate)
            {
                progressDelegate = delegateCandidate;
            }

            return this;
        }

        public FileDownloader WithVideoMetadata(VideoInfo info)
        {
            videoMetadata = info;
            return this;
        }

        public void GetFile(string resourceUri)
        {
            string libraryFolder = PreferenceManager.GetLibraryLocation();

            // Create directories if none exists. Ignored if exists.
            Directory.CreateDirectory(String.Format(Strings.libraryFormatThumbnails, libraryFolder));
            Directory.CreateDirectory(String.Format(Strings.libraryFormatVideos, libraryFolder));
            Directory.CreateDirectory(String.Format(Strings.libraryFormatMetadata, libraryFolder));
            Directory.CreateDirectory(String.Format(Strings.libraryFormatPlaylists, libraryFolder));

            string videoDestination = String.Format(Strings.libraryFormatVideos + videoMetadata.youtubeID + ".mp4", libraryFolder);
            string imageDestination = String.Format(Strings.libraryFormatThumbnails + videoMetadata.youtubeID + ".png", libraryFolder);

            Log.D(Strings.Tags.FILE_DOWNLOADER, "Video Dest: " + videoDestination);
            Log.D(Strings.Tags.FILE_DOWNLOADER, "Image Dest: " + imageDestination);

            WebClient client = new WebClient();
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            client.DownloadFileAsync(new Uri(resourceUri), videoDestination);

            WebClient imageClient = new WebClient();
            imageClient.DownloadFileAsync(new Uri(videoMetadata.thumbnailURL), imageDestination);
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            XmlSerializer.Serialize(videoMetadata);

            if (completionDelegate != null && videoMetadata != null)
            {
                completionDelegate.VideoDownloaded(videoMetadata);
            }
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            int progress = int.Parse(Math.Truncate(percentage).ToString());

            if (progressDelegate != null)
            {
                progressDelegate.VideoDownloadProgressChanged(bytesIn, totalBytes, progress);
            }
        }
    }
}
