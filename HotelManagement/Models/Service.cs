using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    public class Service
    {
        public int Id { get; set; }
        public Room BelongToRoom { get; set; }
        public string ServiceName { get; set; }
        public int Price { get; set; }

        public string ToFilteringString()
        {
            return string.Format("{0} {1} {2}", BelongToRoom, ServiceName, Price);
        }
    }
}
