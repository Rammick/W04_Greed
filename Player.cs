using System;


namespace Unit04.Game.Casting
{
    /// <summary>
    /// <para>A participant in the game, captures gems and stones.</para>
    /// <para>
    /// The responsibility of Player is to keep track of its appearance, position and velocity in 2d 
    /// space.
    /// </para>
    /// </summary>
    public class Player : Actor
    {
        public Player()
        {
            SetText("#");
            SetFontSize(15);
            SetColor(new Color(75, 0, 130)); // indigo
            SetPosition(new Point(450, 550));
            SetVelocity(new Point(0,0));

        }
    }
}