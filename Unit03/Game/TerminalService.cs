using System;


namespace Unit03.Game
{
    /// <summary>
    /// <para>A service that handles terminal operations.</para>
    /// <para>
    /// The responsibility of a TerminalService is to provide input and output operations for the 
    /// terminal.
    /// </para>
    /// </summary>
    public class TerminalService
    {
        /// <summary>
        /// Constructs a new instance of TerminalService.
        /// </summary>
        public TerminalService()
        {
        }

        /// <summary>
        /// Gets numerical input from the terminal. Directs the user with the given prompt.
        /// </summary>
        /// <param name="prompt">The given prompt.</param>
        /// <returns>Inputted number.</returns>
        public int ReadNumber(string prompt)
        {
            string rawValue = ReadText(prompt);
            return int.Parse(rawValue, System.Globalization.CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Gets text input from the terminal. Directs the user with the given prompt.
        /// </summary>
        /// <param name="prompt">The given prompt.</param>
        /// <returns>Inputted text.</returns>
        public string ReadText(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        /// <summary>
        /// Displays the given text on the terminal. 
        /// </summary>
        /// <param name="text">The given text.</param>
        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }
    }
}