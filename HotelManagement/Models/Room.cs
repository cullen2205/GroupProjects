using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomName { get; set; }

        public override string ToString()
        {
            return RoomName;
        }
    }
}
