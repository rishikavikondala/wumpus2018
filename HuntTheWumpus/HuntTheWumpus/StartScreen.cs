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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void play_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new MainMenu()).Show();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Instructions()).Show();
        }

        private void scores_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new HighScores()).Show();
        }
    }
}
