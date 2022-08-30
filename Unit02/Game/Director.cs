using System;
using System.Collections.Generic;


namespace Unit02.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        List<Die> _dice = new List<Die>();
        bool _isPlaying = true;
        int _score = 0;
        int _totalScore = 0;

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            for (int i = 0; i < 5; i++)
            {
                Die die = new Die();
                _dice.Add(die);
            }
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Asks the user if they want to roll.
        /// </summary>
        public void GetInputs()
        {
            Console.Write("Roll dice? [y/n] ");
            string rollDice = Console.ReadLine();
            _isPlaying = (rollDice == "y");
        }

        /// <summary>
        /// Updates the player's score.
        /// </summary>
        public void DoUpdates()
        {
            if (!_isPlaying)
            {
                return;
            }

            _score = 0;
            foreach (Die die in _dice)
            {
                die.Roll();
                _score += die._points;
            }
            _totalScore += _score;
        }

        /// <summary>
        /// Displays the dice and the score. Also asks the player if they want to roll again. 
        /// </summary>
        public void DoOutputs()
        {
            if (!_isPlaying)
            {
                return;
            }

            string values = "";
            foreach (Die die in _dice)
            {
                values += $"{die._value} ";
            }

            Console.WriteLine($"You rolled: {values}");
            Console.WriteLine($"Your score is: {_totalScore}\n");
            _isPlaying = (_score > 0);
        }
    }
}


