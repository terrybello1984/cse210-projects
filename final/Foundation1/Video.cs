using System;
using System.Collections.Generic;

namespace YouTubeVideoTracking
{
    // Class to represent a YouTube video
    public class Video
    {
        // Properties for the title, author, and length of the video in seconds
        public string Title { get; set; }
        public string Author { get; set; }
        public int LengthInSeconds { get; set; }

        // List to store the video's comments
        private List<Comment> comments;

        // Constructor to initialize the video's properties and the comment list
        public Video(string title, string author, int lengthInSeconds)
        {
            Title = title;
            Author = author;
            LengthInSeconds = lengthInSeconds;
            comments = new List<Comment>();
        }

        // Method to add a comment to the comment list
        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        // Method to get the number of comments
        public int GetNumberOfComments()
        {
            return comments.Count;
        }

        // Method to get the list of comments
        public List<Comment> GetComments()
        {
            return comments;
        }
    }
}
