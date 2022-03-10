using System;
using System.Collections.Generic;


namespace Unit06.Game.Casting
{
    /// <summary>
    /// An animation.
    /// </summary>
    public class Animation
    {
        private TimeSpan delay;
        private List<string> images;
        private int rate;
        private int index;
        private int frame;
        private DateTime startTime;

        /// <summary>
        /// Constructs a new instance of Animation.
        /// </summary>
        public Animation(List<string> images, int rate, int delay)
        {
            this.images = images;
            this.rate = rate;
            this.delay = new TimeSpan(0, 0, delay);
            this.index = 0;
            this.frame = 0;
            this.startTime = DateTime.Now;
        }

        /// <summary>
        /// Gets the delay between animation cycles.
        /// </summary>
        /// <returns>The delay in seconds.</returns>
        public int GetDelay()
        {
            return delay.Seconds;
        }

        /// <summary>
        /// Gets the images used in the animation.
        /// </summary>
        /// <returns>A list of filenames.</returns>
        public List<string> GetImages()
        {
            return images;
        }

        /// <summary>
        /// Gets the animation rate or frames between images.
        /// </summary>
        /// <returns>The animation rate.</returns>
        public int GetRate()
        {
            return rate;
        }

        /// <summary>
        /// Gets the next image in the animation to display.
        /// </summary>
        /// <returns>The next image.</returns>
        public Image NextImage()
        {
            string filename = images[index];
            Image image = new Image(filename);

            DateTime currentTime = DateTime.Now;
            TimeSpan elapsedTime = currentTime.Subtract(startTime);

            if (elapsedTime > delay)
            {
                frame++; 
                if (frame >= rate)
                {
                    index = (index + 1) % images.Count;
                    frame = 0;
                }
                filename = images[index];
                image = new Image(filename);

                if (index >= images.Count - 1)
                {
                    startTime = currentTime;
                }
            }

            return image; 
        }
    }
}