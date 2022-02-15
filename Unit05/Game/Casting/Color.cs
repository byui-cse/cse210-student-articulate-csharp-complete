using System.Collections.Generic;


namespace Unit05.Game.Casting
{
    /// <summary>
    /// <para>A color.</para>
    /// <para>The responsibility of Color is to hold and provide information about itself. Color has 
    /// a few convenience methods for comparing and converting them.
    /// </para>
    /// </summary>
    public class Color
    {
        private int red = 0;
        private int green = 0;
        private int blue = 0;
        private int alpha = 255;

        /// <summary>
        /// Constructs a new instance of Color using the given red, green and blue values.
        /// </summary>
        /// <param name="red">The given red value (0-255).</param>
        /// <param name="green">The given green value (0-255).</param>
        /// <param name="blue">The given blue value (0-255).</param>
        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        /// <summary>
        /// Gets the color's alpha value.
        /// </summary>
        /// <returns>The alpha value.</returns>
        public int GetAlpha()
        {
            return alpha;
        }

        /// <summary>
        /// Gets the color's blue value.
        /// </summary>
        /// <returns>The blue value.</returns>
        public int GetBlue()
        {
            return blue;
        }

        /// <summary>
        /// Gets the color's green value.
        /// </summary>
        /// <returns>The green value.</returns>
        public int GetGreen()
        {
            return green;
        }

        /// <summary>
        /// Gets the color's red value.
        /// </summary>
        /// <returns>The red value.</returns>
        public int GetRed()
        {
            return red;
        }

    }
}