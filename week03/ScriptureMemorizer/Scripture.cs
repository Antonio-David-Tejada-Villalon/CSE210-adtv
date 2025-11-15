using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private readonly ScriptureReference _reference;
        private readonly List<Word> _words;

        public Scripture(ScriptureReference reference, string text)
        {
            _reference = reference ?? throw new ArgumentNullException(nameof(reference));
            _words = new List<Word>();

            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException("Text cannot be null or empty.", nameof(text));

            var wordStrings = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in wordStrings)
            {
                _words.Add(new Word(word));
            }
        }

        public string GetDisplayText()
        {
            var displayText = $"{_reference} ";
            displayText += string.Join(" ", _words.Select(w => w.GetDisplayText()));
            return displayText;
        }

        public void HideRandomWords(int count)
        {
            if (count <= 0) return;

            var visibleWordIndices = _words
                .Select((word, index) => new { word, index })
                .Where(x => !x.word.IsHidden)
                .Select(x => x.index)
                .ToList();

            if (visibleWordIndices.Count == 0) return;

            count = Math.Min(count, visibleWordIndices.Count);

            var random = new Random();
            for (int i = 0; i < count; i++)
            {
                var index = random.Next(visibleWordIndices.Count);
                var wordIndex = visibleWordIndices[index];
                _words[wordIndex].Hide();
                visibleWordIndices.RemoveAt(index);
            }
        }

        public bool AllWordsHidden() => _words.All(w => w.IsHidden);
    }
}