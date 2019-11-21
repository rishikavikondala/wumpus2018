using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus
{
    public class HighScoreManagement
    {
        private Player[] topTen;
        private int limitTop= 10;

        //Constructor
        public HighScoreManagement()
        {
            //High Score Management Constructor
            //Creates the top ten list including the default entries.
            Cave placeholder = new Cave("null");
            this.topTen = new Player[limitTop];
            this.topTen[0] = new Player("Toma Itagaki", 0, placeholder);
            this.topTen[1] = new Player("James Joko", 0, placeholder);
            this.topTen[2] = new Player("Rishi Kavikondala", 0, placeholder);
            this.topTen[3] = new Player("Ryan Koshy", 0, placeholder);
            this.topTen[4] = new Player("Osbert Lee", 0, placeholder);
            this.topTen[5] = new Player("Adrienne Quan", 0, placeholder);
            for (int a = 6; a < limitTop; a++)
            {
                this.topTen[a] = new Player("placeholder", 0, placeholder);
            }
        }

        public void newTopTen(Player newScore)
        {
            //If the User obtains a new top ten score, mutate topTen array to include new score. If there are already
            //10 scores, knock the lowest score off the list.
            //Will be called by Player Object.
            if (newScore.getScore() > this.topTen[9].getScore())
            {
                int check = 0;
                while (check < limitTop && newScore.getScore() > topTen[9 - check].getScore())
                {
                    check++;
                }
                for (int a = 1; a < check; a++)
                {
                    this.topTen[limitTop - a] = topTen[9 - a];
                }
                this.topTen[limitTop - check] = newScore;
            }

        }

        public Player getScore(int a)
        {
            return this.topTen[a];
        }

        public void changeScore(Player change, int a)
        {
            this.topTen[a] = change;
        }

        public String toString()
        {
            String result = "";
            //Accessor for the top ten list 
            //Called by Game Control to display the current top ten list.
            for (int a = 0; a < limitTop; a++)
            {
                result += this.topTen[a].toString() + "\n\n";
            }
            result += this.topTen[9].toString();
            return result;
        }
    }
}
