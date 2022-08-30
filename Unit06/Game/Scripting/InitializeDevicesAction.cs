using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class InitializeDevicesAction : Action
    {
        private AudioService _audioService;
        private VideoService _videoService;
        
        public InitializeDevicesAction(AudioService audioService, VideoService videoService)
        {
            this._audioService = audioService;
            this._videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            _audioService.Initialize();
            _videoService.Initialize();
        }
    }
}