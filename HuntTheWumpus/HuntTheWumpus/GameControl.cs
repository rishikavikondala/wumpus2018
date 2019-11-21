// Rishi Kavikondala
// Period 6 - AP Computer Science
// Hunt The Wumpus - Game Control Class
// Date --> 5/24/2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus
{
    public class GameControl // will be integrated later with the windows forms
    {
        // FIELDS - constructors for each individual class (so far player, sound, and cave implemented)
        //Player player;
        Cave cave; // will work on Cave in class on 5/24
        Sound sound;
        Trivia trivia;

        /*NOTE: the rest of sound will be implemented when the other classes are implemented
         * Many sounds cannot be added without other features of the game (bats, the wumpus, etc.)
         */

        // GameControl Constructor - launches a new game
        public GameControl()
        {
            //this.player = new Player("Player", cave, map);
            this.cave = new Cave("cave");
            this.sound = new Sound();
            this.trivia = new Trivia();
        }

        public int[] getExits(int[] exits) {
            return exits;
        }
    }
}