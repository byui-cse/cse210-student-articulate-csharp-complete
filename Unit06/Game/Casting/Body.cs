namespace Unit06.Game.Casting
{
    /// <summary>
    /// A thing that participates in the game.
    /// </summary>
    public class Body
    {
        private Point _position;
        private Point _size;
        private Point _velocity;

        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Body(Point position, Point size, Point velocity)
        {
            this._position = position;
            this._size = size;
            this._velocity = velocity;
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
        /// Gets a rectangle enclosing this body.
        /// </summary>
        /// <returns>The enclosing rectangle.</returns>
        public Rectangle GetRectangle()
        {
            return new Rectangle(_position, _size);
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <returns>The size.</returns>
        public Point GetSize()
        {
            return _size;
        }

        /// <summary>
        /// Gets the velocity.
        /// </summary>
        /// <returns>The velocity.</returns>
        public Point GetVelocity()
        {
            return _velocity;
        }

        /// <summary>
        /// Sets the position to the given value.
        /// </summary>
        /// <param name="position">The given position.</param>
        public void SetPosition(Point position)
        {
            this._position = position;
        }

        /// <summary>
        /// Sets the size to the given value.
        /// </summary>
        /// <param name="size">The given size.</param>
        public void SetSize(Point size)
        {
            this._size = size;
        }

        /// <summary>
        /// Sets the velocity to the given value.
        /// </summary>
        /// <param name="velocity">The given velocity.</param>
        public void SetVelocity(Point velocity)
        {
            this._velocity = velocity;
        }
    }
}