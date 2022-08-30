using System;
using System.Collections.Generic;


namespace Unit06.Game.Casting
{
    /// <summary>
    /// An animation.
    /// </summary>
    public class Animation
    {
        private TimeSpan _delay;
        private List<string> _images;
        private int _rate;
        private int _index;
        private int _frame;
        private DateTime _startTime;

        /// <summary>
        /// Constructs a new instance of Animation.
        /// </summary>
        public Animation(List<string> images, int rate, int delay)
        {
            this._images = images;
            this._rate = rate;
            this._delay = new TimeSpan(0, 0, delay);
            this._index = 0;
            this._frame = 0;
            this._startTime = DateTime.Now;
        }

        /// <summary>
        /// Gets the delay between animation cycles.
        /// </summary>
        /// <returns>The delay in seconds.</returns>
        public int GetDelay()
        {
            return _delay.Seconds;
        }

        /// <summary>
        /// Gets the images used in the animation.
        /// </summary>
        /// <returns>A list of filenames.</returns>
        public List<string> GetImages()
        {
            return _images;
        }

        /// <summary>
        /// Gets the animation rate or frames between images.
        /// </summary>
        /// <returns>The animation rate.</returns>
        public int GetRate()
        {
            return _rate;
        }

        /// <summary>
        /// Gets the next image in the animation to display.
        /// </summary>
        /// <returns>The next image.</returns>
        public Image NextImage()
        {
            string filename = _images[_index];
            Image image = new Image(filename);

            DateTime currentTime = DateTime.Now;
            TimeSpan elapsedTime = currentTime.Subtract(_startTime);

            if (elapsedTime > _delay)
            {
                _frame++; 
                if (_frame >= _rate)
                {
                    _index = (_index + 1) % _images.Count;
                    _frame = 0;
                }
                filename = _images[_index];
                image = new Image(filename);

                if (_index >= _images.Count - 1)
                {
                    _startTime = currentTime;
                }
            }

            return image; 
        }
    }
}