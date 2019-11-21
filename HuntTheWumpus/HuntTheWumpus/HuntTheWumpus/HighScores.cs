using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuntTheWumpus
{
    public partial class HighScores : Form
    {
        private HighScoreManagement highscores;
        public HighScores()
        {
            InitializeComponent();
            highscores = new HighScoreManagement();
        }

        public void mutate(Player input)
        {
            highscores.newTopTen(input);
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new StartScreen()).Show();
        }

        private void HighScores_Load(object sender, EventArgs e)
        {
            scores.Text = highscores.toString();
        }
    }
}
