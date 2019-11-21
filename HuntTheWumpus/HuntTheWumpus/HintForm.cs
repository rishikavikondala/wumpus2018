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
    public partial class HintForm : Form
    {
        private static Trivia trivia = new Trivia();

        public HintForm()
        {
            InitializeComponent();
        }

        private void HintForm_Load(object sender, EventArgs e)
        {
            HintLabel.Text = trivia.giveHint();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
