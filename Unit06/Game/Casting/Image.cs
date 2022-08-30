namespace Unit06.Game.Casting
{
    /// <summary>
    /// An image.
    /// </summary>
    public class Image
    {
        private string _filename;
        private double _scale;
        private int _rotation;

        /// <summary>
        /// Constructs a new instance of Image.
        /// </summary>
        public Image(string filename, double scale = 1.0, int rotation = 0)
        {
            this._filename = filename;
            this._scale = scale;
            this._rotation = rotation;
        }

        /// <summary>
        /// Gets the filename.
        /// </summary>
        /// <returns>The filename.</returns>
        public string GetFilename()
        {
            return _filename;
        }

        /// <summary>
        /// Gets the rotation.
        /// </summary>
        /// <returns>The rotation.</returns>
         public int GetRotation()
        {
            return _rotation;
        }

        /// <summary>
        /// Gets the scale.
        /// </summary>
        /// <returns>The scale.</returns>
        public double GetScale()
        {
            return _scale;
        }

        /// <summary>
        /// Sets the rotation to the given value.
        /// </summary>
        /// <param name="rotation">The given rotation.</param>
        public void SetRotation(int rotation)
        {
            this._rotation = rotation;
        }

        /// <summary>
        /// Sets the scale to the given value.
        /// </summary>
        /// <param name="scale">The given scale.</param>
        public void SetScale(double scale)
        {
            this._scale = scale;
        }
        
    }
}