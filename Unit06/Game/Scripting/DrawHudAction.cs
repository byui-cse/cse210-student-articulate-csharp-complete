using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawHudAction : Action
    {
        private VideoService _videoService;
        
        public DrawHudAction(VideoService videoService)
        {
            this._videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
            DrawLabel(cast, Constants.LEVEL_GROUP, Constants.LEVEL_FORMAT, stats.GetLevel());
            DrawLabel(cast, Constants.LIVES_GROUP, Constants.LIVES_FORMAT, stats.GetLives());
            DrawLabel(cast, Constants.SCORE_GROUP, Constants.SCORE_FORMAT, stats.GetScore());
        }

        private void DrawLabel(Cast cast, string group, string format, int data)
        {
            Label label = (Label)cast.GetFirstActor(group);
            Text text = label.GetText();
            text.SetValue(string.Format(format, data));
            Point position = label.GetPosition();
            _videoService.DrawText(text, position);
        }
    }
}