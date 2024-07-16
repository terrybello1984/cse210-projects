using System;
using System.Collections.Generic;

namespace YouTubeVideoTracking
{
    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to store the videos
            List<Video> videos = new List<Video>();

            // Create and set up 3-4 videos
            Video video1 = new Video("Understanding Abstraction", "Jane Doe", 300);
            video1.AddComment(new Comment("Alice", "Great explanation!"));
            video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
            video1.AddComment(new Comment("Charlie", "I learned a lot from this video."));

            Video video2 = new Video("C# Basics", "John Smith", 600);
            video2.AddComment(new Comment("David", "Clear and concise."));
            video2.AddComment(new Comment("Eve", "Well done, keep it up!"));
            video2.AddComment(new Comment("Frank", "This helped me understand C# better."));

            Video video3 = new Video("Advanced C# Techniques", "Alice Johnson", 900);
            video3.AddComment(new Comment("George", "Excellent content."));
            video3.AddComment(new Comment("Hannah", "Very informative."));
            video3.AddComment(new Comment("Ivy", "I love the detailed examples."));

            // Add the videos to the list
            videos.Add(video1);
            videos.Add(video2);
            videos.Add(video3);

            // Iterate through the list of videos and display information for each
            foreach (Video video in videos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
                Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

                // Get and display the comments for the video
                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($"- {comment.Author}: {comment.Text}");
                }

                Console.WriteLine();
            }
        }
    }
}
