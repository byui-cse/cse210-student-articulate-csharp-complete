namespace Unit06.Game.Casting
{
    /// <summary>
    /// A thing that participates in the game.
    /// </summary>
    public class Text
    {
        private string value;
        private string fontFile;
        private int size;
        private int alignment;
        private Color color;

        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Text(string value, string fontFile, int size, int alignment, Color color)
        {
            this.value = value;
            this.fontFile = fontFile;
            this.size = size;
            this.alignment = alignment;
            this.color = color;
        }

        /// <summary>
        /// Gets the alignment.
        /// </summary>
        /// <returns>The alignment.</returns>
        public int GetAlignment()
        {
            return alignment;
        }

        /// <summary>
        /// Gets the color.
        /// </summary>
        /// <returns>The color.</returns>
        public Color GetColor()
        {
            return color;
        }

        /// <summary>
        /// Gets the fontfile.
        /// </summary>
        /// <returns>The fontfile.</returns>
        public string GetFontFile()
        {
            return fontFile;
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <returns>The size.</returns>
        public int GetSize()
        {
            return size;
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <returns>The value.</returns>
        public string GetValue()
        {
            return value;
        }

        /// <summary>
        /// Sets the value to the given one.
        /// </summary>
        /// <param name="value">The given value.</param>
        public void SetValue(string value)
        {
            this.value = value;
        }
    }
}