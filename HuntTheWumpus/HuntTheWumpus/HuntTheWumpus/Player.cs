using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus
{
    public class Player
    {
        private String playerName;
        private int score;
        private int turns;
        private int gold;
        private int goldMap;
        private int arrows;
        private Cave cave;
        private Trivia questions;
        private Map map;

        public Player(String player, Cave cave, Map map)
        {
            //Constructor for a score object.
            //Will be called by Game Control
            this.map = map;
            this.playerName = player;
            this.arrows = 3;
            this.gold = 0;
            this.goldMap = 100;
            this.turns = 0;
            this.score = 130;
            this.cave = cave;
            this.questions = new Trivia();
        }

        public Player(String player, int score, Cave cave)
        {
            //This Constructor makes the default cases easy to assign.
            //Will be called by Game Control
            this.playerName = player;
            this.score = score;
            this.cave = cave;
        }


        public bool validMove(String direction)
        {
            if (this.map.validRoom(direction))
            {
                return true;
            }
            return false;
        }

        //used for player to move to a certain room in the cave
        //Game control will call this object
        public void Move(String direction)
        {
            Sound s1 = new Sound();
            this.turns++;
            //call the map object to get the current room number
            //s1.footsteps();
            if(this.goldMap > 0)
            {
                this.gold++;
                this.goldMap--;
                //s1.buttonPressed();
            }
            Console.WriteLine(questions.giveHint());
            //if wumpus is nearby, print to console wumpus is nearby and play sound
            map.movePlayer(direction);
            map.closeBy(direction);
            updateScore();

            //return 0; return new number based on what direction
        }



        //Used for player to shoot an arrow into a room of desired direction
        //Called by Game Control
        //IF RETURNS TRUE THEN YOU WIN
        public bool shootArrow(String direction)
        {
            Sound s1 = new Sound();
            arrows--;
            s1.shootArrow();
            updateScore();
            bool result = false;
            //call map class to find where wumpus is
            //if (room == wumpusLocation()) { return true }

            if (map.shoot(direction))
            {
                result = true;
            }
            return result;

            //After this method is called, it shoudld check if 
            //the player has lost or won
            //i.e. if method returns true, play has won, if false
            //check if there are > 0 arrows
        }

        public void purchaseArrows()
        {
            Sound s1 = new Sound();
            //call trivia class and ask two questions and return if they got 
            //at least 2 or more correct
            int numRight = 0;
            int numQ = 0;
            while (numRight < 2 && numQ < 3)
            {
                this.gold--;
                Console.WriteLine(questions.askQuestion());
                Console.WriteLine("Pick an Option (A, B, C, or D):");
                String input = Console.ReadLine();
                input.ToLower();
                if (questions.checkAnswer(input))
                {
                    Console.WriteLine("Correct!");
                    numRight++;
                    s1.correct();
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                    s1.incorrect();
                }
                numQ++;
            }
            if (numRight > 2)
            {
                Console.WriteLine("Awesome! You got " + numRight +
                    "questions right, giving you 2 extra arrows!");
                this.arrows = this.arrows + 2;
                updateScore();
            }
            else
            {
                Console.WriteLine("Sorry, you got " + numRight +
                    "questios right out of the required two. You did not recieve extra arrows...");
            }
        }

        public void purchaseSecret()
        {
            Sound s1 = new Sound();
            //call trivia
            //Iff the user gets two out of the three questions asked right, they will be given intel
            int numRight = 0;
            int numQ = 0;
            while (numRight < 2 && numQ < 3)
            {
                this.gold--;
                Console.WriteLine(questions.askQuestion());
                Console.WriteLine("Pick an Option (A, B, C, or D):");
                String input = Console.ReadLine();
                input.ToLower();
                if (questions.checkAnswer(input))
                {
                    Console.WriteLine("Correct!");
                    numRight++;
                    s1.correct();
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                    s1.incorrect();
                }
                numQ++;
            }
            if (numRight > 2)
            {
                Console.WriteLine("Awesome! You got " + numRight +
                    "questions right, giving you a secret piece of intelligence!");
                updateScore();
            }
            else
            {
                Console.WriteLine("Sorry, you got " + numRight +
                    "questios right out of the required two. You did not recieve extra arrows");
            }
        }

        public void WumpTrivia ()
        {
            Sound s1 = new Sound();
            //call trivia
            //Iff the user gets two out of the three questions asked right, they will be given intel
            int numRight = 0;
            int numQ = 0;
            while (numRight < 3 && numQ < 5)
            {
                this.gold--;
                Console.WriteLine(questions.askQuestion());
                Console.WriteLine("Pick an Option (A, B, C, or D):");
                String input = Console.ReadLine();
                input.ToLower();
                if (questions.checkAnswer(input))
                {
                    Console.WriteLine("Correct!");
                    numRight++;
                    s1.correct();
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                    s1.incorrect();
                }
                numQ++;
            }
            if (numRight > 3)
            {
                Console.WriteLine("Awesome! You got " + numRight +
                    "questions right, giving you a secret piece of intelligence!");
                updateScore();
            }
            else
            {
                Console.WriteLine("Sorry, you got " + numRight +
                    "questions right out of the required two. You did not recieve extra arrows");
            }
        }

        public int getScore()
        {
            //Accessor for score. I believe this will be helpful in figuring out if said score is worth a top ten spot.
            //Will be called by High Score Management
            return this.score;
        }

        public int getTurns()
        {
            //Accessor for Turns. I believe this will be helpful in obtaining the stats for a top ten score and
            //subsequently printing it in the top ten scoreboard.
            //Will be called by High Score Management
            return this.turns;
        }
        public int getGold()
        {
            //Accessor for Gold left. I believe this will be helpful in obtaining the stats for a top ten score and
            //subsequently printing it in the top ten scoreboard.
            //Will be called by High Score Management
            return this.gold;
        }

        public int getArrows()
        {
            //Accessor for Arrows left. I believe this will be helpful in obtaining the stats for a top ten score and
            //subsequently printing it in the top ten scoreboard.
            //Will be called by High Score Management
            return this.arrows;
        }

        public void updateScore()
        {
            this.score = 100 - this.turns + this.gold + (10 * this.arrows);
        }

        public String toString()
        {
            //toString for allow object to work with System.out.println().
            //Will be called by High Score Management and subsequently Game Control to print the top ten list.
            return "Player: " + this.playerName + " Score: " + this.score + " Number of turns taken: " + this.turns +
                " Gold coins left: " + this.gold + " Arrows Left: " + this.arrows + " Cave: " + this.cave.getName();
        }
    }
}