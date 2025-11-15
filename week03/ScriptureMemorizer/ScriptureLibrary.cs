using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ScriptureMemorizer
{
    public class ScriptureLibrary
    {
        private readonly List<Scripture> _scriptures = new();

        public void LoadScripturesFromFile(string filename)
        {
            if (string.IsNullOrWhiteSpace(filename))
                throw new ArgumentException("Filename cannot be null or empty.", nameof(filename));

            if (!File.Exists(filename))
            {
                AddScripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
                return;
            }

            try
            {
                var lines = File.ReadAllLines(filename);
                for (int i = 0; i < lines.Length; i += 2)
                {
                    if (i + 1 < lines.Length)
                    {
                        var reference = lines[i];
                        var text = lines[i + 1];

                        var refObj = new ScriptureReference(reference);
                        var scripture = new Scripture(refObj, text);
                        _scriptures.Add(scripture);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading scriptures: {ex.Message}");
                AddScripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
            }
        }

        public void AddScripture(string reference, string text)
        {
            var refObj = new ScriptureReference(reference);
            var scripture = new Scripture(refObj, text);
            _scriptures.Add(scripture);
        }

        public Scripture GetRandomScripture()
        {
            if (_scriptures.Count == 0) return null;

            var random = new Random();
            var index = random.Next(_scriptures.Count);
            return _scriptures[index];
        }

        public int Count => _scriptures.Count;
    }
}