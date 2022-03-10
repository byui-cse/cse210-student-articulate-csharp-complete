namespace Unit06.Game.Casting
{
    /// <summary>
    /// An sound.
    /// </summary>
    public class Sound
    {
        private string filename;
        private int volume;
        private bool repeated;
        
        /// <summary>
        /// Constructs a new instance of Image.
        /// </summary>
        public Sound(string filename, int volume = 1, bool repeated = false)
        {
            this.filename = filename;
            this.volume = volume;
            this.repeated = repeated;
        }

        /// <summary>
        /// Gets the filename.
        /// </summary>
        /// <returns>The filename.</returns>
        public string GetFilename()
        {
            return filename;
        }

        /// <summary>
        /// Gets the volume.
        /// </summary>
        /// <returns>The volume.</returns>
        public int GetVolume()
        {
            return volume;
        }

        /// <summary>
        /// Whether or not the sound should be repeated.
        /// </summary>
        /// <returns>True if the sound should be repeated; false if otherwise.</returns>
        public bool IsRepeated()
        {
            return repeated;
        }
        
    }
}