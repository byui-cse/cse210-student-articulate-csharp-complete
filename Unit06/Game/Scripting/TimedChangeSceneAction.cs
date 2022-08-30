using System;
using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class TimedChangeSceneAction : Action
    {
        private string _nextScene;
        private double _delay;
        private DateTime _start;
        
        public TimedChangeSceneAction(string nextScene, double delay, DateTime start)
        {
            this._nextScene = nextScene;
            this._delay = delay;
            this._start = start;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            DateTime currentTime = DateTime.Now;
            TimeSpan elapsedTime = currentTime.Subtract(_start);
            if (elapsedTime.Seconds > _delay)
            {
                callback.OnNext(_nextScene);
            }
        }
    }
}