namespace Unit06.Game.Casting
{
    /// <summary>
    /// A color.
    /// </summary>
    public class Color
    {
        private int _red;
        private int _green;
        private int _blue;
        private int _alpha;

        /// <summary>
        /// Constructs a new instance of Color.
        /// </summary>
        public Color(int red, int green, int blue, int alpha = 255)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
            this._alpha = alpha;
        }

        /// <summary>
        /// Gets the alpha value.
        /// </summary>
        /// <returns>The alpha value.</returns>
        public int GetAlpha()
        {
            return _alpha;
        }

        /// <summary>
        /// Gets the blue value.
        /// </summary>
        /// <returns>The blue value.</returns>
        public int GetBlue()
        {
            return _blue;
        }

        /// <summary>
        /// Gets the green value.
        /// </summary>
        /// <returns>The green value.</returns>
        public int GetGreen()
        {
            return _green;
        }

        /// <summary>
        /// Gets the red value.
        /// </summary>
        /// <returns>The red value.</returns>
        public int GetRed()
        {
            return _red;
        }

        
    }
}