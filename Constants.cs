using Unit04.Game.Casting;
using Unit04.Game.Directing;
using Unit04.Game.Services;

namespace Unit04
{
    /// <summary>
    /// The responsibility of constants is to keep track of all the constants, max_x and max_y, gem and stone ratio, and other constants if needed.
    /// </summary>
    public static class Constants
    {
        public static int FRAME_RATE = 12;
        public static int MAX_X = 900;
        public static int MAX_Y = 600;
        public static int CELL_SIZE = 15;
        public static int FONT_SIZE = 15;
        public static int COLS = 60;
        public static int ROWS = 40;
        
        public static Color WHITE = new Color(255, 255, 255);
        public static int DEFAULT_gem = 5;
        public static int DEFAULT_stone = 10;

        public static string CAPTION = "Greed";
    }
}