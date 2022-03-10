using System.Numerics;
using Raylib_cs;
using Unit06.Game.Casting;


namespace Unit06.Game.Services
{
    public class RaylibPhysicsService : PhysicsService
    {
        /// </inheritdoc>
        public bool HasCollided(Body subject, Body agent)
        {
            Raylib_cs.Rectangle subjectRectangle = ToRectangle(subject);
            Raylib_cs.Rectangle agentRectangle = ToRectangle(agent);
            return Raylib.CheckCollisionRecs(subjectRectangle, agentRectangle);
        }

        public Raylib_cs.Rectangle ToRectangle(Body body)
        {
            int x = body.GetPosition().GetX();
            int y = body.GetPosition().GetY();
            int width = body.GetSize().GetX();
            int height = body.GetSize().GetY();
            return new Raylib_cs.Rectangle(x, y, width, height);
        }
    }
}