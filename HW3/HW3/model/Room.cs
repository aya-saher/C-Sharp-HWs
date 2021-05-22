using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW3.model
{
    class Room
    {
        private int roomid;
        private string roomname;

        public Room(int roomid, string roomname)
        {
            this.roomid = roomid;
            this.roomname = roomname;
        }

        public int RoomId
        {
            set
            {
                roomid = value;
            }
            get
            {
                return this.roomid;
            }

        }

        public String RoomName
        {
            set
            {
                roomname = value;
            }
            get
            {
                return this.roomname;
            }

        }

        public override string ToString()
        {
            return this.roomname;
        }
    }
}
