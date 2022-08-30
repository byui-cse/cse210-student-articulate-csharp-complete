using Raylib_cs;
using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class EndDrawingAction : Action
    {
        private VideoService _videoService;
        
        public EndDrawingAction(VideoService videoService)
        {
            this._videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            _videoService.FlushBuffer();
        }
    }
}