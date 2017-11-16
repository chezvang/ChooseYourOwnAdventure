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
            //player start, alive
            StartPlayer startPlayer = new StartPlayer(true);
            Console.ReadKey();
            //player goes into story, alive
            //Story startPlayer = new Story(true);
            //check if player alive or dead when out of story
            //if player dead, end, game over
            
            //if player alive, end, win


        }
    }
}
