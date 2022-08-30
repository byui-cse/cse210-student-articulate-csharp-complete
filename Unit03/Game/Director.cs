namespace Unit03.Game
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private Hider _hider = new Hider();
        private bool _isPlaying = true;
        private Seeker _seeker = new Seeker();
        private TerminalService _terminalService = new TerminalService();

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Moves the seeker to a new location.
        /// </summary>
        private void GetInputs()
        {
            _terminalService.WriteText(_hider._location.ToString());
            int location = _terminalService.ReadNumber("\nEnter a location [1-1000]: ");
            _seeker.MoveLocation(location);
        }

        /// <summary>
        /// Keeps watch on where the seeker is moving.
        /// </summary>
        private void DoUpdates()
        {
            _hider.WatchSeeker(_seeker);
        }

        /// <summary>
        /// Provides a hint for the seeker to use.
        /// </summary>
        private void DoOutputs()
        {
            string hint = _hider.GetHint();
            _terminalService.WriteText(hint);
            if (_hider.IsFound())
            {
                _isPlaying = false;
            }
            
        }
    }
}