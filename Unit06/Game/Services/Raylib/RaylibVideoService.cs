using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;
using Raylib_cs;


namespace Unit06.Game.Services
{
    public class RaylibVideoService : VideoService
    {
        private Casting.Color _color;
        private int _height;
        private string _title;
        private int _width;
        
        private Dictionary<string, Raylib_cs.Font> fonts
            = new Dictionary<string, Raylib_cs.Font>();
        
        private Dictionary<string, Raylib_cs.Texture2D> textures
            = new Dictionary<string, Raylib_cs.Texture2D>();
        
        public RaylibVideoService(string title, int width, int height, Casting.Color color)
        {
            this._title = title;
            this._width = width;
            this._height = height;
            this._color = color;
        }
        /// </inheritdoc>
        public void ClearBuffer()
        {
            Raylib_cs.Color background = ToRaylibColor(_color);
            Raylib.BeginDrawing();
            Raylib.ClearBackground(background);
        }

        /// </inheritdoc>
        public void DrawImage(Casting.Image image, Casting.Point position)
        {
            string filename = image.GetFilename();
            if (!textures.ContainsKey(filename))
            {
                Raylib_cs.Texture2D loaded = Raylib.LoadTexture(filename);
                textures[filename] = loaded;
            }
            Raylib_cs.Texture2D texture = textures[filename];
            int x = position.GetX();
            int y = position.GetY();
            Raylib.DrawTexture(texture, x, y, Raylib_cs.Color.WHITE);
        }

        /// </inheritdoc>
        public void DrawRectangle(Casting.Point size, Casting.Point position, Casting.Color color,
            bool filled = false)
        {
            int x = position.GetX();
            int y = position.GetY();
            int width = size.GetX();
            int height = size.GetY();
            Raylib_cs.Color raylibColor = ToRaylibColor(color);

            if (filled)
            {
                Raylib.DrawRectangle(x, y, width, height, raylibColor);
            }
            else
            {
                Raylib.DrawRectangleLines(x, y, width, height, raylibColor);
            }
        }

        /// </inheritdoc>
        public void DrawText(Casting.Text text, Casting.Point position)
        {
            string value = text.GetValue();
            int size = text.GetSize();
            int alignment = text.GetAlignment();
            Casting.Color color = text.GetColor();
            int x = position.GetX();
            int y = position.GetY();
            
            string filename = text.GetFontFile();
            if (!fonts.ContainsKey(filename))
            {
                Raylib_cs.Font loaded = Raylib.LoadFont(filename);
                fonts[filename] = loaded;
            }
            Raylib_cs.Font font = fonts[filename];

            x = RecalcuteTextPosition(font, value, size, x, alignment);
            Raylib_cs.Color raylibColor = ToRaylibColor(color);
            Vector2 vector = new Vector2(x, y);
            Raylib.DrawTextEx(font, value, vector, size, 0, raylibColor);
        }

        /// </inheritdoc>
        public void FlushBuffer()
        {
            Raylib.EndDrawing(); 
        }

        /// </inheritdoc>
        public void Initialize()
        {
            Raylib.InitWindow(_width, _height, _title);
            Raylib.SetTargetFPS(Constants.FRAME_RATE);
        }

        /// </inheritdoc>
        public bool IsWindowOpen()
        {
            return !Raylib.WindowShouldClose();
        }

        /// </inheritdoc>
        public void LoadFonts(string directory)
        {
            List<string> filters = new List<string>() { "*.otf", "*.ttf" };
            List<string> filepaths = GetFilepaths(directory, filters);
            foreach (string filepath in filepaths)
            {
                Raylib_cs.Font font = Raylib.LoadFont(filepath);
                fonts[filepath] = font;
            }
        }

        /// </inheritdoc>
        public void LoadImages(string directory)
        {
            List<string> filters = new List<string>() { "*.png", "*.gif", "*.jpg", "*.jpeg", "*.bmp" };
            List<string> filepaths = GetFilepaths(directory, filters);
            foreach (string filepath in filepaths)
            {
                Raylib_cs.Texture2D texture = Raylib.LoadTexture(filepath);
                textures[filepath] = texture;
            }
        }

        /// </inheritdoc>
        public void Release()
        {
            Raylib.CloseWindow();
        }

        /// </inheritdoc>
        public void UnloadFonts()
        {
            foreach (string key in fonts.Keys)
            {
                Raylib_cs.Font font = fonts[key];
                Raylib.UnloadFont(font);
            }
        }

        /// </inheritdoc>
        public void UnloadImages()
        {
            foreach (string key in textures.Keys)
            {
                Raylib_cs.Texture2D texture = textures[key];
                Raylib.UnloadTexture(texture);
            }
        }

        private List<string> GetFilepaths(string directory, List<string> filters)
        {
            List<string> results = new List<string>();
            foreach (string filter in filters)
            {
                string[] filepaths = Directory.GetFiles(directory, filter);
                results.AddRange(filepaths);
            }
            return results;
        }

        private int RecalcuteTextPosition(Font font, string text, int size, int x, int alignment)
        {
            int width = (int)Raylib.MeasureTextEx(font, text, size, 0).X;
            if (alignment == Constants.ALIGN_CENTER)
            {
                x = x - (width / 2);
            }
            else if (alignment == Constants.ALIGN_RIGHT)
            {
                x = x - width;
            }
            return x;
        }

        private Raylib_cs.Color ToRaylibColor(Casting.Color color)
        {
            return new Raylib_cs.Color(color.GetRed(), color.GetGreen(), color.GetBlue(), 
                System.Convert.ToByte(255));
        }

    }
}