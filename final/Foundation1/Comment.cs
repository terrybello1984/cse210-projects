using System;

namespace YouTubeVideoTracking
{
    // Class to represent a comment on a video
    public class Comment
    {
        // Properties for the comment author's name and the comment text
        public string Author { get; set; }
        public string Text { get; set; }

        // Constructor to initialize the comment's properties
        public Comment(string author, string text)
        {
            Author = author;
            Text = text;
        }
    }
}
