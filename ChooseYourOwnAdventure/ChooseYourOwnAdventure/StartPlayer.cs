using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure
{
    class StartPlayer
    {
        //player alive or dead
        public bool isPlayerAlive;
        public string playerStatus;

        public StartPlayer(bool isPlayerAlive)
        {
            if (isPlayerAlive == true)
            {
                isPlayerAlive = true;
                Console.WriteLine("The player is alive.");
            }
            else
            {
                isPlayerAlive = false;
                Console.WriteLine("The player is dead.");
            }
        }
    }
}
