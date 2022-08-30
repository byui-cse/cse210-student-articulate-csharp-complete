using System;


namespace Unit03.Game
{
    /// <summary>
    /// <para>The person looking for the Hider.</para>
    /// <para>
    /// The responsibility of a Seeker is to keep track of its location.
    /// </para>
    /// </summary>
    public class Seeker
    {
        private int _location = 0;

        /// <summary>
        /// Constructs a new instance of Seeker.
        /// </summary>
        public Seeker()
        {
            Random random = new Random();
            _location = random.Next(1001);
        }

        /// <summary>
        /// Gets the current location.
        /// </summary>
        /// <returns>The current location.</returns>
        public int GetLocation()
        {
            return _location;
        }

        /// <summary>
        /// Moves to the given location.
        /// </summary>
        /// <param name="location">The given location.</param>
        public void MoveLocation(int location)
        {
            this._location = location;
        }

    }
}