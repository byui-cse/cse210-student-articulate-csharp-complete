namespace Unit06.Game.Casting
{
    /// <summary>
    /// A thing that participates in the game.
    /// </summary>
    public class Text
    {
        private string _value;
        private string _fontFile;
        private int _size;
        private int _alignment;
        private Color _color;

        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Text(string value, string fontFile, int size, int alignment, Color color)
        {
            this._value = value;
            this._fontFile = fontFile;
            this._size = size;
            this._alignment = alignment;
            this._color = color;
        }

        /// <summary>
        /// Gets the alignment.
        /// </summary>
        /// <returns>The alignment.</returns>
        public int GetAlignment()
        {
            return _alignment;
        }

        /// <summary>
        /// Gets the color.
        /// </summary>
        /// <returns>The color.</returns>
        public Color GetColor()
        {
            return _color;
        }

        /// <summary>
        /// Gets the fontfile.
        /// </summary>
        /// <returns>The fontfile.</returns>
        public string GetFontFile()
        {
            return _fontFile;
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <returns>The size.</returns>
        public int GetSize()
        {
            return _size;
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <returns>The value.</returns>
        public string GetValue()
        {
            return _value;
        }

        /// <summary>
        /// Sets the value to the given one.
        /// </summary>
        /// <param name="value">The given value.</param>
        public void SetValue(string value)
        {
            this._value = value;
        }
    }
}