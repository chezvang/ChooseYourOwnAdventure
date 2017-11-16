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
        public bool playerLife;

        public StartPlayer(bool isPlayerAlive)
        {
            if (isPlayerAlive == true)
            {
                Console.WriteLine("The player is alive.");
                PlayerLifeCheck(true);
            }
            else
            {
                this.isPlayerAlive = false;
                PlayerLifeCheck(false);
            }
        }
        public void PlayerLifeCheck(bool isPlayerAlive)
        {
            if (isPlayerAlive == true)
            {
                this.playerLife = true;
            }
            else
            {
                this.playerLife = false;
                Console.WriteLine("Game over");
            }
        }
    }
}
