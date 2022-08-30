using System;


namespace Unit02.Game
{
    /// <summary>
    /// A small cube with a different number of spots on each of its six sides.
    /// 
    /// The responsibility of Die is to keep track of its currently rolled value and the points its
    /// worth.
    /// </summary> 
    public class Die
    {
        public int _value = 0;
        public int _points = 0;

        /// <summary>
        /// Constructs a new instance of Die.
        /// </summary>
        public Die()
        {
        }

        /// <summary>
        /// Generates a new random value and calculates the points for the die.
        /// </summary>
        public void Roll()
        {
            Random random = new Random();
            _value = random.Next(1, 7);
            
            if (_value == 5)
            {
                _points = 50;
            }
            else if (_value == 1)
            {
                _points = 100;
            }
            else
            {
                _points = 0;
            }
        }

    }
}