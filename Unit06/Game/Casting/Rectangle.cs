namespace Unit06.Game.Casting
{
    /// <summary>
    /// A rectangle.
    /// </summary>
    public class Rectangle
    {
        private Point _position;
        private Point _size;
        
        /// <summary>
        /// Constructs a new instance of Rectangle.
        /// </summary>
        public Rectangle(Point position, Point size)
        {
            this._position = position;
            this._size = size;
        }

        /// <summary>
        /// Gets the position.
        /// </summary>
        /// <returns>The position.</returns>
        public Point GetPosition()
        {
            return _position;
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <returns>The size.</returns>
        public Point GetSize()
        {
            return _size;
        }
    }
}