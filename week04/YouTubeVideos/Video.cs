using System;
using System.Collections.Generic;

namespace YouTubeVideoProgram
{
    public class Video
    {
        private string _title;
        private string _author;
        private int _lengthInSeconds; // in seconds
        private List<Comment> _comments;

        public Video(string title, string author, int lengthInSeconds)
        {
            _title = title;
            _author = author;
            _lengthInSeconds = lengthInSeconds;
            _comments = new List<Comment>();
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public int GetLengthInSeconds()
        {
            return _lengthInSeconds;
        }

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public int GetNumberOfComments()
        {
            return _comments.Count;
        }

        public List<Comment> GetComments()
        {
            return _comments;
        }

        // Helper method to display video info
        public void DisplayVideoInfo()
        {
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Author: {_author}");
            Console.WriteLine($"Length: {_lengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in _comments)
            {
                Console.WriteLine($"  {comment.GetDisplayText()}");
            }
            Console.WriteLine(); // Blank line between videos
        }
    }
}