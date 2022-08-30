using System.Collections.Generic;


namespace Unit04.Game.Casting
{
    /// <summary>
    /// <para>A collection of actors.</para>
    /// <para>
    /// The responsibility of a cast is to keep track of a collection of actors. It has methods for 
    /// adding, removing and getting them by a group name.
    /// </para>
    /// </summary>
    public class Cast
    {
        private Dictionary<string, List<Actor>> _actors = new Dictionary<string, List<Actor>>();

        /// <summary>
        /// Constructs a new instance of Cast.
        /// </summary>
        public Cast()
        {
        }

        /// <summary>
        /// Adds the given actor to the given group.
        /// </summary>
        /// <param name="group">The group name.</param>
        /// <param name="actor">The actor to add.</param>
        public void AddActor(string group, Actor actor)
        {
            if (!_actors.ContainsKey(group))
            {
                _actors[group] = new List<Actor>();
            }

            if (!_actors[group].Contains(actor))
            {
                _actors[group].Add(actor);
            }
        }

        /// <summary>
        /// Gets the actors in the given group. Returns an empty list if there aren't any.
        /// </summary>
        /// <param name="group">The group name.</param>
        /// <returns>The list of actors.</returns>
        public List<Actor> GetActors(string group)
        {
            List<Actor> results = new List<Actor>();
            if (_actors.ContainsKey(group))
            {
                results.AddRange(_actors[group]);
            }
            return results;
        }

        /// <summary>
        /// Gets all the actors in the cast.
        /// </summary>
        /// <returns>A list of all actors.</returns>
        public List<Actor> GetAllActors()
        {
            List<Actor> results = new List<Actor>();
            foreach (List<Actor> result in _actors.Values)
            {
                results.AddRange(result);
            }
            return results;
        }

        /// <summary>
        /// Gets the first actor in the given group.
        /// </summary>
        /// <param name="group">The group name.</param>
        /// <returns>The first actor.</returns>
        public Actor GetFirstActor(string group)
        {
            Actor result = null;
            if (_actors.ContainsKey(group))
            {
                if (_actors[group].Count > 0)
                {
                    result = _actors[group][0];
                }
            }
            return result;
        }

        /// <summary>
        /// Removes the given actor from the given group.
        /// </summary>
        /// <param name="group">The group name.</param>
        /// <param name="actor">The actor to remove.</param>
        public void RemoveActor(string group, Actor actor)
        {
            if (_actors.ContainsKey(group))
            {
                _actors[group].Remove(actor);
            }
        }

    }
}