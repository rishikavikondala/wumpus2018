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
    public partial class TriviaForm : Form
    {
        private static Trivia questions = new Trivia();
        private String answer;
        private Sound triviaSound = new Sound();
        public int correct;
        

        public TriviaForm()
        {
            InitializeComponent();
        }

        private void TriviaForm_Load(object sender, EventArgs e)
        {
            this.correct = 0;
            Question.Text = questions.askQuestion();
        }

        private void Question_Click(object sender, EventArgs e)
        {

        }

        private void Answer_TextChanged(object sender, EventArgs e)
        {
            this.answer = (Answer.Text).ToLower();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (questions.checkAnswer(this.answer))
            {
                this.correct++;
                MessageBox.Show("Correct!");
                triviaSound.correct();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if(this.answer.Equals("a") || this.answer.Equals("b") || this.answer.Equals("c") || this.answer.Equals("d"))
            {
                MessageBox.Show("Wrong!");
                triviaSound.incorrect();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Not a valid input. Please try again");
            }            
        }
    }
}
