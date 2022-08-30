using System.Collections.Generic;
using Raylib_cs;
using Unit04.Game.Casting;


namespace Unit04.Game.Services
{
    /// <summary>
    /// <para>Outputs the game state.</para>
    /// <para>
    /// The responsibility of the class of objects is to draw the game state on the screen. 
    /// </para>
    /// </summary>
    public class VideoService
    {
        private int _cellSize = 15;
        private string _caption = "";
        private int _width = 640;
        private int _height = 480;
        private int _frameRate = 0;
        private bool _debug = false;

        /// <summary>
        /// Constructs a new instance of KeyboardService using the given cell size.
        /// </summary>
        /// <param name="cellSize">The cell size (in pixels).</param>
        public VideoService(string caption, int width, int height, int cellSize, int frameRate, 
                bool debug)
        {
            this._caption = caption;
            this._width = width;
            this._height = height;
            this._cellSize = cellSize;
            this._frameRate = frameRate;
            this._debug = debug;
        }

        /// <summary>
        /// Closes the window and releases all resources.
        /// </summary>
        public void CloseWindow()
        {
            Raylib.CloseWindow();
        }

        /// <summary>
        /// Clears the buffer in preparation for the next rendering. This method should be called at
        /// the beginning of the game's output phase.
        /// </summary>
        public void ClearBuffer()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Raylib_cs.Color.BLACK);
            if (_debug)
            {
                DrawGrid();
            }
        }

        /// <summary>
        /// Draws the given actor's text on the screen.
        /// </summary>
        /// <param name="actor">The actor to draw.</param>
        public void DrawActor(Actor actor)
        {
            string text = actor.GetText();
            int x = actor.GetPosition().GetX();
            int y = actor.GetPosition().GetY();
            int fontSize = actor.GetFontSize();
            Casting.Color c = actor.GetColor();
            Raylib_cs.Color color = ToRaylibColor(c);
            Raylib.DrawText(text, x, y, fontSize, color);
        }

        /// <summary>
        /// Draws the given list of actors on the screen.
        /// </summary>
        /// <param name="actors">The list of actors to draw.</param>
        public void DrawActors(List<Actor> actors)
        {
            foreach (Actor actor in actors)
            {
                DrawActor(actor);
            }
        }
        
        /// <summary>
        /// Copies the buffer contents to the screen. This method should be called at the end of
        /// the game's output phase.
        /// </summary>
        public void FlushBuffer()
        {
            Raylib.EndDrawing();
        }

        /// <summary>
        /// Gets the grid's cell size.
        /// </summary>
        /// <returns>The cell size.</returns>
        public int GetCellSize()
        {
            return _cellSize;
        }

        /// <summary>
        /// Gets the screen's height.
        /// </summary>
        /// <returns>The height (in pixels).</returns>
        public int GetHeight()
        {
            return _height;
        }

        /// <summary>
        /// Gets the screen's width.
        /// </summary>
        /// <returns>The width (in pixels).</returns>
        public int GetWidth()
        {
            return _width;
        }

        /// <summary>
        /// Whether or not the window is still open.
        /// </summary>
        /// <returns>True if the window is open; false if otherwise.</returns>
        public bool IsWindowOpen()
        {
            return !Raylib.WindowShouldClose();
        }

        /// <summary>
        /// Opens a new window with the provided title.
        /// </summary>
        public void OpenWindow()
        {
            Raylib.InitWindow(_width, _height, _caption);
            Raylib.SetTargetFPS(_frameRate);
        }

        /// <summary>
        /// Draws a grid on the screen.
        /// </summary>
        private void DrawGrid()
        {
            for (int x = 0; x < _width; x += _cellSize)
            {
                Raylib.DrawLine(x, 0, x, _height, Raylib_cs.Color.GRAY);
            }
            for (int y = 0; y < _height; y += _cellSize)
            {
                Raylib.DrawLine(0, y, _width, y, Raylib_cs.Color.GRAY);
            }
        }

        /// <summary>
        /// Converts the given color to it's Raylib equivalent.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>A Raylib color.</returns>
        private Raylib_cs.Color ToRaylibColor(Casting.Color color)
        {
            int r = color.GetRed();
            int g = color.GetGreen();
            int b = color.GetBlue();
            int a = color.GetAlpha();
            return new Raylib_cs.Color(r, g, b, a);
        }

    }
}