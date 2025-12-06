using System;
using System.Collections.Generic;

namespace Foundation1
{
    public class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int LengthInSeconds { get; set; }
        public List<Comment> Comments { get; set; }

        public Video(string title, string author, int lengthInSeconds)
        {
            Title = title;
            Author = author;
            LengthInSeconds = lengthInSeconds;
            Comments = new List<Comment>();
        }

        public int GetCommentCount()
        {
            return Comments.Count;
        }

        public void DisplayVideoDetails()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Length (seconds): " + LengthInSeconds);
            Console.WriteLine("Number of comments: " + GetCommentCount());
            Console.WriteLine("Comments:");

            foreach (Comment comment in Comments)
            {
                comment.DisplayComment();
            }

            Console.WriteLine();
        }
    }
}
