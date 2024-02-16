using System;
using System.Collections.Generic;

class YouTubeProgram
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        
        Video video1 = new Video { Title = "Video 1", Author = "Author 1", LengthInSeconds = 120 };
        video1.AddComment("User1", "Great video!");
        video1.AddComment("User2", "I learned a lot.");

        Video video2 = new Video { Title = "Video 2", Author = "Author 2", LengthInSeconds = 180 };
        video2.AddComment("User3", "Awesome content!");

        
        videos.Add(video1);
        videos.Add(video2);

        
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}
