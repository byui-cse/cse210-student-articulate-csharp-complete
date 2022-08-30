using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawBallAction : Action
    {
        private VideoService _videoService;
        
        public DrawBallAction(VideoService videoService)
        {
            this._videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Ball ball = (Ball)cast.GetFirstActor(Constants.BALL_GROUP);
            Body body = ball.GetBody();

            if (ball.IsDebug())
            {
                Rectangle rectangle = body.GetRectangle();
                Point size = rectangle.GetSize();
                Point pos = rectangle.GetPosition();
                _videoService.DrawRectangle(size, pos, Constants.PURPLE, false);
            }

            Image image = ball.GetImage();
            Point position = body.GetPosition();
            _videoService.DrawImage(image, position);
        }
    }
}