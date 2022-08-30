namespace Unit06.Game.Casting
{
    /// <summary>
    /// <para>A distance from a relative origin (0, 0).</para>
    /// <para>
    /// The responsibility of Point is to hold and provide information about itself. Point has a few 
    /// convenience methods for adding, scaling, and comparing them.
    /// </para>
    /// </summary>
    public class Point
    {
        private int _x;
        private int _y;

        /// <summary>
        /// Constructs a new instance of Point using the given x and y values.
        /// </summary>
        /// <param name="x">The given x value.</param>
        /// <param name="y">The given y value.</param>
        public Point(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        /// <summary>
        /// Adds the given point to this one by summing the x and y values.
        /// </summary>
        /// <param name="other">The point to add.</param>
        /// <returns>The sum as a new Point.</returns>
        public Point Add(Point other)
        {
            int x = this._x + other.GetX();
            int y = this._y + other.GetY();
            return new Point(x, y);
        }

        /// <summary>
        /// Whether or not this Point is equal to the given one.
        /// </summary>
        /// <param name="other">The point to compare.</param>
        /// <returns>True if both x and y are equal; false if otherwise.</returns>
        public bool Equals(Point other)
        {
            return this._x == other.GetX() && this._y == other.GetY();
        }

        /// <summary>
        /// Gets the value of the x coordinate.
        /// </summary>
        /// <returns>The x coordinate.</returns>
        public int GetX()
        {
            return _x;
        }

        /// <summary>
        /// Gets the value of the y coordinate.
        /// </summary>
        /// <returns>The y coordinate.</returns>
        public int GetY()
        {
            return _y;
        }

        /// <summary>
        /// Reverses the point by inverting both x and y values.
        /// </summary>
        /// <returns>A new point that is reversed.</returns>
        public Point Reverse()
        {
            int x = this._x * -1;
            int y = this._y * -1;
            return new Point(x, y);
        }
        
        /// <summary>
        /// Scales the point by multiplying the x and y values by the provided factor.
        /// </summary>
        /// <param name="factor">The scaling factor.</param>
        /// <returns>A scaled instance of Point.</returns>
        public Point Scale(int factor)
        {
            int x = this._x * factor;
            int y = this._y * factor;
            return new Point(x, y);
        }
    }
}