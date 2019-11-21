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
        private GameControl game;
        private Cave cave;
        private Map map;
        private Player player;
        public HighScoreManagement scores;
        private GraphicalInterface graphicalInterface;
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
            player = new Player("Charlie", cave, map);
            sound = new Sound();
            highscores = new HighScores();
            updateConnections();
        }
        public static bool getWinLose()
        {
            return winloseVar;
        }

        /*public static void Main(string[] args)
        {
            while (getWinLose() == false)
            {

            }
        }*/

        public void newTopTen(Player input)
        {
            this.scores.newTopTen(input);
        }

        public Player[] getScores()
        {
            Player[] result = new Player[10];
            for (int a = 0; a < 10; a++)
            {
                result[a] = this.scores.getScore(a);
            }
            return result;
        }

        public void mutateScores(Player[] change)
        {
            for (int a = 0; a < 10; a++)
            {
                this.scores.changeScore(change[a], a);
            }
        }
        private void input_TextChanged(object sender, EventArgs e) { controlInput = input.Text; }

        private void quit_Click(object sender, EventArgs e) { Application.Exit(); }

        private void win() { this.Hide(); (new Win()).Show(); }

        private void lose() { this.Hide(); (new Lose()).Show(); }

        private void move_Click(object sender, EventArgs e)
        {
            if (player.validMove(controlInput) || controlInput.Length > 0)
            {
                player.Move(controlInput);
                if (map.getPlayerIndex() == "W")
                {
                    playerOpposite.Image = Image.FromFile(graphicalInterface.displayPit());
                    status.Text = "You are in the same cave as the Wumpus!";
                    Thread.Sleep(1500);
                    player.WumpTrivia();
                }
                if (map.getPlayerIndex() == "D")
                {
                    playerOpposite.Image = Image.FromFile(graphicalInterface.displayPit());
                    status.Text = "You have fallen into a ditch! You lose!";
                    Thread.Sleep(2000);
                    this.Hide();
                    (new Lose()).Show();
                    Thread.Sleep(2000);
                    this.Hide();
                    (new HighScores()).Show();
                }
                if (map.getPlayerIndex() == "B")
                {
                    playerOpposite.Image = Image.FromFile(graphicalInterface.displayBat());
                    status.Text = "You have run into a bat! You're getting moved!";
                    map.randomizePlayer();
                }
                goldBox.Text = "Total Gold: " + player.getGold();
                scoreBox.Text = "Total Score: " + player.getScore();
            }
            updateConnections();
        }

        private void shoot_Click(object sender, EventArgs e)
        {
            if (player.getArrows() > 0)
            {
                if (player.shootArrow(controlInput))
                {
                    this.latestPlayer = player;
                    highscores.mutate(player);
                    win();
                }
                arrowBox.Text = "Total Arrows: " + player.getArrows();
                scoreBox.Text = "Total Score: " + player.getScore();
            }
        }

        private void buyarrow_Click(object sender, EventArgs e)
        {
            if (player.getGold() > 3)
            {
                player.purchaseArrows();
                scoreBox.Text = "Total Score: " + player.getScore();
            }
            else
            {
                status.Text = "Invalid purchase. Please obtain 3 coins or more.";
                Thread.Sleep(3000);
                status.Text = "Game Status:                          ";
            }
        }

        private void buysecret_Click(object sender, EventArgs e)
        {
            if (player.getGold() > 3)
            {
                player.purchaseSecret();
                scoreBox.Text = "Total Score: " + player.getScore();
            }
            else
            {
                status.Text = "Invalid purchase. Please obtain 3 coins or more.";
                Thread.Sleep(3000);
                status.Text = "Game Status:                          ";
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
    } 
}
