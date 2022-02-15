using System;


namespace Unit05.Game.Casting
{
    /// <summary>
    /// <para>A tasty item that snakes like to eat.</para>
    /// <para>
    /// The responsibility of Food is to select a random position and points that it's worth.
    /// </para>
    /// </summary>
    public class Food : Actor
    {
        private int points = 0;

        /// <summary>
        /// Constructs a new instance of an Food.
        /// </summary>
        public Food()
        {
            SetText("@");
            SetColor(Constants.RED); 
            Reset();
        }

        /// <summary>
        /// Gets the points this food is worth.
        /// </summary>
        /// <returns>The points.</returns>
        public int GetPoints()
        {
            return points;
        }

        /// <summary>
        /// Selects a random position and points that the food is worth.
        /// </summary>
        public void Reset()
        {
            Random random = new Random();
            points = random.Next(9);
            int x = random.Next(Constants.COLUMNS);
            int y = random.Next(Constants.ROWS);
            Point position = new Point(x, y);
            position = position.Scale(Constants.CELL_SIZE);
            SetPosition(position);
        }
    }
}