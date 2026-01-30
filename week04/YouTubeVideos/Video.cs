using System;
public class Video
    {
        public string _title;
        public string _author;
        public int _lengthInSeconds;
        
        // Lista interna de comentarios (Encapsulada)
        private List<Comment> _comments = new List<Comment>();

        public Video(string title, string author, int length)
        {
            _title = title;
            _author = author;
            _lengthInSeconds = length;
        }

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public int GetCommentCount()
        {
            return _comments.Count;
        }

        public List<Comment> GetComments()
        {
            return _comments;
        }
    }