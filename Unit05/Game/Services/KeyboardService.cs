using System.Collections.Generic;
using Raylib_cs;
using Unit05.Game.Casting;


namespace Unit05.Game.Services
{
    /// <summary>
    /// <para>Detects player input.</para>
    /// <para>
    /// The responsibility of a KeyboardService is to indicate whether or not a key is up or down.
    /// </para>
    /// </summary>
    public class KeyboardService
    {
        private Dictionary<string, KeyboardKey> _keys
                = new Dictionary<string, KeyboardKey>();

        /// <summary>
        /// Constructs a new instance of KeyboardService using the given cell size.
        /// </summary>
        public KeyboardService()
        {
            _keys["w"] = KeyboardKey.KEY_W;
            _keys["a"] = KeyboardKey.KEY_A;
            _keys["s"] = KeyboardKey.KEY_S;
            _keys["d"] = KeyboardKey.KEY_D;
            _keys["i"] = KeyboardKey.KEY_I;
            _keys["j"] = KeyboardKey.KEY_J;
            _keys["k"] = KeyboardKey.KEY_K;
            _keys["l"] = KeyboardKey.KEY_L;
        }

        /// <summary>
        /// Checks if the given key is currently down.
        /// </summary>
        /// <param name="key">The given key (w, a, s, d, i, j, k, or l)</param>
        /// <returns>True if the given key is down; false if otherwise.</returns>
        public bool IsKeyDown(string key)
        {
            KeyboardKey raylibKey = _keys[key.ToLower()];
            return Raylib.IsKeyDown(raylibKey);
        }

        /// <summary>
        /// Checks if the given key is currently up.
        /// </summary>
        /// <param name="key">The given key (w, a, s, d, i, j, k, or l)</param>
        /// <returns>True if the given key is up; false if otherwise.</returns>
        public bool IsKeyUp(string key)
        {
            KeyboardKey raylibKey = _keys[key.ToLower()];
            return Raylib.IsKeyUp(raylibKey);
        }

    }
}