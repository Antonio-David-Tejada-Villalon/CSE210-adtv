namespace YouTubeVideoProgram
{
    public class Comment
    {
        private string _commenterName;
        private string _text;

        public Comment(string commenterName, string text)
        {
            _commenterName = commenterName;
            _text = text;
        }

        public string GetCommenterName()
        {
            return _commenterName;
        }

        public string GetText()
        {
            return _text;
        }

        // Optional: Helper method to display comment
        public string GetDisplayText()
        {
            return $"{_commenterName}: {_text}";
        }
    }
}