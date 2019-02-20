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

        [Computed]
        public string DisplayString
        {
            set { }
            get
            {
                return string.Format("{0} {1}", ServiceName, BelongToRoom);
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", BelongToRoom, ServiceName, Price);
        }
    }

    public class ServiceMapped : ServiceModel
    {
        //Id, ServiceName, Price, RoomId, Count, BillId, BelongToRoom
        public int Count { get; set; }
        public int BillId { get; set; }
        public int BillDetailId { get; set; }

        [Computed]
        public Room BelongToRoom { get; set; }
    }
}
