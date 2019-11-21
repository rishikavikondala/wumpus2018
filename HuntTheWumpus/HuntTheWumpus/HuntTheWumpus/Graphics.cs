/*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;

namespace HuntTheWumpus 
{
    class Graphics
    {
        //Variable init to establish pathway differentiation and image source
        Boolean mainPathway = true; string path = @"C:\Users\Zensk\Desktop\Important Stuff\School\11th Grade\AP Computer Science\Hunt The Wumpus\Project\WumpusGraphicsSound\WumpusGraphicsSound\Bitmap Images";
        //Switches the path of the graphics, in case the user wants a different looking game. 
        public void changePathway()
        {
            mainPathway = !mainPathway;
            if (mainPathway)
            {
                //Main pathway of images, theme one. 
                path = @"C:\Users\Zensk\Desktop\Important Stuff\School\11th Grade\AP Computer Science\Hunt The Wumpus\Project\WumpusGraphicsSound\WumpusGraphicsSound\Bitmap Images";
            }
            else
            {
                //Secondary pathway of images, path two.
                path = "";
            }
        }
        //Switches the background image to the splash screen, for the start of the game.
        public void setSplashScreen()
        {
            Image currSet = new Bitmap(Path.Combine(path, "SplashScreen.bmp"));
            this.BackgroundImage = currSet;
        }
        //Switches the background image to the instructions screen, for the instructions of the game. 
        public void setInstructionsScreen()
        {
            Image currSet = new Bitmap(Path.Combine(path, "InstructionsScreen.bmp"));
            this.BackgroundImage = currSet;
        }
        //Switches the background image to the regular cave screen, without any hazards or the Wumpus.
        public void setRegularCaveScreen()
        {
            Image currSet = new Bitmap(Path.Combine(path, "WumpusCaveOne.bmp"));
            this.BackgroundImage = currSet;
        }
        //Switches the background image to the bat cave screen.
        public void setBatCaveScreen()
        {
            Image currSet = new Bitmap(Path.Combine(path, "WumpusBatCave.bmp"));
            this.BackgroundImage = currSet;
        }
        //Switches the background image to the pit cave screen. 
        public void setPItCaveScreen()
        {
            Image currSet = new Bitmap(Path.Combine(path, "WumpusPitCave.bmp"));
            this.BackgroundImage = currSet;
        }
    }
}
*/