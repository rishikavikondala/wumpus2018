using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuntTheWumpus
{
    public partial class Game : Form
    {
        private String controlInput;
        private String playerName;
        private GameControl game;
        private Cave cave;
        private Map map;
        private Player player;
        public HighScoreManagement scores;
        public Sound sound;
        private Player latestPlayer;
        private HighScores highscores;
        public static bool winloseVar = false;

        public Game(Cave kave)
        {
            InitializeComponent();
            this.cave = kave;
            this.scores = new HighScoreManagement() ;
            map = new HuntTheWumpus.Map(2, 2, cave);
            game = new GameControl();
            //using(MainMenu mainMenu = new MainMenu())
            //{
            //    if(mainMenu.ShowDialog() == DialogResult.OK)
            //    {
            //        this.playerName = mainMenu.getPlayerName;
            //    }
            //}
            player = new Player(playerName, cave, map);
            sound = new Sound();
            highscores = new HighScores();
            updateConnections();
            showRoom();
        }

        public static bool getWinLose()
        {
            return winloseVar;
        }

        private void input_TextChanged(object sender, EventArgs e) { controlInput = input.Text; }

        private void quit_Click(object sender, EventArgs e) { Application.Exit(); }

        private void win() { this.Hide(); (new Win()).Show(); }

        private void lose() { this.Hide(); (new Lose()).Show(); }

        private void move_Click(object sender, EventArgs e)
        {
            if (map.validRoom(controlInput) && controlInput.Length > 0)
            {
                player.Move(controlInput);
                scoreBox.Text = "Total Score: " + player.getScore();
                goldBox.Text = "Total Gold: " + player.getGold();
                turn.Text = "Total Turns: " + player.getTurns();
                map.moveBat();
                map.moveWumpus();
                if (map.getPlayerIndex() == "W")
                {
                    playerOpposite.Image = Image.FromFile(@"C:\Users\pumpk\Google Drive\HuntTheWumpus-20180608T021536Z-001\HuntTheWumpus\Images\pit.bmp");
                    System.Windows.Forms.MessageBox.Show("You are in the same cave as the Wumpus!");
                    Thread.Sleep(1500);
                    if (player.WumpTrivia())
                    {
                        System.Windows.Forms.MessageBox.Show("Awesome! You got 2 questions right, allowing you to barely escape the clutches of the Wumpus!");
                        map.wumpusMeetsPlayer();
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Sorry, you didn't correctly answer enough questions. You did not escape the Wumpus' grasp. You have been eliminated");
                        this.Hide();
                        (new Lose()).Show();
                    }
                }
                if (map.getPlayerIndex() == "D")
                {
                    playerOpposite.Image = Image.FromFile(@"C:\Users\pumpk\Google Drive\HuntTheWumpus-20180608T021536Z-001\HuntTheWumpus\Images\Pit.bmp");
                    System.Windows.Forms.MessageBox.Show("You have fallen into a ditch! You lose!");
                    Thread.Sleep(2000);
                    this.Hide();
                    (new Lose()).Show();
                    Thread.Sleep(2000);
                    this.Hide();
                    (new HighScores()).Show();
                }
                if (map.getPlayerIndex() == "B")
                {
                    playerOpposite.Image = Image.FromFile(@"C:\Users\pumpk\Google Drive\HuntTheWumpus-20180608T021536Z-001\HuntTheWumpus\Images\bat.bmp");
                    System.Windows.Forms.MessageBox.Show("You have run into a bat! You're getting moved!");
                    map.randomizePlayer();
                    playerOpposite.Image = null;
                }
            }
            if(!map.validRoom(controlInput))
            {
                System.Windows.Forms.MessageBox.Show("This path is closed. Please chose an open path through the cave.");
            }
            updateConnections();
            showRoom();
        }

        private void shoot_Click(object sender, EventArgs e)
        {
            if (player.getArrows() > 0 && map.validRoom(controlInput))
            {
                if (player.shootArrow(controlInput))
                {
                    turn.Text = "Total Turns: " + player.getTurns();
                    this.latestPlayer = player;
                    highscores.mutate(player);
                    win();
                }
                turn.Text = "Total Turns: " + player.getTurns();
                arrowBox.Text = "Total Arrows: " + player.getArrows();
                scoreBox.Text = "Total Score: " + player.getScore();
                map.moveBat();
                map.moveWumpus();
                if (player.getArrows() == 0)
                {
                    System.Windows.Forms.MessageBox.Show("You have zero arrows! You lose.");
                    this.Hide();
                    (new Lose()).Show();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("MISS");
                }

                }
        }

        private void buyarrow_Click(object sender, EventArgs e)
        {
            if (player.getGold() > 3)
            {
                if (player.purchaseArrows())
                {
                    System.Windows.Forms.MessageBox.Show("Awesome! You got 2 questions right, giving you 2 extra arrows!");

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Sorry, you didn't correctly answer enough questions. You did not recieve extra arrows.");

                }
                scoreBox.Text = "Total Score: " + player.getScore();
                arrowBox.Text = "Total Arrows: " + player.getArrows();
                goldBox.Text = "Total Gold: " + player.getGold();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Invalid purchase. Please obtain 3 coins or more.");
            }
        }

        private void buysecret_Click(object sender, EventArgs e)
        {
            if (player.getGold() > 3)
            {
                if (player.purchaseArrows())
                {
                    System.Windows.Forms.MessageBox.Show("Awesome! You got 2 questions right, giving you a secret piece of intelligence!");
                    System.Windows.Forms.MessageBox.Show(map.getSecret());

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Sorry, you didn't correctly answer enough questions. You did not recieve extra arrows.");

                }
                scoreBox.Text = "Total Score: " + player.getScore();
                goldBox.Text = "Total Gold: " + player.getGold();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Invalid purchase. Please obtain 3 coins or more.");
            }
        }

        private void updateConnections()
        {
            if (cave.availablePaths(map.getPlayerPos())[0] != -1)
            {
                N.Text = "N: O";
            }
            else
            {
                N.Text = "N: X";
            }

            if (cave.availablePaths(map.getPlayerPos())[1] != -1) { NE.Text = "NE: O"; }
            else { NE.Text = "NE: X"; }

            if (cave.availablePaths(map.getPlayerPos())[2] != -1) { SE.Text = "SE: O"; }
            else { SE.Text = "SE: X"; }

            if (cave.availablePaths(map.getPlayerPos())[3] != -1) { S.Text = "S: O"; }
            else { S.Text = "S: X"; }

            if (cave.availablePaths(map.getPlayerPos())[4] != -1) { SW.Text = "SW: O"; }
            else { SW.Text = "SW: X"; }

            if (cave.availablePaths(map.getPlayerPos())[5] != -1) { NW.Text = "NW: O"; }
            else { NW.Text = "NW: X"; }

        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void changemap_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new MainMenu()).Show();
        }

        private void highscore_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new HighScores()).Show();
        }

        private void Question_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void showRoom() {
            if (map.getPlayerPos() == 0)
            {
                PlayerPosition.Location = new Point(33, 458);
            }
            else if (map.getPlayerPos() == 1) {
                PlayerPosition.Location = new Point(61,472);
            }
            else if (map.getPlayerPos() == 2)
            {
                PlayerPosition.Location = new Point(89,458);
            }
            else if (map.getPlayerPos() == 3)
            {
                PlayerPosition.Location = new Point(117,472);
            }
            else if (map.getPlayerPos() == 4)
            {
                PlayerPosition.Location = new Point(144,458);
            }
            else if (map.getPlayerPos() == 5)
            {
                PlayerPosition.Location = new Point(171,472);
            }
            else if (map.getPlayerPos() == 6)
            {
                PlayerPosition.Location = new Point(33, 487);
            }
            else if (map.getPlayerPos() == 7)
            {
                PlayerPosition.Location = new Point(61,502);
            }
            else if (map.getPlayerPos() == 8)
            {
                PlayerPosition.Location = new Point(89,487);
            }
            else if (map.getPlayerPos() == 9)
            {
                PlayerPosition.Location = new Point(117,502);
            }
            else if (map.getPlayerPos() == 10)
            {
                PlayerPosition.Location = new Point(144,487);
            }
            else if (map.getPlayerPos() == 11)
            {
                PlayerPosition.Location = new Point(171,502);
            }
            else if (map.getPlayerPos() == 12)
            {
                PlayerPosition.Location = new Point(33,517);
            }
            else if (map.getPlayerPos() == 13)
            {
                PlayerPosition.Location = new Point(61,531);
            }
            else if (map.getPlayerPos() == 14)
            {
                PlayerPosition.Location = new Point(89,517);
            }
            else if (map.getPlayerPos() == 15)
            {
                PlayerPosition.Location = new Point(117,531);
            }
            else if (map.getPlayerPos() == 16)
            {
                PlayerPosition.Location = new Point(144,517);
            }
            else if (map.getPlayerPos() == 17)
            {
                PlayerPosition.Location = new Point(171,531);
            }
            else if (map.getPlayerPos() == 18)
            {
                PlayerPosition.Location = new Point(33,546);
            }
            else if (map.getPlayerPos() == 19)
            {
                PlayerPosition.Location = new Point(61,560);
            }
            else if (map.getPlayerPos() == 20)
            {
                PlayerPosition.Location = new Point(89,546);
            }
            else if (map.getPlayerPos() == 21)
            {
                PlayerPosition.Location = new Point(117,560);
            }
            else if (map.getPlayerPos() == 22)
            {
                PlayerPosition.Location = new Point(141,546);
            }
            else if (map.getPlayerPos() == 23)
            {
                PlayerPosition.Location = new Point(171,560);
            }
            else if (map.getPlayerPos() == 24)
            {
                PlayerPosition.Location = new Point(33,575);
            }
            else if (map.getPlayerPos() == 25)
            {
                PlayerPosition.Location = new Point(61,589);
            }
            else if (map.getPlayerPos() == 26)
            {
                PlayerPosition.Location = new Point(89,575);
            }
            else if (map.getPlayerPos() == 27)
            {
                PlayerPosition.Location = new Point(117,589);
            }
            else if (map.getPlayerPos() == 28)
            {
                PlayerPosition.Location = new Point(144,575);
            }
            else if (map.getPlayerPos() == 29)
            {
                PlayerPosition.Location = new Point(171,589);
            }
        }
    } 
}
