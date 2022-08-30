namespace Unit06.Game.Casting
{
    /// <summary>
    /// A label to be displayed.
    /// </summary>
    public class Label : Actor
    {
        private Text _text;
        private Point _position;

        /// <summary>
        /// Constructs a new instance of Label.
        /// </summary>
        public Label(Text text, Point position) : base(false)
        {
            this._text = text;
            this._position = position;
        }

        /// <summary>
        /// Gets the label's text.
        /// </summary>
        /// <returns>The text.</returns>
        public Text GetText()
        {
            return _text;
        }

        /// <summary>
        /// Gets the label's position.
        /// </summary>
        /// <returns>The position.</returns>
        public Point GetPosition()
        {
            return _position;
        }
    }
}