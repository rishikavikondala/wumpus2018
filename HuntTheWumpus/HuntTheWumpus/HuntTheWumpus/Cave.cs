using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace HuntTheWumpus
{
    public class Cave
    {
        private int[,] caveSystem;
        private String nameCave;

        public Cave(String nameCave)
        {
            caveSystem = new int[30, 6];
            this.nameCave = nameCave;
        }

        public Cave(String path, String nameCave)
        {

            caveSystem = new int[30, 6]; //makes an array of 30x7 to store cave number and connections
            this.nameCave = nameCave;

            using (var reader = new StreamReader(path))
            {
                int index = 0;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    for (int i = 0; i < values.Length; i++)
                    {
                        caveSystem[index, i] = Int32.Parse(values[i]); //stores values into main 2d array
                    }
                    index++;
                }
            }

        }

        public int[] availablePaths(int roomNum)
        { //gets an array of the avalibale rooms param = rooms number from 1-30
            int[] paths = new int[6];
            for (int i = 0; i < paths.Length; i++)
            {
                paths[i] = caveSystem[roomNum, i];
            }
            return paths;
        }

        public string getName()
        {
            return nameCave;
        }

        public int[,] getCaveSystem()
        {
            return caveSystem;
        }

    }
}

