# Retrieve.NET
This is a simple Visual C# application that I ported from my Retrieve-android project where a user can download YouTube videos offline. Uses the .NET 4.5.2 framework.

### About this project
The goal of this project is for me to practice making ports from my Android apps to Windows desktop. This application works with native Visual C# and .NET 4.5.2 to download and play YouTube videos on Windows desktop machines.

### How this project works
This project will search for items using the YouTube API and use those videoIDs to get the download link. The download link is obtained by sending the videoID to my private Node.js server which will process the ID and send the download link back to this client application.
