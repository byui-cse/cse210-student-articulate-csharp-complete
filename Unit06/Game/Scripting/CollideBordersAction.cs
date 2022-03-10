using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class CollideBordersAction : Action
    {
        private AudioService audioService;
        private PhysicsService physicsService;
        
        public CollideBordersAction(PhysicsService physicsService, AudioService audioService)
        {
            this.physicsService = physicsService;
            this.audioService = audioService;
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
                audioService.PlaySound(bounceSound);
            }
            else if (x >= Constants.FIELD_RIGHT - Constants.BALL_WIDTH)
            {
                ball.BounceX();
                audioService.PlaySound(bounceSound);
            }

            if (y < Constants.FIELD_TOP)
            {
                ball.BounceY();
                audioService.PlaySound(bounceSound);
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
                    audioService.PlaySound(overSound);
                }
            }
        }
    }
}