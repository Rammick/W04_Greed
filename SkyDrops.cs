using System;
using System.Collections.Generic;

namespace Unit04.Game.Casting
{

    /// <summary>
    /// <para>A thing that participates in the game.</para>
    /// <para>
    /// The responsibility of skydrops is to keep track of its appearance, position, velocity in 2d space, and type as gem or stone.
    ///Randomly selects gem or stone and color.
    /// </para>
    /// </summary>
    class SkyDrops : Actor
    {
        private string _type;

        // sets skydrop to gem or stone
        public SkyDrops(bool isGem)
        {
            if (isGem)
            {
                SetText(((char)42).ToString());
                _type = "gem";
            }
            else 
            {
                SetText(((char)79).ToString());
                _type = "stone";
            }
            Random random = new Random();
            /// r, g, and b are used to create random colors
            int r = random.Next(0, 256);
            int g = random.Next(0, 256);
            int b = random.Next(0, 256);
            SetColor(new Color(r, g, b));
            SetFontSize(20);
            SetPosition(new Point(random.Next(Constants.MAX_X),random.Next(35, 60))); 
            SetVelocity(new Point(0, random.Next(5, 8)));
        }
        /// <summary>
        ///Returns type of skydrop; gem or stone/// </summary>
        public string GetDropType()
        {
            return _type;
        }
    }
}