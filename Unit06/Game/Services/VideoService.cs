using Unit06.Game.Casting;


namespace Unit06.Game.Services
{
    public interface VideoService
    {

        /// <summary>
        /// Prepares the buffer for drawing.
        /// </summary>
        void ClearBuffer();

        /// <summary>
        /// Draws the given image at the given position.
        /// </summary>
        /// <param name="image">The given image.</param>
        /// <param name="position">The given position.</param>
        void DrawImage(Image image, Point position);

        /// <summary>
        /// Draws a rectangle at the given position.
        /// </summary>
        /// <param name="size">The given size.</param>
        /// <param name="position">The given position.</param>
        /// <param name="color">The given color.</param>
        /// <param name="filled">Whether or not the rectangle should be filled.</param>
        void DrawRectangle(Point size, Point position, Casting.Color color, bool filled);

        /// <summary>
        /// Draws the given text at the given position.
        /// </summary>
        /// <param name="text">The given text.</param>
        /// <param name="position">The given position.</param>
        void DrawText(Text text, Point position);

        /// <summary>
        /// Swaps the buffers, displaying everything that has been drawn on the screen.
        /// </summary>
        void FlushBuffer();

        /// <summary>
        /// Initializes the video device.
        /// </summary>
        void Initialize();

        /// <summary>
        /// Whether or not the window is open.
        /// </summary>
        /// <returns>True if the window is open; false if it is closing.</returns>
        bool IsWindowOpen();

        /// <summary>
        /// Loads all the font files in the given directory.
        /// </summary>
        /// <param name="directory">The given directory.</param>
        void LoadFonts(string directory);

        /// <summary>
        /// Loads all the images files in the given directory.
        /// </summary>
        /// <param name="directory">The given directory.</param>
        void LoadImages(string directory);

        /// <summary>
        /// Releases the video device.
        /// </summary>
        void Release();

        /// <summary>
        /// Unloads the cached images.
        /// </summary>
        void UnloadFonts();

        /// <summary>
        /// Unloads the cached fonts.
        /// </summary>
        void UnloadImages();
    }
}