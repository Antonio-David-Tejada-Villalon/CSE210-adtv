using System;
using System.Collections.Generic;

namespace YouTubeVideoProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to hold videos
            List<Video> videos = new List<Video>();

            // Create Video 1
            Video video1 = new Video("How to Bake Cookies", "BakingWithSam", 360);
            video1.AddComment(new Comment("Alice", "Love this recipe!"));
            video1.AddComment(new Comment("Bob", "My kids loved them!"));
            video1.AddComment(new Comment("Charlie", "Too sweet for me."));
            videos.Add(video1);

            // Create Video 2
            Video video2 = new Video("Top 5 Travel Destinations", "WanderlustJane", 600);
            video2.AddComment(new Comment("Dana", "I’ve been to #3!"));
            video2.AddComment(new Comment("Eli", "Add Bali next time!"));
            video2.AddComment(new Comment("Fiona", "Beautiful cinematography."));
            videos.Add(video2);

            // Create Video 3
            Video video3 = new Video("Learn C# in 10 Minutes", "CodeMaster", 600);
            video3.AddComment(new Comment("Grace", "Great intro!"));
            video3.AddComment(new Comment("Henry", "Where’s part 2?"));
            video3.AddComment(new Comment("Ivy", "Too fast for beginners."));
            videos.Add(video3);

            // Create Video 4 (optional)
            Video video4 = new Video("DIY Home Organization Hacks", "TidyLife", 480);
            video4.AddComment(new Comment("Jack", "Game changer!"));
            video4.AddComment(new Comment("Kara", "Need more closet tips."));
            video4.AddComment(new Comment("Leo", "So satisfying to watch."));
            videos.Add(video4);

            // Display all videos and their comments
            Console.WriteLine("=== YouTube Video Report ===\n");

            foreach (Video video in videos)
            {
                video.DisplayVideoInfo();
            }

            Console.WriteLine("Program complete.");
        }
    }
}