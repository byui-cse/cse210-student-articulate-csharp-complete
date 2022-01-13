using System;
using System.Collections.Generic;


namespace Unit03.Game 
{
    /// <summary>
    /// <para>The person hiding from the Seeker.</para>
    /// <para>
    /// The responsibility of Hider is to keep track of its location and distance from the seeker.
    /// </para>
    /// </summary>
    public class Hider
    {
        public int location = 0;
        private List<int> distance = new List<int>();

        /// <summary>
        /// Constructs a new instance of Hider. 
        /// </summary>
        public Hider()
        {
            Random random = new Random();
            location = random.Next(1001);
            // start with two so GetHint always works
            distance.Add(0);
            distance.Add(0);
        }

        /// <summary>
        /// Gets a hint for the seeker.
        /// </summary>
        /// <returns>A new hint.</returns>
        public string GetHint()
        {
            int current = distance[distance.Count - 1];
            int previous = distance[distance.Count - 2];

            string hint = "(-.-) Nap time.";
            if (current == 0)
            {
                hint = "(;.;) You found me!";
            }
            else if (current > previous)
            {
                hint = "(^.^) Getting colder!";
            }
            else if (current < previous)
            {
                hint = "(>.<) Getting warmer!";
            }

            return hint;
        }

        /// <summary>
        /// Whether or not the hider has been found.
        /// </summary>
        /// <returns>True if found; false if otherwise.</returns>
        public bool IsFound()
        {
            return distance[distance.Count - 1] == 0;
        }

        /// <summary>
        /// Watches the seeker by keeping track of how far away it is.
        /// </summary>
        /// <param name="seeker">The seeker to watch.</param>
        public void WatchSeeker(Seeker seeker)
        {
            int newDistance = Math.Abs(location - seeker.GetLocation());
            distance.Add(newDistance);
        }
    }
}