using System.Collections.Generic;
using System.IO;
using Raylib_cs;


namespace Unit06.Game.Services
{
    public class RaylibAudioService : AudioService
    {
        private Dictionary<string, Raylib_cs.Sound> _sounds 
            = new Dictionary<string, Raylib_cs.Sound>();
        
        /// <summary>
        /// Constructs a new RaylibAudioService.
        /// </summary>
        public RaylibAudioService()
        {
        }

        /// </inheritdoc>
        public void Initialize()
        {
            Raylib.InitAudioDevice();
        }

        /// </inheritdoc>
        public void LoadSounds(string directory)
        {
            List<string> filters = new List<string>() { "*.wav", "*.mp3", "*.acc", "*.wma" };
            List<string> filepaths = GetFilepaths(directory, filters);
            foreach (string filepath in filepaths)
            {
                Raylib_cs.Sound sound = Raylib.LoadSound(filepath);
                _sounds[filepath] = sound;
            }
        }
 
        /// </inheritdoc>
        public void PlaySound(Casting.Sound sound)
        {
            string filename = sound.GetFilename();
            if (_sounds.ContainsKey(filename))
            {
                Raylib_cs.Sound raylibSound = _sounds[filename];
                Raylib.PlaySound(raylibSound);
            }
        }

        /// </inheritdoc>
        public void Release()
        {
            Raylib.CloseAudioDevice();
        }

        /// </inheritdoc>
        public void UnloadSounds()
        {
            foreach (string filepath in _sounds.Keys)
            {
                Raylib_cs.Sound raylibSound = _sounds[filepath];
                Raylib.UnloadSound(raylibSound);
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
    }
}