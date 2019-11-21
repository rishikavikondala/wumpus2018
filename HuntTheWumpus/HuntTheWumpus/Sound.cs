using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus
{
    public class Sound
    {
        //Plays the sound of a coin dropping, simulates a button press from the user. 
        public void buttonPressed()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\pumpk\source\repos\HuntTheWumpus\Sound Files\ButtonPress-[AudioTrimmer.com].wav");
            simpleSound.Play();
        }
        //Plays the sound of the door opening, simulates the game beginning for the user. 
        public void doorOpened()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\pumpk\source\repos\HuntTheWumpus\Sound Files\DoorOpening-[AudioTrimmer.com].wav");
            simpleSound.Play();
        }
        //Plays the sound of footsteps, simulates the user moving from one cave to the other. 
        public void footsteps()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\pumpk\source\repos\HuntTheWumpus\Sound Files\Footsteps-[AudioTrimmer.com].wav");
            simpleSound.Play();
        }
        //Plays the sound of bats, simulates the presence of bats. 
        public void batsPresent()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\pumpk\source\repos\HuntTheWumpus\Sound Files\Bats-[AudioTrimmer.com].wav");
            simpleSound.Play();
        }
        //Plays the sound of wind, simulates the presence of a botomless pit. 
        public void pitPresent()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\pumpk\source\repos\HuntTheWumpus\Sound Files\Wind-[AudioTrimmer.com].wav");
            simpleSound.Play();
        }
        //Plays the sound of alpacas mating, simulates the presence of the wumpus. 
        public void wumpusPresent()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\pumpk\source\repos\HuntTheWumpus\Sound Files\Wumpus-[AudioTrimmer.com].wav");
            simpleSound.Play();
        }
        //Plays the sound of a happy wind instrument, simulates the user winning the game. 
        public void gameWinning()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\pumpk\source\repos\HuntTheWumpus\Sound Files\WinningSound-[AudioTrimmer.com].wav");
            simpleSound.Play();
        }
        //Plays the sound of a sad wind instrument, simulates the user losing the game. 
        public void gameLosing()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\pumpk\source\repos\HuntTheWumpus\Sound Files\GameEnding-[AudioTrimmer.com].wav");
            simpleSound.Play();
        }
        public void shootArrow()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\pumpk\source\repos\HuntTheWumpus\Sound Files\Arrow+Swoosh+2.wav");
            simpleSound.Play();
        }
        //Plays a sound when the player answers a trivia question correctly.
        public void correct()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\pumpk\source\repos\HuntTheWumpus\Sound Files\ding.wav");
            simpleSound.Play();
        }
        //Plays a sound when the player answers a trivia question incorrectly.
        public void incorrect()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\pumpk\source\repos\HuntTheWumpus\Sound Files\buzz.wav");
            simpleSound.Play();
        }

    }
}
