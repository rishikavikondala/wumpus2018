using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus
{
    public class Question
    {
        private String Q;
        private String OptionA;
        private String OptionB;
        private String OptionC;
        private String OptionD;
        private String answer;

        public String getQuestion()
        {
            return this.Q;
        }
        public String getOptionA()
        {
            return this.OptionA;
        }
        public String getOptionB()
        {
            return this.OptionB;
        }
        public String getOptionC()
        {
            return this.OptionC;
        }
        public String getOptionD()
        {
            return this.OptionD;
        }
        public String getAnswer()
        {
            return this.answer;
        }
        public void setQuestion(String input)
        {
            this.Q = input;
        }
        public void setOptionA(String input)
        {
            this.OptionA = input;
        }
        public void setOptionB(String input)
        {
            this.OptionB = input;
        }
        public void setOptionC(String input)
        {
            this.OptionC = input;
        }
        public void setOptionD(String input)
        {
            this.OptionD = input;
        }
        public void setAnswer(String input)
        {
            this.answer = input;
        }
    }
}
