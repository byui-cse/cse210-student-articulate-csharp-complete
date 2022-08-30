namespace Unit06.Game.Casting
{
    /// <summary>
    /// A thing that participates in the game.
    /// </summary>
    public class Actor
    {
        private bool _debug;
        
        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Actor(bool debug)
        {
            this._debug = debug;
        }

        /// <summary>
        /// Whether or not the actor is being debugged.
        /// </summary>
        /// <returns>True if being debugged; false if othewise.</returns>
        public bool IsDebug()
        {
            return _debug;
        }
    }
}