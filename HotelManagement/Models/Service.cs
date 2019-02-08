using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace HotelManagement
{
    public class ServiceBase
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public int Price { get; set; }
    }

    [Table("Services")]
    public class ServiceModel : ServiceBase
    {
        public int? RoomId { get; set; }
    }

    public class ServiceDisplay : ServiceBase
    {
        public Room BelongToRoom { get; set; }

        public string ToFilteringString()
        {
            return string.Format("{0} {1} {2}", BelongToRoom, ServiceName, Price);
        }
    }
}
