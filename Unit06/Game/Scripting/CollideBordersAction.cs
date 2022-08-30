using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class CollideBordersAction : Action
    {
        private AudioService _audioService;
        private PhysicsService _physicsService;
        
        public CollideBordersAction(PhysicsService physicsService, AudioService audioService)
        {
            this._physicsService = physicsService;
            this._audioService = audioService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Ball ball = (Ball)cast.GetFirstActor(Constants.BALL_GROUP);
            Body body = ball.GetBody();
            Point position = body.GetPosition();
            int x = position.GetX();
            int y = position.GetY();
            Sound bounceSound = new Sound(Constants.BOUNCE_SOUND);
            Sound overSound = new Sound(Constants.OVER_SOUND);

            if (x < Constants.FIELD_LEFT)
            {
                ball.BounceX();
                _audioService.PlaySound(bounceSound);
            }
            else if (x >= Constants.FIELD_RIGHT - Constants.BALL_WIDTH)
            {
                ball.BounceX();
                _audioService.PlaySound(bounceSound);
            }

            if (y < Constants.FIELD_TOP)
            {
                ball.BounceY();
                _audioService.PlaySound(bounceSound);
            }
            else if (y >= Constants.FIELD_BOTTOM - Constants.BALL_WIDTH)
            {
                Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
                stats.RemoveLife();

                if (stats.GetLives() > 0)
                {
                    callback.OnNext(Constants.TRY_AGAIN);
                }
                else
                {
                    callback.OnNext(Constants.GAME_OVER);
                    _audioService.PlaySound(overSound);
                }
            }
        }
    }
}