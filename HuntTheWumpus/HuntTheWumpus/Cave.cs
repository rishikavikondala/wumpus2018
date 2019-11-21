using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace HuntTheWumpus
{
    /*
     This cave class parses a CSV file and stores integers in the caveSystem 2D array
     The values range from -1 to 29, indicating either no connection (-1) or which ever room it connects to
     (0-29) sample: [-1, 25, -1, -1, 4, -1] The room connects to room 25, and 4 which are in the direction
     of NE and SW. [N, NE, SE, S, SW, NW]

     The availablePath method recieves a room index as a parameter (0-29) and returns that room's connections
     in the form of an array
         */
    public class Cave
    {
        private int ROW = 30;
        private int COL = 6;
        private int[,] caveSystem; //stores cave system (2D array to store connections)
        private String nameCave; //stores name of cave for high score

        public Cave(String nameCave) //makes a blank cave, for testing purposes
        {
            caveSystem = new int[ROW, COL];
            this.nameCave = nameCave;
        }

        public Cave(String path, String nameCave)
        { //Creates a cave, taking in a file address and a high score cave name

            caveSystem = new int[ROW, COL]; //makes an array of 30x6 to store cave number and connections
            this.nameCave = nameCave;

            using (var reader = new StreamReader(path)) //Streamreader reads the CSV of cave conections
            {
                int index = 0;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(','); //split divides the information in the CSV into the caveSystem 2D array
                    for (int i = 0; i < values.Length; i++)
                    {
                        caveSystem[index, i] = Int32.Parse(values[i]); //stores values into main 2d array
                    }
                    index++;
                }
            }
        }

        public int[] availablePaths(int roomNum)
        { //gets an array of the avalibale rooms param = rooms number from 0-29
            int[] paths = new int[6];
            for (int i = 0; i < paths.Length; i++)
            {
                paths[i] = caveSystem[roomNum, i];
            }
            return paths;
        }

        public string getName()
        { //returns the cave's name for high score purposes
            return nameCave;
        }

        public int[,] getCaveSystem()
        { //returns 2D array caveSystem used for Map
            return caveSystem;
        }

    }
}
