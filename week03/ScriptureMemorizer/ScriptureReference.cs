using System;
using System.Linq;

namespace ScriptureMemorizer
{
    public class ScriptureReference
    {
        private readonly string _book;
        private readonly int _chapter;
        private readonly int _startVerse;
        private readonly int _endVerse;

        public ScriptureReference(string book, int chapter, int verse)
        {
            _book = book ?? throw new ArgumentNullException(nameof(book));
            _chapter = chapter;
            _startVerse = verse;
            _endVerse = verse;
        }

        public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
        {
            _book = book ?? throw new ArgumentNullException(nameof(book));
            _chapter = chapter;
            _startVerse = startVerse;
            _endVerse = endVerse;
        }

        public ScriptureReference(string referenceString)
        {
            if (string.IsNullOrWhiteSpace(referenceString))
                throw new ArgumentException("Reference string cannot be null or empty.", nameof(referenceString));

            var parts = referenceString.Split(' ');
            _book = string.Join(" ", parts.Take(parts.Length - 1));

            var versePart = parts.Last();
            if (versePart.Contains('-'))
            {
                var verseRange = versePart.Split('-');
                _chapter = int.Parse(verseRange[0].Split(':')[0]);
                _startVerse = int.Parse(verseRange[0].Split(':')[1]);
                _endVerse = int.Parse(verseRange[1]);
            }
            else
            {
                var verseParts = versePart.Split(':');
                _chapter = int.Parse(verseParts[0]);
                _startVerse = int.Parse(verseParts[1]);
                _endVerse = _startVerse;
            }
        }

        public override string ToString()
        {
            return _startVerse == _endVerse
                ? $"{_book} {_chapter}:{_startVerse}"
                : $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}