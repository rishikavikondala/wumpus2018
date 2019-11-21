using System;

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
        private int numRight;
        private int numQuestions;

        //Constructor for a Player object.
        //Will be called by Game Control to initialize a Player
        public Player(String player, Cave cave, Map map)
        {
            this.map = map;
            this.playerName = player;
            this.arrows = 3;
            this.gold = 0;
            this.goldMap = 100;
            this.turns = 0;
            this.score = 130;
            this.cave = cave;
            this.questions = new Trivia();
            this.numRight = 0;
            this.numQuestions = 0;
        }

        //This Constructor makes the default cases in the starting High Score list easy to assign.
        //Will be called by High Score Management
        public Player(String player, int score, Cave cave)
        {
            this.playerName = player;
            this.score = score;
            this.cave = cave;
        }

        //This method will be called before the move method to ensure that the room that the player
        //wants to move inside is a valid room
        //Will be called by Game control
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
            if (this.goldMap > 0)
            {
                this.gold++;
                this.goldMap--;
                s1.buttonPressed();
            }
            updateScore();
            using (var form = new HintForm())
            {
                var result = form.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                }
            }
            map.movePlayer(direction);
            map.closeBy(direction);
        }



        //Used for player to shoot an arrow into a room of desired direction
        //Called by Game Control
        //IF RETURNS TRUE THEN YOU WIN
        public bool shootArrow(String direction)
        {
            Sound s1 = new Sound();
            this.arrows--;
            this.turns++;
            s1.shootArrow();
            updateScore();
            bool result = false;
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

        public bool purchaseArrows()
        {
            //call trivia class and ask two questions and return if they got 
            //at least 2 or more correct
            this.numRight = 0;
            this.numQuestions = 0;
            while (this.numRight < 2 && this.numQuestions < 3)
            {
                this.gold--;
                using (var form = new TriviaForm())
                {
                    var result = form.ShowDialog();
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        this.numRight += form.correct;
                    }
                }
                this.numQuestions++;
            }
            if (this.numRight == 2)
            {
                this.arrows = this.arrows + 2;
                updateScore();
                return true;
            }
            updateScore();
            return false;
        }

        public bool purchaseSecret()
        {
            //call trivia
            //Iff the user gets two out of the three questions asked right, they will be given intel
            String secret = "";
            this.numRight = 0;
            this.numQuestions = 0;
            while (this.numRight < 2 && this.numQuestions < 3)
            {
                this.gold--;
                using (var form = new TriviaForm())
                {
                    var result = form.ShowDialog();
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        this.numRight += form.correct;
                    }
                }
                this.numQuestions++;
            }
            if (this.numRight == 2)
            {
                updateScore();
                return true;
            }
            updateScore();
            return false;
        }

        public bool WumpTrivia()
        {
            //call trivia
            //Iff the user gets two out of the three questions asked right, they will be given intel
            this.numRight = 0;
            this.numQuestions = 0;
            while (this.numRight < 3 && this.numQuestions < 5)
            {
                this.gold--;
                using (var form = new TriviaForm())
                {
                    var result = form.ShowDialog();
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        this.numRight += form.correct;
                    }
                }
                this.numQuestions++;
            }
            if (this.numRight == 3)
            {
                updateScore();
                return true;
            }
            updateScore();
            return false;
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