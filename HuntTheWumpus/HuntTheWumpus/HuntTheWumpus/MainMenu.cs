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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void map1_Click(object sender, EventArgs e)
        {
            String path = @"C:\Users\pumpk\source\repos\HuntTheWumpus\HuntTheWumpus\bin\Debug\jamesCave1.txt";
            Cave cave = new Cave(path, "Cave 1");
            this.Hide();
            (new Game(cave)).Show();

        }

        private void map2_Click(object sender, EventArgs e)
        {
            String path = @"C:\Users\pumpk\source\repos\HuntTheWumpus\HuntTheWumpus\bin\Debug\osbertCave2.txt";
            Cave cave = new Cave(path, "Cave 2");
            this.Hide();
            (new Game(cave)).Show();
        }

        private void map3_Click(object sender, EventArgs e)
        {
            String path = @"C:\Users\pumpk\source\repos\HuntTheWumpus\HuntTheWumpus\bin\Debug\ryanCave3.txt";
            Cave cave = new Cave(path, "Cave 3");
            this.Hide();
            (new Game(cave)).Show();
        }

        private void map4_Click(object sender, EventArgs e)
        {
            String path = @"C:\Users\pumpk\source\repos\HuntTheWumpus\HuntTheWumpus\bin\Debug\rishiCave4.txt";
            Cave cave = new Cave(path, "Cave 4");
            this.Hide();
            (new Game(cave)).Show();
        }

        private void map5_Click(object sender, EventArgs e)
        {
            String path = @"C:\Users\pumpk\source\repos\HuntTheWumpus\HuntTheWumpus\bin\Debug\adrienneCave5.txt";
            Cave cave = new Cave(path, "Cave 5");
            this.Hide();
            (new Game(cave)).Show();
        }
    }
}
