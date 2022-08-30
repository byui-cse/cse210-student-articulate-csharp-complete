namespace Unit06.Game.Casting
{
    /// <summary>
    /// A thing that participates in the game.
    /// </summary>
    public class Brick : Actor
    {
        private Body _body;
        private Animation _animation;
        private int _points;

        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Brick(Body body, Animation animation, int points, bool debug) : base(debug)
        {
            this._body = body;
            this._animation = animation;
            this._points = points;
        }

        /// <summary>
        /// Gets the animation.
        /// </summary>
        /// <returns>The animation.</returns>
        public Animation GetAnimation()
        {
            return _animation;
        }

        /// <summary>
        /// Gets the body.
        /// </summary>
        /// <returns>The body.</returns>
        public Body GetBody()
        {
            return _body;
        }

        /// <summary>
        /// Gets the points.
        /// </summary>
        /// <returns>The points.</returns>
        public int GetPoints()
        {
            return _points;
        }
        
    }
}