using Unit06.Game.Casting;


namespace Unit06.Game.Services
{
    public interface AudioService
    {
        /// <summary>
        /// Initializes the audio device.
        /// </summary>
        void Initialize();

        /// <summary>
        /// Loads all the sound files in the given directory.
        /// </summary>
        /// <param name="directory">The given directory.</param>
        void LoadSounds(string directory);

        /// <summary>
        /// Plays the given sound.
        /// </summary>
        /// <param name="sound">The given sound.</param>
        void PlaySound(Sound sound);

        /// <summary>
        /// Releases the audio device.
        /// </summary>
        void Release();

        /// <summary>
        /// Unloads the cached sounds.
        /// </summary>
        void UnloadSounds();
    }
}