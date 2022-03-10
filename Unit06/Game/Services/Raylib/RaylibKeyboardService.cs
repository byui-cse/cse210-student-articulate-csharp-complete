using System.Collections.Generic;
using Raylib_cs;


namespace Unit06.Game.Services
{
    public class RaylibKeyboardService : KeyboardService
    {
        private Dictionary<string, Raylib_cs.KeyboardKey> keys 
                = new Dictionary<string, Raylib_cs.KeyboardKey>() {
            { "a", Raylib_cs.KeyboardKey.KEY_A },
            { "b", Raylib_cs.KeyboardKey.KEY_B },
            { "c", Raylib_cs.KeyboardKey.KEY_C },
            { "d", Raylib_cs.KeyboardKey.KEY_D },
            { "e", Raylib_cs.KeyboardKey.KEY_E },
            { "f", Raylib_cs.KeyboardKey.KEY_F },
            { "g", Raylib_cs.KeyboardKey.KEY_G },
            { "h", Raylib_cs.KeyboardKey.KEY_H },
            { "i", Raylib_cs.KeyboardKey.KEY_I },
            { "j", Raylib_cs.KeyboardKey.KEY_J },
            { "k", Raylib_cs.KeyboardKey.KEY_K },
            { "l", Raylib_cs.KeyboardKey.KEY_L },
            { "m", Raylib_cs.KeyboardKey.KEY_M },
            { "n", Raylib_cs.KeyboardKey.KEY_N },
            { "o", Raylib_cs.KeyboardKey.KEY_O },
            { "p", Raylib_cs.KeyboardKey.KEY_P },
            { "q", Raylib_cs.KeyboardKey.KEY_Q },
            { "r", Raylib_cs.KeyboardKey.KEY_R },
            { "s", Raylib_cs.KeyboardKey.KEY_S },
            { "t", Raylib_cs.KeyboardKey.KEY_T },
            { "u", Raylib_cs.KeyboardKey.KEY_U },
            { "v", Raylib_cs.KeyboardKey.KEY_V },
            { "w", Raylib_cs.KeyboardKey.KEY_W },
            { "x", Raylib_cs.KeyboardKey.KEY_X },
            { "y", Raylib_cs.KeyboardKey.KEY_Y },
            { "z", Raylib_cs.KeyboardKey.KEY_Z },
            { "1", Raylib_cs.KeyboardKey.KEY_ONE },
            { "2", Raylib_cs.KeyboardKey.KEY_TWO },
            { "3", Raylib_cs.KeyboardKey.KEY_THREE },
            { "4", Raylib_cs.KeyboardKey.KEY_FOUR },
            { "5", Raylib_cs.KeyboardKey.KEY_FIVE },
            { "6", Raylib_cs.KeyboardKey.KEY_SIX },
            { "7", Raylib_cs.KeyboardKey.KEY_SEVEN },
            { "8", Raylib_cs.KeyboardKey.KEY_EIGHT },
            { "9", Raylib_cs.KeyboardKey.KEY_NINE },
            { "0", Raylib_cs.KeyboardKey.KEY_ZERO },
            { "left", Raylib_cs.KeyboardKey.KEY_LEFT },
            { "right", Raylib_cs.KeyboardKey.KEY_RIGHT },
            { "up", Raylib_cs.KeyboardKey.KEY_UP },
            { "down", Raylib_cs.KeyboardKey.KEY_DOWN },
            { "enter", Raylib_cs.KeyboardKey.KEY_ENTER },
            { "space", Raylib_cs.KeyboardKey.KEY_SPACE }
        };
        
        public RaylibKeyboardService()
        {
        }

        /// </inheritdoc>
        public bool IsKeyDown(string key)
        {
            Raylib_cs.KeyboardKey raylibKey = keys[key.ToLower()];
            return Raylib.IsKeyDown(raylibKey);
        }

        /// </inheritdoc>
        public bool IsKeyPressed(string key)
        {
            Raylib_cs.KeyboardKey raylibKey = keys[key.ToLower()];
            return Raylib.IsKeyPressed(raylibKey);
        }

        /// </inheritdoc>
        public bool IsKeyReleased(string key)
        {
            Raylib_cs.KeyboardKey raylibKey = keys[key.ToLower()];
            return Raylib.IsKeyReleased(raylibKey);
        }

        /// </inheritdoc>
        public bool IsKeyUp(string key)
        {
            Raylib_cs.KeyboardKey raylibKey = keys[key.ToLower()];
            return Raylib.IsKeyUp(raylibKey);
        }
    }
}