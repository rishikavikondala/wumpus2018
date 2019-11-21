using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus
{
    class Room
    {
        //array of exits in each room
        private int[] exits;
        private int roomNum;

        //constructor
        public Room(int room, int[] exits)
        {
            roomNum = room;
            this.exits = exits;
        }

        //a get function which returns the array of exits in a room
        public int[] getExits()
        {
            return exits;
        }
    }
}
