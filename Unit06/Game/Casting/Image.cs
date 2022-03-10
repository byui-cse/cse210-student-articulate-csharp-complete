namespace Unit06.Game.Casting
{
    /// <summary>
    /// An image.
    /// </summary>
    public class Image
    {
        private string filename;
        private double scale;
        private int rotation;

        /// <summary>
        /// Constructs a new instance of Image.
        /// </summary>
        public Image(string filename, double scale = 1.0, int rotation = 0)
        {
            this.filename = filename;
            this.scale = scale;
            this.rotation = rotation;
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
        /// Gets the rotation.
        /// </summary>
        /// <returns>The rotation.</returns>
         public int GetRotation()
        {
            return rotation;
        }

        /// <summary>
        /// Gets the scale.
        /// </summary>
        /// <returns>The scale.</returns>
        public double GetScale()
        {
            return scale;
        }

        /// <summary>
        /// Sets the rotation to the given value.
        /// </summary>
        /// <param name="rotation">The given rotation.</param>
        public void SetRotation(int rotation)
        {
            this.rotation = rotation;
        }

        /// <summary>
        /// Sets the scale to the given value.
        /// </summary>
        /// <param name="scale">The given scale.</param>
        public void SetScale(double scale)
        {
            this.scale = scale;
        }
        
    }
}