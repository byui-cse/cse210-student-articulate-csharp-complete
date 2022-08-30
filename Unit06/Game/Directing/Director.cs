using System.Collections.Generic;
using Unit06.Game.Casting;
using Unit06.Game.Scripting;
using Unit06.Game.Services;


namespace Unit06.Game.Directing
{
    /// <summary>
    /// A person who directs the game.
    /// </summary>
    public class Director : ActionCallback
    {
        private Cast _cast;
        private Script _script;
        private SceneManager _sceneManager;
        private VideoService _videoService;
        
        /// <summary>
        /// Constructs a new instance of Director using the given VideoService.
        /// </summary>
        /// <param name="videoService">The given VideoService.</param>
        public Director(VideoService videoService)
        {
            this._videoService = videoService;
            this._cast = new Cast();
            this._script = new Script();
            this._sceneManager = new SceneManager();
        }

        /// </inheritdoc>
        public void OnNext(string scene)
        {
            _sceneManager.PrepareScene(scene, _cast, _script);
        }
        
        /// <summary>
        /// Starts the game by running the main game loop for the given cast and script.
        /// </summary>
        public void StartGame()
        {
            OnNext(Constants.NEW_GAME);
            ExecuteActions(Constants.INITIALIZE);
            ExecuteActions(Constants.LOAD);
            while (_videoService.IsWindowOpen())
            {
                ExecuteActions(Constants.INPUT);
                ExecuteActions(Constants.UPDATE);
                ExecuteActions(Constants.OUTPUT);
            }
            ExecuteActions(Constants.UNLOAD);
            ExecuteActions(Constants.RELEASE);
        }

        private void ExecuteActions(string group)
        {
            List<Action> actions = _script.GetActions(group);
            foreach(Action action in actions)
            {
                action.Execute(_cast, _script, this);
            }
        }
    }
}