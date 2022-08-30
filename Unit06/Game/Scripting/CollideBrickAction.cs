using System.Collections.Generic;
using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class CollideBrickAction : Action
    {
        private AudioService _audioService;
        private PhysicsService _physicsService;
        
        public CollideBrickAction(PhysicsService physicsService, AudioService audioService)
        {
            this._physicsService = physicsService;
            this._audioService = audioService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Ball ball = (Ball)cast.GetFirstActor(Constants.BALL_GROUP);
            List<Actor> bricks = cast.GetActors(Constants.BRICK_GROUP);
            Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
            
            foreach (Actor actor in bricks)
            {
                Brick brick = (Brick)actor;
                Body brickBody = brick.GetBody();
                Body ballBody = ball.GetBody();

                if (_physicsService.HasCollided(brickBody, ballBody))
                {
                    ball.BounceY();
                    Sound sound = new Sound(Constants.BOUNCE_SOUND);
                    _audioService.PlaySound(sound);
                    int points = brick.GetPoints();
                    stats.AddPoints(points);
                    cast.RemoveActor(Constants.BRICK_GROUP, brick);
                }
            }
        }
    }
}