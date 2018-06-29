using Quobject.SocketIoClientDotNet.Client;
using Retrieve_net_II.R;
using Retrieve_net_II.Sources.Data.Utils;
using System;

namespace Retrieve_net_II.Sources.Data.Networking
{
    class SocketManager
    {
        static Socket currentSocket;
        private static SocketManager manager = null;
        private static Delegate currentDelegate;

        public interface Delegate
        {
            void DownloadURLReceived(String videoURL);
        }

        public static SocketManager GetInstance()
        {
            if (manager == null)
            {
                bool useLocal = PreferenceManager.GetUseDevelopmentServer();

                manager = new SocketManager();
                currentSocket = IO.Socket((useLocal) ? Strings.localURI : Strings.publicURI);

                Console.WriteLine("Connecting to socket: " + ((useLocal) ? Strings.localURI : Strings.publicURI));

                SetupListeners(currentSocket);
            }

            return manager;
        }

        private static void SetupListeners(Socket socket)
        {
            socket.On(Strings.SocketEvents.PONG, (data) =>
            {
                if (data.ToString().Equals("Pong!"))
                {
                    QuickAlert.ShowInfo(Strings.pingAlertTitle, Strings.pingSuccess);
                }
            });

            socket.On(Strings.SocketEvents.RECEIVED_DOWNLOAD_URL, (data) =>
            {
                Log.D(Strings.Tags.SOCKET_MANAGER, "DOWNLOAD URL RECEIVED");

                Log.D(Strings.Tags.SOCKET_MANAGER, (currentDelegate == null) ? "delegate is null" : "delegate isn't null");
                Log.D(Strings.Tags.SOCKET_MANAGER, (data == null) ? "data is null" : "data isn't null");

                if (currentDelegate != null && data != null)
                {
                    currentDelegate.DownloadURLReceived(data.ToString());
                    Log.D(Strings.Tags.SOCKET_MANAGER, "SENT TO DELEGATE");
                }
                else
                {
                    if (data == null)
                    {
                        QuickAlert.ShowError(Strings.resolveAlertTitle, Strings.resolveError);
                    }
                }
            });
        }

        public void SubmitYouTubeURL(string youtubeURL)
        {
            currentSocket.Emit(Strings.SocketEvents.SEND_YOUTUBE_URL, Strings.clientString, youtubeURL);
        }

        public void SetDelegate(Delegate delegateCandidate)
        {
            currentDelegate = delegateCandidate;
        }

        public void TestConnectivityToResolver()
        {
            currentSocket.Emit(Strings.SocketEvents.PING);
        }
    }
}
