namespace Unit06.Game.Casting
{
    /// <summary>
    /// A thing that participates in the game.
    /// </summary>
    public class Stats : Actor
    {
        private int _level;
        private int _lives;
        private int _score;

        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Stats(int level = 1, int lives = 3, int score = 0, 
                bool debug = false) : base(debug)
        {
            this._level = level;
            this._lives = lives;
            this._score = score;
        }

        /// <summary>
        /// Adds one level.
        /// </summary>
        public void AddLevel()
        {
            _level++;
        }

        /// <summary>
        /// Adds an extra life.
        /// </summary>
        public void AddLife()
        {
            _lives++;
        }

        /// <summary>
        /// Adds the given points to the score.
        /// </summary>
        /// <param name="points">The given points.</param>
        public void AddPoints(int points)
        {
            _score += points;
        }

        /// <summary>
        /// Gets the level.
        /// </summary>
        /// <returns>The level.</returns>
        public int GetLevel()
        {
            return _level;
        }

        /// <summary>
        /// Gets the lives.
        /// </summary>
        /// <returns>The lives.</returns>
        public int GetLives()
        {
            return _lives;
        }

        /// <summary>
        /// Gets the score.
        /// </summary>
        /// <returns>The score.</returns>
        public int GetScore()
        {
            return _score;
        }

        /// <summary>
        /// Removes a life.
        /// </summary>
        public void RemoveLife()
        {
            _lives--;
            if (_lives <= 0)
            {
                _lives = 0;
            }
        }
        
    }
}