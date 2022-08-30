using System.Collections.Generic;


namespace Unit06.Game.Scripting
{
    /// <summary>
    /// A collection of actions.
    /// </summary>
    public class Script
    {
        private Dictionary<string, List<Action>> _actions = new Dictionary<string, List<Action>>();

        /// <summary>
        /// Constructs a new instance of Script.
        /// </summary>
        public Script()
        {
        }

        /// <summary>
        /// Adds the given action to the given group.
        /// </summary>
        /// <param name="group">The group name.</param>
        /// <param name="action">The action to add.</param>
        public void AddAction(string group, Action action)
        {
            if (!_actions.ContainsKey(group))
            {
                _actions[group] = new List<Action>();
            }

            if (!_actions[group].Contains(action))
            {
                _actions[group].Add(action);
            }
        }

        /// <summary>
        /// Clears the actions in the given group.
        /// </summary>
        /// <param name="group">The given group.</param>
        public void ClearActions(string group)
        {
            if (_actions.ContainsKey(group))
            {
                _actions[group] = new List<Action>();
            }
        }

        /// <summary>
        /// Clears all the actions in the script.
        /// </summary>
        public void ClearAllActions()
        {
            foreach(string group in _actions.Keys)
            {
                _actions[group] = new List<Action>();
            }
        }

        /// <summary>
        /// Gets the actions in the given group. Returns an empty list if there aren't any.
        /// </summary>
        /// <param name="group">The group name.</param>
        /// <returns>The list of actions.</returns>
        public List<Action> GetActions(string group)
        {
            List<Action> results = new List<Action>();
            if (_actions.ContainsKey(group))
            {
                results.AddRange(_actions[group]);
            }
            return results;
        }

        /// <summary>
        /// Removes the given action from the given group.
        /// </summary>
        /// <param name="group">The group name.</param>
        /// <param name="action">The action to remove.</param>
        public void RemoveAction(string group, Action action)
        {
            if (_actions.ContainsKey(group))
            {
                _actions[group].Remove(action);
            }
        }

    }
}