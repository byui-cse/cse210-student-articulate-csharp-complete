namespace Unit06.Game.Casting
{
    /// <summary>
    /// A color.
    /// </summary>
    public class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        /// <summary>
        /// Constructs a new instance of Color.
        /// </summary>
        public Color(int red, int green, int blue, int alpha = 255)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        /// <summary>
        /// Gets the alpha value.
        /// </summary>
        /// <returns>The alpha value.</returns>
        public int GetAlpha()
        {
            return alpha;
        }

        /// <summary>
        /// Gets the blue value.
        /// </summary>
        /// <returns>The blue value.</returns>
        public int GetBlue()
        {
            return blue;
        }

        /// <summary>
        /// Gets the green value.
        /// </summary>
        /// <returns>The green value.</returns>
        public int GetGreen()
        {
            return green;
        }

        /// <summary>
        /// Gets the red value.
        /// </summary>
        /// <returns>The red value.</returns>
        public int GetRed()
        {
            return red;
        }

        
    }
}