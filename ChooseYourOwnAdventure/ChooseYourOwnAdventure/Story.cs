using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure
{
    class Story
    {
        //player life
        public bool playerLife;

        //start story
        public void StartStory()
        {
            Console.WriteLine("The sea salt stings your nostrils as you inhale your first breaths. Your eyes open to to a vast beach of white sand. Waves crash against the shore more frequently as if the ocean were pointing you towards the cliffs.");
            FirstFork();
        }
        public void FirstFork()
        {
            Console.WriteLine("As you approach the cliff you find a two diverging paths. One path leads to the mouth of a cave, the other looks as though it leads to the top of the cliffs. Which path do you take? Choose 'top' for the cliffs or 'bottom' for the caves.");
            string decision = Console.ReadLine();
            
            switch (decision)
            {
                case "Top":
                    Console.WriteLine("You reach the top of the cliff to find yourself in the jaws of a wild lion.");
                    break;
                case "Bottom":
                    Console.WriteLine("You cautiously approach the mouth of the cave. A giant brown column strikes the rocks in front of you. The sheer display of force stuns you long enough for you to feel sleepy, then nothing at all your vision fades to black.");
                    break;
                default:
                    Console.WriteLine("Choose a path, 'Top' or 'Bottom'.");
                    FirstFork();
                    break;
            }
            
        }
    }
}
