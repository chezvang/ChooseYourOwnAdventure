using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            //player start, alive, checks if player is alive
            StartPlayer startPlayer = new StartPlayer(true);

            //player goes into story, alive
            Story startStory = new Story();
            startStory.StartStory();
            //check if player alive or dead when out of story
            StartPlayer playerLifeCheck = new StartPlayer(false);

            //if player dead, end, game over
            //playerLife.EndGame();

            //if player alive, end, win

            Console.ReadKey();


        }
    }
}
