namespace Unit06.Game.Casting
{
    /// <summary>
    /// A thing that participates in the game.
    /// </summary>
    public class Brick : Actor
    {
        private Body body;
        private Animation animation;
        private int points;

        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Brick(Body body, Animation animation, int points, bool debug) : base(debug)
        {
            this.body = body;
            this.animation = animation;
            this.points = points;
        }

        /// <summary>
        /// Gets the animation.
        /// </summary>
        /// <returns>The animation.</returns>
        public Animation GetAnimation()
        {
            return animation;
        }

        /// <summary>
        /// Gets the body.
        /// </summary>
        /// <returns>The body.</returns>
        public Body GetBody()
        {
            return body;
        }

        /// <summary>
        /// Gets the points.
        /// </summary>
        /// <returns>The points.</returns>
        public int GetPoints()
        {
            return points;
        }
        
    }
}