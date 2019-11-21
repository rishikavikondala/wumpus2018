using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus
{
    public class Trivia
    {
        private Question[] list;
        private String[] hints;
        private int place;
        private int numHints;
        //global variable for the number of questions in the list and hints needed
        private int LISTLENGTH = 10;

        public Trivia()
        {
            this.place = 0;
            this.list = new Question[LISTLENGTH];
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("trivia.txt"))
                {
                    string line;
                    int count = 0;
                    int count2 = 0;
                    for (int a = 0; a < LISTLENGTH; a++)
                    {
                        list[a] = new Question();
                    }

                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (count > 5)
                        {
                            count2++;
                            count -= 6;
                        }
                        if (count % 5 == 0 && count != 0)
                        {
                            list[count2].setAnswer(line);
                        }
                        else if (count % 4 == 0 && count != 0)
                        {
                            list[count2].setOptionD(line);
                        }
                        else if (count % 3 == 0 && count != 0)
                        {
                            list[count2].setOptionC(line);
                        }
                        else if (count % 2 == 0 && count != 0)
                        {
                            list[count2].setOptionB(line);
                        }
                        else if (count % 1 == 0 && count != 0)
                        {
                            list[count2].setOptionA(line);
                        }
                        else
                        {
                            list[count2].setQuestion(line);
                        }
                        count++;
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.

                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);

            }

            this.hints = new String[LISTLENGTH];
            using (StreamReader sr = new StreamReader("hints.txt"))
            {
                String line;
                int count = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    this.hints[count] = line;
                    if(count < this.hints.Length - 1)
                    {
                        count++;
                    }
                }
            }
        }
        public String askQuestion()
        {
            string result = list[place].getQuestion() + "\n" + list[place].getOptionA() + "\n" +
                list[place].getOptionB() + "\n" + list[place].getOptionC() + "\n" +
                list[place].getOptionD() + "\n";
            place++;
            return result;
        }
        public String giveHint()
        {
            Random rand = new Random();
            String hint;
            if (numHints <= this.hints.Length - 1)
            {
                int num = rand.Next(this.hints.Length - (1 + numHints));
                hint = this.hints[num];
                for (int a = num; a < this.hints.Length - (1 + numHints); a++)
                {
                    this.hints[a] = this.hints[a + 1];
                }
            }
            else
            {
                hint = "There are no more hints!";
            }
            numHints++;
            return hint;
        }

        public bool checkAnswer(String input)
        {
            if (input.Equals(list[place - 1].getAnswer()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}