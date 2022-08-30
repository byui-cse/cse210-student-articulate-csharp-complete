using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class ControlRacketAction : Action
    {
        private KeyboardService _keyboardService;

        public ControlRacketAction(KeyboardService keyboardService)
        {
            this._keyboardService = keyboardService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Racket racket = (Racket)cast.GetFirstActor(Constants.RACKET_GROUP);
            if (_keyboardService.IsKeyDown(Constants.LEFT))
            {
                racket.SwingLeft();
            }
            else if (_keyboardService.IsKeyDown(Constants.RIGHT))
            {
                racket.SwingRight();
            }
            else
            {
                racket.StopMoving();
            }
        }
    }
}