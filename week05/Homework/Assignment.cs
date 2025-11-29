// Assignment.cs
namespace Homework
{
    public abstract class Assignment
    {
        private string _studentName;
        private string _topic;

        public Assignment(string studentName, string topic)
        {
            _studentName = studentName;
            _topic = topic;
        }

        protected string GetStudentName()
        {
            return _studentName;
        }

        protected string GetTopic()
        {
            return _topic;
        }

        public string GetSummary()
        {
            return $"{_studentName} - {_topic}";
        }
    }
}