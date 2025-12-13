using System;
using System.Collections.Generic;

namespace Foundation1
{
    public class Video
    {
       
        private string _title;
        private string _author;
        private int _lengthInSeconds;

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

        public int GetCommentCount()
        {
            return _comments.Count;
        }

        public void DisplayVideoDetails()
        {
            Console.WriteLine("Title: " + _title);
            Console.WriteLine("Author: " + _author);
            Console.WriteLine("Length (seconds): " + _lengthInSeconds);
            Console.WriteLine("Number of comments: " + GetCommentCount());
            Console.WriteLine("Comments:");

          
            for (int i = 0; i < _comments.Count; i++)
            {
                Comment comment = _comments[i];
                comment.DisplayComment();
            }

            Console.WriteLine();
        }
    }
}
