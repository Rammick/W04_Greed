using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Unit04.Game.Casting;
using Unit04.Game.Directing;
using Unit04.Game.Services;
using Unit04;


namespace unit04_greed
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        private static int DEFAULT_gem = 5;
        private static int DEFAULT_stone = 10;

        private static string CAPTION = "Greed";


        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            // create the cast
            Cast cast = new Cast();

            // create scoreboard 
            ScoreBoard scoreboard = new ScoreBoard();
            cast.AddActor("scoreboard", scoreboard);

            // create the player
            Player player = new Player();
            cast.AddActor("player", player);


            // create the gems
            Random random = new Random();
            for (int i = 0; i < DEFAULT_gem; i++)
            {
                SkyDrops skyDrops = new SkyDrops(true);
                cast.AddActor("skyDrops", skyDrops);
            }

             // create the stones
            Random randomTwo = new Random();
            for (int i = 0; i < DEFAULT_stone; i++)
            {
                SkyDrops skyDrops = new SkyDrops(false);
                cast.AddActor("skyDrops", skyDrops);
            }
    
            // start the game
            KeyboardService keyboardService = new KeyboardService(Constants.CELL_SIZE);
            VideoService videoService 
                = new VideoService(CAPTION, Constants.MAX_X, Constants.MAX_Y, Constants.CELL_SIZE, Constants.FRAME_RATE, false);
            Director director = new Director(keyboardService, videoService);
            director.StartGame(cast);
        }
    }
}
