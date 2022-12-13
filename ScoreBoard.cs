using System;
namespace Unit04.Game.Casting
{   
    /// <summary>
    /// <para>A thing that participates in the game.</para>
    /// <para>
    /// The responsibility of scoreboard is to keep track of its appearance, position, and score. 
    /// </para>
    /// </summary>
    public class ScoreBoard : Actor
    {
        private int _score = 0;
        /// <summary>
        /// Constructs instance of scoreboard.
        /// </summary>
        public ScoreBoard()
        {
            _score = 0;
            SetText($"Score is: {_score}");
            SetFontSize(17);
            SetColor(new Color(76, 187, 23)); // green
            SetPosition(new Point(20, 20));
            SetVelocity(new Point(0,0));
        }

        /// <summary>
        /// Gets the scoreboard's score.
        /// </summary>
        /// <returns>The message.</returns>
        public int GetScore()
        {
            return _score;
        }

        /// <summary>
        /// Sets the scoreboard score to the given value.
        /// </summary>
        /// <param name="score">The given message.</param>
        public void UpdateScore (int points)
        {
            _score += points;
            SetText($"Score is: {_score}");
        }
    }    
}