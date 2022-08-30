using System;


namespace Unit05.Game.Casting
{
    /// <summary>
    /// <para>A thing that participates in the game.</para>
    /// <para>
    /// The responsibility of Actor is to keep track of its appearance, position and velocity in 2d 
    /// space.
    /// </para>
    /// </summary>
    public class Actor
    {
        private string _text = "";
        private int _fontSize = 15;
        private Color _color = Constants.WHITE;
        private Point _position = new Point(0, 0);
        private Point _velocity = new Point(0, 0);

        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Actor()
        {
        }

        /// <summary>
        /// Gets the actor's color.
        /// </summary>
        /// <returns>The color.</returns>
        public Color GetColor()
        {
            return _color;
        }

        /// <summary>
        /// Gets the actor's font size.
        /// </summary>
        /// <returns>The font size.</returns>
        public int GetFontSize()
        {
            return _fontSize;
        }

        /// <summary>
        /// Gets the actor's position.
        /// </summary>
        /// <returns>The position.</returns>
        public Point GetPosition()
        {
            return _position;
        }

        /// <summary>
        /// Gets the actor's text.
        /// </summary>
        /// <returns>The text.</returns>
        public string GetText()
        {
            return _text;
        }

        /// <summary>
        /// Gets the actor's current velocity.
        /// </summary>
        /// <returns>The velocity.</returns>
        public Point GetVelocity()
        {
            return _velocity;
        }

        /// <summary>
        /// Moves the actor to its next position according to its velocity. Will wrap the position 
        /// from one side of the screen to the other when it reaches the maximum x and y 
        /// values.
        /// </summary>
        public virtual void MoveNext()
        {
            int x = ((_position.GetX() + _velocity.GetX()) + Constants.MAX_X) % Constants.MAX_X;
            int y = ((_position.GetY() + _velocity.GetY()) + Constants.MAX_Y) % Constants.MAX_Y;
            _position = new Point(x, y);
        }

        /// <summary>
        /// Sets the actor's color to the given value.
        /// </summary>
        /// <param name="color">The given color.</param>
        /// <exception cref="ArgumentException">When color is null.</exception>
        public void SetColor(Color color)
        {
            if (color == null)
            {
                throw new ArgumentException("color can't be null");
            }
            this._color = color;
        }

        /// <summary>
        /// Sets the actor's font size to the given value.
        /// </summary>
        /// <param name="fontSize">The given font size.</param>
        /// <exception cref="ArgumentException">
        /// When font size is less than or equal to zero.
        /// </exception>
        public void SetFontSize(int fontSize)
        {
            if (fontSize <= 0)
            {
                throw new ArgumentException("fontSize must be greater than zero");
            }
            this._fontSize = fontSize;
        }

        /// <summary>
        /// Sets the actor's position to the given value.
        /// </summary>
        /// <param name="position">The given position.</param>
        /// <exception cref="ArgumentException">When position is null.</exception>
        public void SetPosition(Point position)
        {
            if (position == null)
            {
                throw new ArgumentException("position can't be null");
            }
            this._position = position;
        }

        /// <summary>
        /// Sets the actor's text to the given value.
        /// </summary>
        /// <param name="text">The given text.</param>
        /// <exception cref="ArgumentException">When text is null.</exception>
        public void SetText(string text)
        {
            if (text == null)
            {
                throw new ArgumentException("text can't be null");
            }
            this._text = text;
        }

        /// <summary>
        /// Sets the actor's velocity to the given value.
        /// </summary>
        /// <param name="velocity">The given velocity.</param>
        /// <exception cref="ArgumentException">When velocity is null.</exception>
        public void SetVelocity(Point velocity)
        {
            if (velocity == null)
            {
                throw new ArgumentException("velocity can't be null");
            }
            this._velocity = velocity;
        }

    }
}