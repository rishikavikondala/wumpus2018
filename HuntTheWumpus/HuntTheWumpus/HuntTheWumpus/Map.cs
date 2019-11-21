using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus
{
    public class Map
    {
        private int playerPos;
        private int wumpusPos;
        private int[] batPos;
        private int[] ditchPos;
        //the rooms of chars is another 2d array that contains ' ' for each index. however, for each bat, ditch, wumpus, and player
        //there is a character for it. for example, if there was a bat on index 1, on the index of 1 on this 2d array,
        //instead of a ' ', it would contain a 'b'
        private char[] rooms;
        //this is a 2d array that contains the potential position that a bat, wumpus, or player 
        //can move into based on the index of their possition
        //for exampel, player is in the 0th room. therefore i look at the 0th index on this 2d array and look at the possible values
        private int[,] movement;
        //creates the C# random function
        private Random rnd = new Random();
        //sound object call
        Sound sound = new Sound();

        public void randomizePlayer()
        {
            if (rooms[playerPos].Equals('B'))
            {
                rooms[playerPos] = 'b';
            }
            else if (rooms[playerPos].Equals('D'))
            {
                rooms[playerPos] = 'd';
            }
            playerPos = rnd.Next(0, 30);
            while (!rooms[playerPos].Equals(' '))
            {
                playerPos = rnd.Next(0, 30);
            }
            rooms[playerPos] = 'p';
        }

        //creates a map objec with two parameters, each containing the number of bats/caves we you need
        public Map(int bat, int ditch, Cave cave)
        {
            movement = cave.getCaveSystem();
            rooms = new char[30];
            for (int i = 0; i < rooms.Length; i++)
            {
                rooms[i] = ' ';
            }
            batPos = new int[bat];
            ditchPos = new int[ditch];
            //create random position for both palyer and wumpus
            playerPos = rnd.Next(0, 30);
            rooms[playerPos] = 'p';
            wumpusPos = rnd.Next(0, 30);
            //checks if they are the same, if so, re assign it another random value
            while (playerPos == wumpusPos)
            {
                wumpusPos = rnd.Next(0, 30);
            }

            rooms[wumpusPos] = 'w';
            //create a for loop that sets the random values for each ditch and bat, and checks if they are the same
            for (int i = 0; i < batPos.Length; i++)
            {
                batPos[i] = rnd.Next(0, 30);

                while (rooms[batPos[i]] != ' ')
                {
                    batPos[i] = rnd.Next(0, 30);
                }

                rooms[batPos[i]] = 'b';
            }
            for (int i = 0; i < ditchPos.Length; i++)
            {
                ditchPos[i] = rnd.Next(0, 30);
                while (rooms[ditchPos[i]] != ' ')
                {
                    ditchPos[i] = rnd.Next(0, 30);
                }
                rooms[ditchPos[i]] = 'd';
            }

        }
        //this function will move all bats in the array into random positions
        //PRECONDITION: a bat will only randomly move onto indexes that are free
        //for example, a bat cannot move onto an index of a ditch, but IT CAN move onto the index of player
        public void moveBat()
        {
            for (int i = 0; i < batPos.Length; i++)
            {
                int count = 0;
                int newRoom = 0;
                for (int j = 0; j < 6; j++)
                {
                    if (movement[batPos[i], j] != -1 && (rooms[movement[batPos[i], j]] == ' ' || rooms[movement[batPos[i], j]] == 'p'))
                    {
                        count++;
                    }
                }
                newRoom = rnd.Next(1, count + 1);
                count = 0;
                for (int j = 0; j < 6; j++)
                {
                    if (movement[batPos[i], j] != -1 && (rooms[movement[batPos[i], j]] == ' ' || rooms[movement[batPos[i], j]] == 'p'))
                    {
                        count++;
                    }
                    if (count == newRoom && rooms[movement[batPos[i], j]] == 'p')
                    {
                        rooms[batPos[i]] = ' ';
                        batPos[i] = movement[batPos[i], j];
                        rooms[batPos[i]] = 'B';
                        newRoom = -1;
                    }
                    if (count == newRoom && rooms[batPos[i]] == 'b')
                    {
                        rooms[batPos[i]] = ' ';
                        batPos[i] = movement[batPos[i], j];
                        rooms[batPos[i]] = 'b';
                        newRoom = -1;
                    }
                }
            }
        }
        //this is used to move the wumpus into a random position based off its index
        //the wumpus can mvoe onto the player index as well
        public void moveWumpus()
        {
            int count = 0;
            for (int i = 0; i < 6; i++)
            {
                if (movement[wumpusPos, i] != -1 && (rooms[movement[wumpusPos, i]] == ' ' || rooms[movement[wumpusPos, i]] == 'p'))
                {
                    count++;
                }
            }
            int newRoom = rnd.Next(1, count + 1);
            count = 0;
            for (int i = 0; i < 6; i++)
            {
                if (movement[wumpusPos, i] != -1 && (rooms[movement[wumpusPos, i]] == ' ' || rooms[movement[wumpusPos, i]] == 'p'))
                {
                    count++;
                }

                if (count == newRoom && rooms[movement[wumpusPos, i]] == 'p')
                {
                    //the wumpus and the player are on the same rooms
                    rooms[wumpusPos] = ' ';
                    wumpusPos = movement[wumpusPos, i];
                    rooms[wumpusPos] = 'W';
                    newRoom = -1;
                }

                if (count == newRoom && rooms[wumpusPos] == 'w')
                {
                    rooms[wumpusPos] = ' ';
                    wumpusPos = movement[wumpusPos, i];
                    rooms[wumpusPos] = 'w';
                    newRoom = -1;
                }
            }
        }
        //this will move the player onto a given direction
        //the directions are based off the movement 2d array
        //example: (north, northeast, se, s, sw, nw) if this method is given a parameter of 0, it will move North

        //THIS METHOD CAN ONLY BE CALLED AFTER validRoom(dirction) IS CALLED TO CHECK IF THE ROOM IS VALID
        public void movePlayer(String d)
        {
            int x = StringDtoIntD(d);

            int move = movement[playerPos, x];
            rooms[playerPos] = ' ';
            playerPos = move;

            if (rooms[move] == ' ')
            {
                rooms[playerPos] = 'p';
            }
            else if (rooms[move] == 'd')
            {
                rooms[playerPos] = 'D';
            }
            else if (rooms[move] == 'w')
            {
                rooms[playerPos] = 'W';
            }
            else
            {
                rooms[playerPos] = 'B';
            }
        }
        //this is a simple method that just checks, based on the player's index, if there is an open room on the given parameter
        //example: if the paramter is given at 0 and the player can move North, return true, otherwise, false
        public bool validRoom(String d)
        {
            int x = StringDtoIntD(d);

            int move = movement[playerPos, x];
            if (move == -1)
            {
                return false;
            }
            return true;
        }
        //the possible values that a W, D, B. (if it returns a capital W, that means that player and Wumpus are on the same index)
        //(if it returns a captial B, then that means that player and a bat are on the same position)
        //(if it returns a captial D, then that means that player and a ditch are on the same position)
        public String getPlayerIndex()
        {
            return "" + rooms[playerPos];
        }
        //makes a noise and prints a statement if a bat,wumpus, or ditch is near by
        public void closeBy(String d)
        {

            for (int i = 0; i < 6; i++)
            {
                if (movement[playerPos, i] != -1)
                {
                    if (rooms[movement[playerPos, i]] == 'w')
                    {
                        Console.WriteLine("I smell a Wumpus!");
                    }
                    if (rooms[movement[playerPos, i]] == 'b')
                    {
                        Console.WriteLine("Bats Nearby");
                        sound.batsPresent();
                    }
                    if (rooms[movement[playerPos, i]] == 'p')
                    {
                        Console.WriteLine("I feel a draft");
                        sound.pitPresent();
                    }
                }

            }

        }
        //shoots an arrow into a certain directoin, 
        //if a bat is on the index of the direction parameter, then it will kill the bat and remove it from the batPos array
        //if a wumpus is on the index of the direction parameter, then it will kill the wumpus and you win
        public bool shoot(String d)
        {


            int x = StringDtoIntD(d);
            if (rooms[movement[playerPos, x]] == 'w')
            {
                return true;
            }
            if (rooms[movement[playerPos, x]] == 'b')
            {
                int[] newBatPos = new int[batPos.Length - 1];
                int j = 0;
                for (int i = 0; i < batPos.Length; i++)
                {
                    if (batPos[i] != movement[playerPos, x])
                    {
                        newBatPos[j] = batPos[i];
                        j++;
                    }
                }
                batPos = newBatPos;
                rooms[movement[playerPos, x]] = ' ';

            }
            return false;
            //rooms[movement[playerPos,x]] = ' '; ignore this

        }
        //this method is just used to help integrate map
        public int StringDtoIntD(String d)
        {
            d.ToUpper();
            int x = 0;
            if (d.Equals("N"))
            {
                x = 0;
            }
            else if (d.Equals("NE"))
            {
                x = 1;
            }
            else if (d.Equals("SE"))
            {
                x = 2;
            }
            else if (d.Equals("S"))
            {
                x = 3;
            }
            else if (d.Equals("SW"))
            {
                x = 4;
            }
            else
            {
                x = 5;
            }
            return x;
        }
        //returns THE INDEX of the player
        public int getPlayerPos()
        {
            return playerPos;
        }
        //returns the wumpus position INDEX
        public int getWumpusPos()
        {
            return wumpusPos;
        }
        //returns an array of bat positions INDEXES
        public int[] getBatPos()
        {
            return batPos;
        }
        //returns an array of ditch positions INDEXES
        public int[] getDitchPos()
        {
            return ditchPos;
        }


    }


}
