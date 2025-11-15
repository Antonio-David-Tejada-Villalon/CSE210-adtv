namespace ScriptureMemorizer
{
    public class Word
    {
        private readonly string _text;
        private bool _isHidden;

        public Word(string text)
        {
            _text = text ?? throw new ArgumentNullException(nameof(text));
            _isHidden = false;
        }

        public string Text => _text;
        public bool IsHidden => _isHidden;

        public void Hide() => _isHidden = true;

        public string GetDisplayText()
        {
            return _isHidden ? new string('_', _text.Length) : _text;
        }

        public override string ToString() => GetDisplayText();
    }
}