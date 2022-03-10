using Unit06.Game.Casting;


namespace Unit06.Game.Scripting 
{
    /// <summary>
    /// A thing that is done in the game.
    /// </summary>
    public interface Action
    {
        /// <summary>
        /// Executes something that is important in the game. This method should be overriden by 
        /// derived classes.
        /// </summary>
        /// <param name="cast">The cast of actors.</param>
        /// <param name="script">The script of actions.</param>
        void Execute(Cast cast, Script script, ActionCallback callback);
    }
}